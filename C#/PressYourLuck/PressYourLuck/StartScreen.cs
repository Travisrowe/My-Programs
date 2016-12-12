/*
 * This form will be used as the start screen from which the user
 * will be able to navigate to all other windows by means of form controls.
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
    public partial class StartScreen : Form
    {
        //** Class Variables **//

        //private instance of SetUp
        private SetUp set;
        
        private List<Player> players;

        public StartScreen()
        {
            InitializeComponent();
            set = new SetUp();
            players = new List<Player>();
        }
        //Method to show settings dialog window
        private void settingsButton_Click(object sender, EventArgs e)
        {
            set.ShowDialog();
        }
        //Method to handle close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Method containing start button functionality
        private void startButton_Click(object sender, EventArgs e)
        {
            //if a file has not been selected...
            if (set.getQuestionFilePath() == null)
            {
                MessageBox.Show("Please select your question file in the settings menu before starting a new game!");
                return;
            }

            //initialize players
            if (SetUp.getNumOfPlayers() == 0)
            {
                MessageBox.Show("Please select the number of players in the settings menu!");
                return;
            }

            initPlayers(SetUp.getNumOfPlayers());

            //main functionality of program
            this.Visible = false;

            Trivia triv = new Trivia(players);
            //triv.ShowDialog();

        }
        //Method containing help button functionality
        private void helpButton_Click(object sender, EventArgs e)
        {
            helpWindow help = new helpWindow();
            help.ShowDialog();
        }
        //Method used to initialize players based on what number the user has specified in settings
        private void initPlayers(int n)
        {
            //need to experiment with this; players will be unnamed and will be referenced by index only
            for (int i = 0; i < n; i++)
            {
                players.Add(new Player());
            }
        }
    }
}
