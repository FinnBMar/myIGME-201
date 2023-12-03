using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FrustratingUI
{
    public partial class MainForm : Form
    {
        private Thread changeThread;
        private Random random = new Random();
        private System.Windows.Forms.Timer timer;  // Explicitly specify System.Windows.Forms.Timer

        // Controls
        private Button btnChangeText;
        private TextBox txtRandomText;
        private Label lblInfo;
        private ComboBox cboOptions;

        // Other forms
        private SubForm1 subForm1;
        private SubForm2 subForm2;

        public MainForm(System.Windows.Forms.Timer mainFormTimer)
        {
            InitializeComponent();
            InitializeControls();
            timer = mainFormTimer;  // Assign the provided timer
            InitializeThread();
            InitializeOtherForms();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(374, 229);
            this.Name = "MainForm";
            this.Text = "Frustrating UI";
            this.ResumeLayout(false);

        }

        private void InitializeControls()
        {
            // Button
            btnChangeText = new Button();
            btnChangeText.Text = "Submit Form";
            btnChangeText.Size = new Size(100, 30);
            btnChangeText.Location = new Point(20, 20);
            btnChangeText.Click += BtnChangeText_Click;
            this.Controls.Add(btnChangeText);

            // TextBox
            txtRandomText = new TextBox();
            txtRandomText.Size = new Size(300, 30);
            txtRandomText.Location = new Point(20, 70);
            this.Controls.Add(txtRandomText);

            // Label
            lblInfo = new Label();
            lblInfo.Text = "Select Option:";
            lblInfo.Size = new Size(150, 20);
            lblInfo.Location = new Point(20, 120);
            this.Controls.Add(lblInfo);

            // ComboBox
            cboOptions = new ComboBox();
            cboOptions.Items.AddRange(new string[] { "Yes", "No", "Maybe" });
            cboOptions.Size = new Size(150, 30);
            cboOptions.Location = new Point(20, 150);
            cboOptions.SelectedIndexChanged += CboOptions_SelectedIndexChanged;
            this.Controls.Add(cboOptions);

            // Timer
            timer = new System.Windows.Forms.Timer();  // Explicitly specify System.Windows.Forms.Timer
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeThread()
        {
            changeThread = new Thread(new ThreadStart(ChangeTextThread));
            changeThread.Start();
        }

        private void InitializeOtherForms()
        {
            subForm1 = new SubForm1();
            subForm2 = new SubForm2();
        }

        private void BtnChangeText_Click(object sender, EventArgs e)
        {
            txtRandomText.Text = "Button Clicked!";
        }

        private void CboOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "Selected: " + cboOptions.SelectedItem.ToString();
        }

        private void ChangeTextThread()
        {
            while (true)
            {
                Thread.Sleep(5000);
                txtRandomText.Text = "Form Submitted";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Simulate random changes on timer tick
                int randomNumber = random.Next(1, 6);

                switch (randomNumber)
                {
                    case 1:
                        this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                        break;
                    case 2:
                        txtRandomText.Text = "Current Time: " + DateTime.Now.ToString();
                        break;
                    case 3:
                        btnChangeText.Location = new Point(random.Next(0, this.Width - btnChangeText.Width), random.Next(0, this.Height - btnChangeText.Height));
                        break;
                    case 4:
                        int fontSize = random.Next(10, 30);
                        lblInfo.Font = new Font(lblInfo.Font.FontFamily, fontSize);
                        break;
                    case 5:
                        subForm1.UpdateLabelText("Updated from Main Form!");
                        subForm2.UpdateLabelText("Another Update from Main Form!");
                        break;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"An error occurred in MainForm.Timer_Tick: {ex.Message}");
            }
        }
    }
}

