/*
 * Class to define data associated with each player in the game.
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressYourLuck
{

    public class Player
    {
        //** Class Variables **//

        private int score;
        private int spins;

        /*
         * Constructor
         */ 
        public Player()
        {
            score = 0;
            spins = 3;
        }
        /*
         * Method to return player score
         */ 
        public int getScore()
        {
            return score;
        }
        /*
         * Method to return player spins
         */ 
        public int getSpins(){
            return spins;
        }
        /*
         * Method to add a value to score
         */ 
        public void addToScore(int x)
        {
            score += x;
        }
        /*
         * Method to decrement player spins
         */ 
        public void decrementSpins()
        {
            spins--;
        }
        /*
         * Method to handle whammy event
         */
        public void whammy()
        {
            score = 0;
        }
        /*
         * Method to add spins
         */ 
        public void addToSpins(int x){
            spins += x;
        }
    }
}
