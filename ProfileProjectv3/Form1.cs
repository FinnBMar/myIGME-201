using System;
using System.Windows.Forms;

namespace ProfileProjectv3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeProfilePage();
        }

        private void InitializeProfilePage()
        {
            // Label for "Profile" at the top left
            Label lblProfile = new Label
            {
                Text = "Profile",
                Location = new System.Drawing.Point(10, 10),
                Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.DarkBlue,
            };
            Controls.Add(lblProfile);

            // Profile photo in a circle
            PictureBox profilePhoto = new PictureBox
            {
                Size = new System.Drawing.Size(100, 100),
                Location = new System.Drawing.Point(20, 50),
                Image = Properties.Resources.DefaultProfilePhoto, // Set a default image or load from resources
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.White,
            };
            Controls.Add(profilePhoto);

            // Username with "Edit Username" button
            Label lblUsername = new Label
            {
                Text = "YourUsername",
                Location = new System.Drawing.Point(130, 50),
                Font = new System.Drawing.Font("Arial", 12),
            };
            Controls.Add(lblUsername);

            Button btnEditUsername = new Button
            {
                Text = "Edit Username",
                Location = new System.Drawing.Point(130, 80),
                Size = new System.Drawing.Size(120, 30),
            };
            Controls.Add(btnEditUsername);

            // Status box with dropdown
            TextBox txtStatus = new TextBox
            {
                Multiline = true,
                Size = new System.Drawing.Size(200, 60),
                Location = new System.Drawing.Point(20, 170),
            };
            Controls.Add(txtStatus);

            Label lblClearStatus = new Label
            {
                Text = "Clear Status after:",
                Location = new System.Drawing.Point(230, 170),
                Font = new System.Drawing.Font("Arial", 10),
            };
            Controls.Add(lblClearStatus);

            ComboBox cmbClearStatus = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Items = { "1 hour", "1 day", "Don't clear" },
                Location = new System.Drawing.Point(230, 190),
            };
            Controls.Add(cmbClearStatus);

            // Button to change background color
            Button btnChangeColor = new Button
            {
                Text = "Change Background Color",
                Location = new System.Drawing.Point(20, 250),
            };
            Controls.Add(btnChangeColor);

            // Team logo and name
            PictureBox teamLogo = new PictureBox
            {
                Size = new System.Drawing.Size(100, 100),
                Location = new System.Drawing.Point(20, 300),
                Image = Properties.Resources.DefaultTeamLogo, // Set a default image or load from resources
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.White,
            };
            Controls.Add(teamLogo);

            Label lblTeamName = new Label
            {
                Text = "No Team",
                Location = new System.Drawing.Point(130, 300),
                Font = new System.Drawing.Font("Arial", 12),
            };
            Controls.Add(lblTeamName);
        }
    }
}
