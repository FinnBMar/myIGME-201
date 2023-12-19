using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.LinkLabel;

namespace PresidentsApp // Finn Marable Presidents App Recreation of the given exe for Unit Exam 3 Question 2
{
    public partial class Presidents : Form
    {
        public Presidents()
        {
            InitializeComponent();

            this.allRadioButton.Checked = true;
            this.exitButton.Enabled = false;

            this.radioButton1.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton2.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton3.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton4.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton5.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton6.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton7.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton8.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton9.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton10.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton11.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton12.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton13.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton14.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton15.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);
            this.radioButton16.CheckedChanged += new EventHandler(RadioButton__CheckedChanged);

            this.pictureBox1.MouseHover += new EventHandler(PictureBox1__MouseOver);
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox1__MouseLeave);

            this.exitButton.Click += new EventHandler(ExitButton__Click);

            this.allRadioButton.CheckedChanged += new EventHandler(FilterRadio__CheckChanged);
            this.demRadioButton.CheckedChanged += new EventHandler(FilterRadio__CheckChanged);
            this.repRadioButton.CheckedChanged += new EventHandler(FilterRadio__CheckChanged);
            this.demRepRadioButton.CheckedChanged += new EventHandler(FilterRadio__CheckChanged);
            this.fedRadioButton.CheckedChanged += new EventHandler(FilterRadio__CheckChanged);

            this.textBox1.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox2.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox3.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox4.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox5.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox6.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox7.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox8.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox9.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox10.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox11.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox12.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox13.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox14.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox15.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            this.textBox16.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);

            this.textBox1.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox2.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox3.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox4.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox5.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox6.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox7.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox8.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox9.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox10.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox11.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox12.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox13.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox14.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox15.TextChanged += new EventHandler(TextBox__TextChanged);
            this.textBox16.TextChanged += new EventHandler(TextBox__TextChanged);

            this.textBox1.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox2.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox3.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox4.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox5.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox6.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox7.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox8.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox9.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox10.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox11.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox12.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox13.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox14.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox15.MouseHover += new EventHandler(TextBox__MouseHover);
            this.textBox16.MouseHover += new EventHandler(TextBox__MouseHover);

            this.timer1.Tick += new EventHandler(Timer__Tick);

            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser__DocumentCompleted);



        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            --this.progressBar1.Value;

            if (this.progressBar1.Value == 0)
            {
                this.progressBar1.Value = 600;

                this.textBox1.Text = "0";
                this.textBox2.Text = "0";
                this.textBox3.Text = "0";
                this.textBox4.Text = "0";
                this.textBox5.Text = "0";
                this.textBox6.Text = "0";
                this.textBox7.Text = "0";
                this.textBox8.Text = "0";
                this.textBox9.Text = "0";
                this.textBox10.Text = "0";
                this.textBox11.Text = "0";
                this.textBox12.Text = "0";
                this.textBox13.Text = "0";
                this.textBox14.Text = "0";
                this.textBox15.Text = "0";
                this.textBox16.Text = "0";

            }
        }

        private void RadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton currentRadioButton = sender as RadioButton;

            if((currentRadioButton != null) && (currentRadioButton.Checked))
            {
                string link = "https://en.m.wikipedia.org/wiki/";
                string name = currentRadioButton.Text.Replace(" ", "_");
                link += name;
                this.webBrowser1.Url = new System.Uri(link);

                string imageName = currentRadioButton.Text.Replace(" ", "");

                try
                {
                    string imageLocation = $"Presidents_exe/{imageName}.jpeg";

                    if(imageName == "BarackObama")
                    {
                         imageLocation = $"Presidents_exe/{imageName}.png";
                    }

                    this.pictureBox1.Image = System.Drawing.Image.FromFile(imageLocation);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show($"Error loading image: hi");
                }

            }
        }

        private void WebBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection pageLinks = webBrowser1.Document.GetElementsByTagName("a");

            foreach(HtmlElement pageLink in pageLinks)
            {
                pageLink.SetAttribute("title", "Reva Sathe for President");
            }
        }

        private void PictureBox1__MouseOver(object sender, EventArgs e)
        {
            this.pictureBox1.BringToFront();
            this.pictureBox1.Width = 210;
            this.pictureBox1.Height = 282;

        }
        private void PictureBox1__MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Width = 168;
            this.pictureBox1 .Height = 226;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FilterRadio__CheckChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (allRadioButton.Checked)
            {
                this.radioButton1.Show();
                this.radioButton2.Show();
                this.radioButton3.Show();
                this.radioButton4.Show();
                this.radioButton5.Show();
                this.radioButton6.Show();
                this.radioButton7.Show();
                this.radioButton8.Show();
                this.radioButton9.Show();
                this.radioButton10.Show();
                this.radioButton11.Show();
                this.radioButton12.Show();
                this.radioButton13.Show();
                this.radioButton14.Show();
                this.radioButton15.Show();
                this.radioButton16.Show();
            }
            else if (demRadioButton.Checked)
            {
                this.radioButton1.Hide();
                this.radioButton2.Show();

                this.radioButton2.Checked = true;

                this.radioButton3.Show();
                this.radioButton4.Show();
                this.radioButton5.Show();
                this.radioButton6.Hide();
                this.radioButton7.Show();
                this.radioButton8.Show();
                this.radioButton9.Hide();
                this.radioButton10.Hide();
                this.radioButton11.Hide();
                this.radioButton12.Hide();
                this.radioButton13.Show();
                this.radioButton14.Hide();
                this.radioButton15.Hide();
                this.radioButton16.Hide();
            }
            else if (repRadioButton.Checked)
            {
                this.radioButton1.Show();
                this.radioButton1.Checked = true;
                this.radioButton2.Hide();
                this.radioButton3.Hide();
                this.radioButton4.Hide();
                this.radioButton5.Hide();
                this.radioButton6.Hide();
                this.radioButton7.Show();
                this.radioButton8.Hide();
                this.radioButton9.Hide();
                this.radioButton10.Show();
                this.radioButton11.Hide();
                this.radioButton12.Hide();
                this.radioButton13.Hide();
                this.radioButton14.Show();
                this.radioButton15.Show();
                this.radioButton16.Show();
            }
            else if (demRepRadioButton.Checked)
            {
                this.radioButton1.Hide();
                this.radioButton2.Hide();
                this.radioButton3.Hide();
                this.radioButton4.Hide();
                this.radioButton5.Hide();
                this.radioButton6.Hide();
                this.radioButton7.Hide();
                this.radioButton8.Hide();
                this.radioButton9.Show();
                this.radioButton9.Checked = true;
                this.radioButton10.Hide();
                this.radioButton11.Hide();
                this.radioButton12.Hide();
                this.radioButton13.Hide();
                this.radioButton14.Hide();
                this.radioButton15.Hide();
                this.radioButton16.Hide();
            }
            else //if the federalist button is checked
            {
                this.radioButton1.Hide();
                this.radioButton2.Hide();
                this.radioButton3.Hide();
                this.radioButton4.Hide();
                this.radioButton5.Hide();
                this.radioButton6.Hide();
                this.radioButton7.Hide();
                this.radioButton8.Hide();
                this.radioButton9.Hide();
                this.radioButton10.Hide();
                this.radioButton11.Show();
                this.radioButton12.Checked = true;
                this.radioButton12.Show();
                this.radioButton13.Hide();
                this.radioButton14.Hide();
                this.radioButton15.Hide();
                this.radioButton16.Hide();
            }
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textSelected = sender as TextBox;

            this.timer1.Start();

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)){
                e.Handled = true;
            }

            if (textSelected.Name == textBox1.Name)
            {
                if (textSelected.Text != "23")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }
            if (textSelected.Name == textBox2.Name)
            {
                if (textSelected.Text != "32")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox3.Name)
            {
                if (textSelected.Text != "42")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox4.Name)
            {
                if (textSelected.Text != "15")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox5.Name)
            {
                if (textSelected.Text != "14")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox6.Name)
            {
                if (textSelected.Text != "43")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox7.Name)
            {
                if (textSelected.Text != "44")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox8.Name)
            {
                if (textSelected.Text != "35")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox9.Name)
            {
                if (textSelected.Text != "3")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox10.Name)
            {
                if (textSelected.Text != "26")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox11.Name)
            {
                if (textSelected.Text != "2")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox12.Name)
            {
                if (textSelected.Text != "1")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox13.Name)
            {
                if (textSelected.Text != "8")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox14.Name)
            {
                if (textSelected.Text != "34")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox15.Name)
            {
                if (textSelected.Text != "40")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }

            if (textSelected.Name == textBox16.Name)
            {
                if (textSelected.Text != "25")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                }
            }
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {

            TextBox textSelected = sender as TextBox;


            if (textSelected.Name == textBox1.Name)
            {
                if (textSelected.Text != "23")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox1.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox2.Name)
            {
                if (textSelected.Text != "32")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox2.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox3.Name)
            {
                if (textSelected.Text != "42")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox3.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox4.Name)
            {
                if (textSelected.Text != "15")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox4.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox5.Name)
            {
                if (textSelected.Text != "14")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox5.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox6.Name)
            {
                if (textSelected.Text != "43")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox6.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox7.Name)
            {
                if (textSelected.Text != "44")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox7.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox8.Name)
            {
                if (textSelected.Text != "35")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox8.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox9.Name)
            {
                if (textSelected.Text != "3")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox9.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox10.Name)
            {
                if (textSelected.Text != "26")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox10.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox11.Name)
            {
                if (textSelected.Text != "2")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox11.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox12.Name)
            {
                if (textSelected.Text != "1")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox12.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox13.Name)
            {
                if (textSelected.Text != "8")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox13.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox14.Name)
            {
                if (textSelected.Text != "34")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox14.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox15.Name)
            {
                if (textSelected.Text != "40")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox15.ReadOnly = true;
                }
            }

            if (textSelected.Name == textBox16.Name)
            {
                if (textSelected.Text != "25")
                {
                    this.errorProvider1.SetError(textSelected, "That is the wrong number.");
                }
                else
                {
                    this.errorProvider1.SetError(textSelected, "");
                    this.textBox16.ReadOnly = true;
                }
            }

            if(this.textBox1.ReadOnly && this.textBox2.ReadOnly && this.textBox3.ReadOnly && this.textBox4.ReadOnly &&
                this.textBox5.ReadOnly && this.textBox6.ReadOnly && this.textBox7.ReadOnly && this.textBox8.ReadOnly &&
                this.textBox9.ReadOnly && this.textBox10.ReadOnly && this.textBox11.ReadOnly && this.textBox12.ReadOnly &&
                this.textBox13.ReadOnly && this.textBox14.ReadOnly && this.textBox15.ReadOnly && this.textBox16.ReadOnly)
            {
                this.timer1.Stop();


                this.webBrowser1.Url = new System.Uri("https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif");

                this.exitButton.Enabled = true;
                
            }


        }

        private void TextBox__MouseHover(object sender, EventArgs e)
        {
            TextBox textSelected = sender as TextBox;

            toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;

            toolTip1.SetToolTip(textSelected, "Which # President?");


        }

    }
}
