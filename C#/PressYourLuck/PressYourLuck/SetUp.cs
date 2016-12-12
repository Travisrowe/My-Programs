/*
 * This class will be used to define the functionality for the setup window
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
    public partial class SetUp : Form
    {
        //** Class Variables **//

        private static int numOfPlayers;
        //variable to hold path to the file of questions
        private static string questionFilePath;
        /*
         * Constructor
         */ 
        public SetUp()
        {
            InitializeComponent();
        }
        /*
         * This method allows the user to select their file of questions to be used in the game
         */ 
        private void fileChooseButton_Click(object sender, EventArgs e)
        {
            //creating new instance of FileExplorer
            FileExplorer file = new FileExplorer();
            file.ShowDialog();
            questionFilePath = file.getFilePath();
            filePathPreview.Text = questionFilePath;
        }
        /*
         *This method gets the number of players selected from the dropbox
         */
        private void numOfPlayersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numOfPlayers = Int32.Parse(numOfPlayersComboBox.SelectedItem.ToString());
        }
        /*
         * Method to return the questionFile path
         */ 
        public string getQuestionFilePath()
        {
            return questionFilePath;
        }
        /*
         * Method to return the number of players
         */ 
        public static int getNumOfPlayers()
        {
            return numOfPlayers;
        }
        /*
         * Method to handle click event of okay button (simply closes the form)
         */ 
        private void okayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
