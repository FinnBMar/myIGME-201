using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileProjectv2
{
    public partial class Form1 : Form
    {
        private PictureBox profilePictureBox;
        private Label usernameLabel;
        private Button editUsernameButton;
        private TextBox statusTextBox;
        private ComboBox clearStatusComboBox;
        private Button changeBackgroundColorButton;
        private PictureBox teamLogoPictureBox;
        private Label teamNameLabel;
        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            // Profile Picture Box
            profilePictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(20, 20),
                BackColor = Color.DarkBlue,
                Image = Properties.Resources.DefaultProfileImage, // Add a default profile image to your resources
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
            };
            Controls.Add(profilePictureBox);

            // Username Label
            usernameLabel = new Label
            {
                AutoSize = true,
                Location = new Point(profilePictureBox.Right + 10, profilePictureBox.Top),
                Text = "YourUsername",
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold)
            };
            Controls.Add(usernameLabel);

            // Edit Username Button
            editUsernameButton = new Button
            {
                Location = new Point(usernameLabel.Right + 10, usernameLabel.Top),
                Text = "Edit Username"
            };
            Controls.Add(editUsernameButton);

            // Status TextBox
            statusTextBox = new TextBox
            {
                Multiline = true,
                Size = new Size(300, 80),
                Location = new Point(20, profilePictureBox.Bottom + 20)
            };
            Controls.Add(statusTextBox);

            // Clear Status ComboBox
            clearStatusComboBox = new ComboBox
            {
                Items = { "1 hour", "1 day", "Don't clear" },
                Location = new Point(statusTextBox.Right + 10, statusTextBox.Top)
            };
            Controls.Add(clearStatusComboBox);

            // Change Background Color Button
            changeBackgroundColorButton = new Button
            {
                Location = new Point(20, statusTextBox.Bottom + 20),
                Text = "Change Background Color"
            };
            Controls.Add(changeBackgroundColorButton);

            // Team Logo PictureBox
            teamLogoPictureBox = new PictureBox
            {
                Size = new Size(80, 80),
                Location = new Point(20, changeBackgroundColorButton.Bottom + 20),
                BackColor = Color.DarkBlue,
                Image = Properties.Resources.DefaultTeamLogo, // Add a default team logo to your resources
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(teamLogoPictureBox);

            // Team Name Label
            teamNameLabel = new Label
            {
                AutoSize = true,
                Location = new Point(teamLogoPictureBox.Right + 10, teamLogoPictureBox.Top),
                Text = "No Team",
                Font = new Font(Font.FontFamily, 12, FontStyle.Bold)
            };
            Controls.Add(teamNameLabel);

        }
    }
}
