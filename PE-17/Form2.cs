using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17_MultipleForms
{
    public partial class GameForm : Form
    {

        Random rand = new Random();
        int nRandom;
        int nGuesses;
        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            this.timer.Start();
            this.timer.Tick += new EventHandler(Timer__Tick);

            

            this.guessButton.Click += new EventHandler(GuessButton__Click);
            this.currentGuessTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);

            this.progressBar.Value = 90;

            this.nRandom = rand.Next(lowNumber, highNumber + 1);
            this.nGuesses = 0;

        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.progressBar.Value;

            if (this.progressBar.Value == 0)
            {
                this.timer.Stop();
                MessageBox.Show("Out of time! The answer was " + this.nRandom);
            }
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            this.nGuesses++;

            if(Int32.Parse(this.currentGuessTextBox.Text) > this.nRandom)
            {
                this.outputLabel.Text = this.currentGuessTextBox.Text + " is too high";
            }
            else if(Int32.Parse(this.currentGuessTextBox.Text) < this.nRandom)
            {
                this.outputLabel.Text = this.currentGuessTextBox.Text + " is too low";
            }
            else
            {
                this.timer.Stop();
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                this.Close();

            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//suppresses key presses that are not digits

            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
