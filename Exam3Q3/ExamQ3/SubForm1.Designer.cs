namespace FrustratingUI
{
    partial class SubForm1
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
            this.lblSubForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubForm
            // 
            this.lblSubForm.Location = new System.Drawing.Point(50, 50);
            this.lblSubForm.Name = "lblSubForm";
            this.lblSubForm.Size = new System.Drawing.Size(200, 50);
            this.lblSubForm.TabIndex = 0;
            // 
            // SubForm1
            // 
            this.ClientSize = new System.Drawing.Size(404, 288);
            this.Controls.Add(this.lblSubForm);
            this.Name = "SubForm1";
            this.Text = "SubForm1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}