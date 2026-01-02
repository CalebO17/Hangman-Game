using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

// Caleb O'Hara - Scoreboard is for keep tracking of current and previous game scores

namespace HangmanAssignment
{
    internal class Scoreboard
    {
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }

        public string PreviousGameWinner { get; set; }

        public string HighestNumbWins { get; set; }

        public string PreviousGameWord { get; set; }

        private int player1Wins;
        public int Player1Wins
        {
            get
            {
                return player1Wins;
            }
            set
            {
                if (value > 0)
                {
                    player1Wins = value;
                }
            }
        }

        private int player2Wins;

        public int Player2Wins
        {
            get
            {
                return player2Wins;
            }
            set
            {
                if (value > 0)
                {
                    player2Wins = value;
                }
            }

        }

        public Scoreboard()
        {
          //default constructor
        }
        public Scoreboard(string player1Name, string player2Name)
        {
            Player1Name = player1Name;
            Player2Name = player2Name;
            PreviousGameWinner = "No previous game";
            PreviousGameWord = "No previous game";
            Player1Wins = 0;
            Player2Wins = 0;
            HighestNumbWins = "Tie";
        }

    }
}
            
        
    

