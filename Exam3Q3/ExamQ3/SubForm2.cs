using System;
using System.Windows.Forms;

namespace FrustratingUI
{
    public partial class SubForm2 : Form
    {
        private Label lblSubForm;

        public SubForm2()
        {
            InitializeComponent();
        }

        // Additional methods or properties can go here

        public void UpdateLabelText(string newText)
        {
            lblSubForm.Text = newText;
        }
    }
}
