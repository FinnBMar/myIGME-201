namespace GamingSocialMediaApp
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.editUsernameButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.clearStatusComboBox = new System.Windows.Forms.ComboBox();
            this.changeBackgroundColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Orange;
            this.profilePictureBox.Location = new System.Drawing.Point(20, 20);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(130, 20);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 23);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "YourUsername";
            // 
            // editUsernameButton
            // 
            this.editUsernameButton.Location = new System.Drawing.Point(130, 50);
            this.editUsernameButton.Name = "editUsernameButton";
            this.editUsernameButton.Size = new System.Drawing.Size(75, 23);
            this.editUsernameButton.TabIndex = 2;
            this.editUsernameButton.Text = "Edit Username";
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.Color.White;
            this.statusTextBox.Location = new System.Drawing.Point(20, 130);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(300, 80);
            this.statusTextBox.TabIndex = 3;
            // 
            // clearStatusComboBox
            // 
            this.clearStatusComboBox.Items.AddRange(new object[] {
            "1 hour",
            "1 day",
            "Don\'t clear"});
            this.clearStatusComboBox.Location = new System.Drawing.Point(20, 220);
            this.clearStatusComboBox.Name = "clearStatusComboBox";
            this.clearStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.clearStatusComboBox.TabIndex = 4;
            // 
            // changeBackgroundColorButton
            // 
            this.changeBackgroundColorButton.Location = new System.Drawing.Point(130, 220);
            this.changeBackgroundColorButton.Name = "changeBackgroundColorButton";
            this.changeBackgroundColorButton.Size = new System.Drawing.Size(75, 23);
            this.changeBackgroundColorButton.TabIndex = 5;
            this.changeBackgroundColorButton.Text = "Change Background Color";
            // 
            // ProfileForm
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.editUsernameButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.clearStatusComboBox);
            this.Controls.Add(this.changeBackgroundColorButton);
            this.Name = "ProfileForm";
            this.Text = "Profile Page";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

