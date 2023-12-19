using System;
using System.Drawing;
using System.Windows.Forms;

namespace GamingSocialMediaApp
{
    public partial class ProfileForm : Form
    {
        private PictureBox profilePictureBox;
        private Label usernameLabel;
        private Button editUsernameButton;
        private TextBox statusTextBox;
        private ComboBox clearStatusComboBox;
        private Button changeBackgroundColorButton;

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void EditUsernameButton_Click(object sender, EventArgs e)
        {
            // Implement the logic to edit the username
            // You can open a new form for username editing or handle it in-place
            MessageBox.Show("Edit Username Clicked");
        }

        private void ChangeBackgroundColorButton_Click(object sender, EventArgs e)
        {
            // Implement the logic to change the background color
            // You can use ColorDialog to let the user choose a color
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void clearStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
