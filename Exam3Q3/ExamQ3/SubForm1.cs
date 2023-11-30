using System;
using System.Windows.Forms;

namespace FrustratingUI
{
    public partial class SubForm1 : Form
    {
        private Label lblSubForm;

        public SubForm1()
        {
            InitializeComponent();
        }

        public void UpdateLabelText(string newText)
        {
            lblSubForm.Text = newText;
        }
    }
}
