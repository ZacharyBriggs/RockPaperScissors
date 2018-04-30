using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public class RPS
    {
        public string PlayerChoice;
        public string ComputerChoice;
        public List<string> VictoryConditions = new List<string>();
        public string SelectPlayerChoice(string word)
        {
            if (word == "rock")
                PlayerChoice = "rock";
            if (word == "paper")
                PlayerChoice = "paper";
            if (word == "scissors")
                PlayerChoice = "scissors";
            return word;
        }

        public string SelectComputerChoice()
        {
            Random rand = new Random();
            var choice = rand.Next(1, 4);
            if (choice == 1)
                ComputerChoice = "rock";
            if (choice == 2)
                ComputerChoice = "paper";
            if (choice == 3)
                ComputerChoice = "scissors";
            return ComputerChoice;
        }

        public string CheckForVictory()
        {
            string outcome = "";
            if (PlayerChoice == "rock" && ComputerChoice == "paper" ||
                PlayerChoice == "scissors" && ComputerChoice == "rock" ||
                PlayerChoice == "paper" && ComputerChoice == "scissors")
            {
                outcome = "Computer Wins.\n";
            }
            else if (ComputerChoice == "rock" && PlayerChoice == "paper" ||
                ComputerChoice == "scissors" && PlayerChoice == "rock" ||
                ComputerChoice == "paper" && PlayerChoice == "scissors")
            {
                outcome = "Player Wins.\n";
            }
            else
            {
                outcome = "Nobody Wins.\n";
            }
            VictoryConditions.Add(outcome);
            return outcome;
        }
        static class Program
    {

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
