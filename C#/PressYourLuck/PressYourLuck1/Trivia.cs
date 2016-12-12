/*
 * This form will be used to house the trivia portion of the game.
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

namespace PressYourLuck
{
    public partial class Trivia : Form
    {
        //**Class Variables**//
        //random number generator
        Random rand = new Random(2); // set to 2 for debugging
        //string to holde file path of question file
        private string questionFilePath;
        //string array to hold questions read in from file
        List<String> questions = new List<String>();
        //string array to hold answers read in from file
        List<String> answers = new List<String>();
        //Int to hold number of questions
        private int numQuestions;
        //string to hold the number of the buzzed-in player
        private static int playerNum;
        //int to hold the index of a given question
        private int index; 
        //int to count the number of questions asked
        private int questionCount;
        //SetUp reference to be used in class
        private SetUp set;
        //List of players to be created here and passed to GameDisplay
        List<PressYourLuck.Player> players;
        private List<Label> labels;
        /*
         * Parameterized constructor
         */ 
        public Trivia(List<PressYourLuck.Player> p)
        {
            InitializeComponent();

            set = new SetUp();
            players = p;
            questionCount = 0; 
            numQuestions = 0;
            questionFilePath = set.getQuestionFilePath();
            questionFilePath = questionFilePath.Replace("\\bin\\Debug", "");
            labels = Controls.OfType<Label>().Where(x => x.Name.EndsWith("Spin")).ToList();
            Console.WriteLine(labels.Count);

            this.Visible = true;

            //Read in question files
            string[] lines = System.IO.File.ReadAllLines(@questionFilePath);

                int lineCount = 0, indexCount = 0;
                foreach (string line in lines)
                {
                    if (lineCount % 2 == 0) // A question every 2 lines
                    {
                        questions.Add(line);
                        numQuestions++;
                    }
                    else
                    {
                        answers.Add(line);
                        indexCount++; // index will change every 2 lines
                    }
                    lineCount++;
                }
            
            //randomly choose a question, marking it as used after 
            index = rand.Next() % numQuestions;
        }
        /*
         * Method to delete a question from the array after it has been used
         */ 
        public void markRead()
        {
            questions[index] = null;
            answers[index] = null;
        }
        /*
         * Method to set display the player's score in their respective labels
         */ 
        public void setScoreLabels(Player player)
        {
            player.addToSpins(1);
        }
        /*
         * Button will randomize and display questions.
         */ 
        private void button1_Click(object sender, EventArgs e)
        {
            if (questionCount < 4)
            {
                readyButton.Enabled = false;
                do
                {
                    index = rand.Next() % numQuestions;
                } while (questions.ElementAt(index) == null);
                question.Text = questions[index]; // display the question
                questionCount++;
                this.ActiveControl = BuzzinTextbox;
                BuzzinTextbox.KeyPress += new KeyPressEventHandler(Trivia_KeyPress);
                
                answerText.Enabled = true;
                readyButton.Enabled = false;
                
            }
            else
            {
                //call gameboard
                GameDisplay game = new GameDisplay(players);
                game.ShowDialog();
            }
        }
        /*
         * Method which detects which "buzz-in" key was pressed and allows
         * players to answer
         */ 
        private void Trivia_KeyPress(object sender, KeyPressEventArgs e)
        {
            BuzzinTextbox.Enabled = false;
            this.ActiveControl = answerText;
            AnswerButton.Enabled = true;
            question.Text = questions[index];
                if (e.KeyChar == 'q')
                {
                    question.Text = "Player1 has buzzed in!";
                    answerText.Clear();
                    e.Handled = true;
                    playerNum = 0;
                    
                }
                else if (e.KeyChar == 'p')
                {
                    question.Text = "Player2 has buzzed in!";
                    answerText.Clear();
                    e.Handled = true;
                    playerNum = 1;
                }
                else if (e.KeyChar == (char)Keys.Space && players.ElementAt(2) != null)
                {
                    question.Text = "Player3 has buzzed in!";
                    answerText.Clear();
                    e.Handled = true;
                    playerNum = 2;
                }
            

        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (answerText.Text.ToUpper() == answers.ElementAt(index).ToUpper())
            {
                question.Text = "Correct!";
                setScoreLabels(players[playerNum]);
                updatePlayerSpinLabels();
            }
            else
            {
                answerText.Text = "Incorrect!";
                question.Text = answers[index];
            }
            // Removes the current question from use this game
            markRead();
            answerText.Clear();
            BuzzinTextbox.Enabled = true;
            answerText.Enabled = false;
            readyButton.Enabled = true;
            AnswerButton.Enabled = false;
        }

        private void updatePlayerSpinLabels()
        {
            for (int i = 0; i < players.Count; i++)
            {
                labels.ElementAt(i).Text = "Player " + (i + 1).ToString() + "\nSpins: " + players.ElementAt(i).getSpins();
            }
        } 
    }
}
