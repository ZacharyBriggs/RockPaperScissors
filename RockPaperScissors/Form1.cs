using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new RPS();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "Player Chose: " + game.SelectPlayerChoice("rock") + "\n";
            richTextBox1.Text += "Computer Chose: " + game.SelectComputerChoice() + "\n";
            richTextBox1.Text += game.CheckForVictory();
            string json = JsonConvert.SerializeObject(game.VictoryConditions);
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "json.txt");
            System.IO.File.WriteAllText(path, json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "Player Chose: " + game.SelectPlayerChoice("paper") + "\n";
            richTextBox1.Text += "Computer Chose: " + game.SelectComputerChoice() + "\n";
            richTextBox1.Text += game.CheckForVictory();
            string json = JsonConvert.SerializeObject(game.VictoryConditions);
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "json.txt");
            System.IO.File.WriteAllText(path, json);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "Player Chose: " + game.SelectPlayerChoice("scissors") + "\n";
            richTextBox1.Text += "Computer Chose: " + game.SelectComputerChoice() + "\n";
            richTextBox1.Text += game.CheckForVictory();
            string json = JsonConvert.SerializeObject(game.VictoryConditions);
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "json.txt");
            System.IO.File.WriteAllText(path, json);
        }
    }
}
