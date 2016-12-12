/* Austin Cullar, Travis Rowe
 * CMPS 4143
 * 
 * This program runs an imitation of the 'Press Your Luck' game show, in which
 * multiple players will be able to participate.
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace PressYourLuck
{
    public partial class GameDisplay : Form
    {
        //**Class Variables**//

        //random number generator 
        private Random rand = new Random();
        //regular expression to be used in deciding value of image
        private Regex regValue = new Regex(@"[0-9]*0", RegexOptions.IgnoreCase);
        //regular expression to be used in deciding spin addition
        private Regex regSpin = new Regex(@"(?<=_)\d(?=_)", RegexOptions.IgnoreCase);
        //list of picture boxes
        private List<PictureBox> pictureBoxes;
        //variable to be used in threading as a start/stop indicator
        //keyword "volatile" allows two threads to access the same variable
        private volatile bool _shouldStop = false;
        //assembly reference
        private Assembly assembly;
        //stream to read in imaages from embedded image files
        private Stream imageStream;
        //list to hold all images
        private List<Image> imageList;
        //list to contain image file names (runs parallel to imageList)
        private List<String> imageNames;
        //gets the current player number (players[0] = player number 1)
        private int playerNumber;
        //list reference to refer to the list of players passed in from Trivia
        private List<Player> players;
        //integer to store the index of the currently selected picturebox
        private int picIndex = 0;
        //list to contain labels
        private List<Label> scoreLabels;
           
        /*
         * Parametarized class constructor
         * Experiment with passing a list of Players from the Trivia class to GameDisplay, then
         * parameterize the main constructor appropriately
         */ 
        public GameDisplay(List<Player> p)
        {
            InitializeComponent();

            //pulling all picture boxes from the GameDisplay and putting them into an array
            pictureBoxes = Controls.OfType<PictureBox>().ToList();

            //list to contain GameBoardImages
            imageList = new List<Image>();
            
            //get the current assembly
            assembly = Assembly.GetExecutingAssembly();

            //store all resource names associated with the executing assembly which end in "_GameBoardImage.png" in a list
            imageNames = Assembly.GetExecutingAssembly().GetManifestResourceNames().Where(x => x.EndsWith("_GameBoardImage.png")).ToList();

            //saving player list reference into a class variable
            players = p;

            //list to hold all player score labels
            scoreLabels = Controls.OfType<Label>().Where(x => x.Name.EndsWith("ScoreLabel")).ToList();

            //getting images...
            Bitmap temp;
            foreach (var im in imageNames)
            {
                //stream to allow for the reading of the resources into a new data structure
                imageStream = assembly.GetManifestResourceStream(im);

                try
                {
                    //add the images to a list
                    temp = new Bitmap(imageStream);
                    imageList.Add(new Bitmap(ResizeImage(temp, 55, 55)));
                }
                catch
                {
                    MessageBox.Show("Problem getting images!");
                }
            }
            
            //randomly populate gameboard with images
            populateGameBoard();
            //setting player stat labels
            updatePlayerScoreLabels();
            //setting player turn label
            PlayerTurnLabel.Text = "Now spinning: Player " + getPlayer().ToString();
        }
        /*
         * This method handles the click event associated with the Start/Stop Button
         * below the Game Display.
         */
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            //after the start button is pressed, the text will be changed to "Stop!"
            if (StartStopButton.Text == "Spin!")
            {
                pictureBoxes.ElementAt(picIndex).BackColor = Color.Transparent;
                StartStopButton.Text = "Stop!";

                //declaring thread for cursor randomization
                System.Threading.Thread randomCursorThread;
                randomCursorThread = new System.Threading.Thread(new System.Threading.ThreadStart(RandomCursor));
                randomCursorThread.Start(); //begin randomCursorThread
            }
            else //StartStopButton.Text = "Stop!"
            {
                StartStopButton.Text = "Spin!";
                RequestStop();
                Thread.Sleep(400); //give the thread time to get the message
                _shouldStop = false;
                players.ElementAt(getPlayer() - 1).decrementSpins();
                updatePlayerTurnLabel();
                updatePlayerScoreLabels();
                //if no players have any remaining spins, announce the winner; game over
                if (getPlayer() < 0)
                {
                    announceWinner();
                    this.Close();
                }   
            }
        }
        /*
         * Method to be used to randomly move the game cursor to different labels.
         * Cursor position is represented as a change in backcolor of a particular label.
         * 
         * This method will operate on its own seperate thread, awaiting the value of the
         * volatile variable _shouldStop to change.
         */
        private void RandomCursor()
        { 
            int numOfCursChanges = 0;

            PictureBox currPic = pictureBoxes[rand.Next(0, pictureBoxes.Count)]; //set currPic to a random picturebox

            while (!_shouldStop)
            {
                numOfCursChanges++;

                currPic = pictureBoxes[rand.Next(0, pictureBoxes.Count)]; //randomly select a picturebox on the board

                currPic.BackColor = Color.Red; //highlight image

                //randomize images in pictureboxes every other cursor change
                if (numOfCursChanges == 2)
                {
                    numOfCursChanges = 0;

                    foreach (PictureBox p in pictureBoxes)
                    {
                        if (IsHandleCreated)
                        {
                            p.Invoke((Action)(() => { p.Image = imageList.ElementAt(rand.Next(0, imageList.Count)); }));
                        }
                    }
                }
                
                System.Threading.Thread.Sleep(350); //Pause

                currPic.BackColor = Color.Transparent; //de-highlight image
            }

            //keep current picture highlighted
            currPic.BackColor = Color.Red;

            //get chosen picture's value
            addValue(currPic.Image);

            addSpin(currPic.Image);
            //add value to player's scrore...

            //saving currPic index
            picIndex = pictureBoxes.IndexOf(currPic);

        }
        /*
         * Method used to populate the board with random images before the round begins
        */
        private void populateGameBoard()
        {
            foreach (PictureBox p in pictureBoxes)
            {
                p.Image = imageList.ElementAt(rand.Next(0, imageList.Count));
            }
        }
        /*
         * Method to decode the chosen image's worth
         * The method takes advantage of regular expressions to isolate the part of the image name indicative of the image value
         */
        private void addValue(Image i)
        {
            //if-condition interpretation: get the image name by taking advantage of the fact that imageList and imageNames run parallel to each other
            //use regular expression to get the part of the string associated with the value of the image
            //parse the resulting string into an integer to get the value
            //if the value is less than 10, it's a whammy
            if (Int32.Parse(regValue.Match(imageNames.ElementAt(imageList.IndexOf(i)).ToString()).ToString()) < 10) 
                players.ElementAt(getPlayer() - 1).whammy();
            else
                players.ElementAt(getPlayer()-1).addToScore(Int32.Parse(regValue.Match(imageNames.ElementAt(imageList.IndexOf(i)).ToString()).ToString()));
        }
        /*
         * Method to add spins if the selected image calls for it
         * The method takes advantage of regular expressions to isolate the part of the image name indicative of a spin addition
         */ 
        private void addSpin(Image i)
        {
            if (regSpin.Match(imageNames.ElementAt(imageList.IndexOf(i)).ToString()).ToString() != "")
            {
                players.ElementAt(getPlayer() - 1).addToSpins(1);
            }
        }
        /*
         * Method used to order player turns. Players will spin in ascending order.
         * The method returns the player index + 1, as long as the given player has any spins remaining
         * (the method's functionality was originally designed for the score labels)
         */
        private int getPlayer()
        {
            foreach (Player p in players)
            {
                if (p.getSpins() > 0)
                {
                    return players.IndexOf(p) + 1;
                }
            }
            //no player has any spins
            return -1;
        }
        /*
         * Method to be used in setting player score on all score labels on board
         */ 
        private void updatePlayerScoreLabels()
        {
            for (int i = 0; i < players.Count; i++)
            {
                scoreLabels.ElementAt(i).Text = "Player " + (i+1).ToString() + "\nScore: " + players.ElementAt(i).getScore() + "\nSpins: " + players.ElementAt(i).getSpins();
            }
        }
        /*
         * Method to announce the winner of the round
         */ 
        private void announceWinner()
        {
            Player winner = new Player();
            foreach (Player p in players)
            {
                if (p.getScore() > winner.getScore())
                {
                    winner = p;
                }
            }
            MessageBox.Show("Player " + (players.IndexOf(winner) + 1).ToString() + " is the winner!");
        }
        /*
         * Method used to resize the image
         * This method was written by user, mpen on StackOverflow
         * http://stackoverflow.com/questions/1922040/resize-an-image-c-sharp
         */
        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
         /* 
         * Method used to request the termination of the RandomCursor thread/method
         */
        private void RequestStop()
        {
            _shouldStop = true;
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine((1 % 3).ToString());
            Console.WriteLine((2 % 3).ToString());
            Console.WriteLine((3 % 3).ToString());
            //if the next player in ascending order exists...
            if (players.ElementAtOrDefault(getPlayer()) != null)
            {
                //pass the spins
                players.ElementAt(getPlayer()).addToSpins(players.ElementAt(getPlayer() - 1).getSpins());
                //zero-out current player's spins
                players.ElementAt(getPlayer() - 1).addToSpins(-players.ElementAt(getPlayer() - 1).getSpins());
                updatePlayerScoreLabels();
                updatePlayerTurnLabel();
            }
        }
        /*
         * Method to update label displaying which player is next to spin
         */
        private void updatePlayerTurnLabel()
        {
            if (getPlayer() > 0)
            {
                PlayerTurnLabel.Text = "Now spinning: Player " + getPlayer().ToString();
            }
        }
    }
}
