using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17_MultipleForms //Finn Marable Number Guesser PE-17
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            this.startButton.Click += new EventHandler(StartButton__Click);
            this.lowTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.highTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);

        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse


            lowNumber = Int32.Parse(this.lowTextBox.Text);
            highNumber = Int32.Parse((this.highTextBox.Text));

            // if not a valid range
            if (lowNumber >= highNumber)
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//suppresses key presses that are not digits

            }
        }

    }
}
