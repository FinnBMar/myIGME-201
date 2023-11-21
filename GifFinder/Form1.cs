using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifFinder
{
    public partial class GifFinder : Form
    {

        SearchForm searchForm;

        public GifFinder()
        {
            InitializeComponent();

            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            searchForm = new SearchForm();

            timer2.Interval = 100;
            timer2.Tick += new EventHandler(Timer1__Tick);

            webBrowser2.ScriptErrorsSuppressed = true;
            webBrowser2.Navigate("https://people.rit.edu/dxsigm/gif-finder.html");

            this.tileToolStripMenuItem.Click += new EventHandler(TileToolStripMenuItem__Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(CascadeToolStripMenuItem__Click);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem__Click);
            this.newSearchToolStripMenuItem.Click += new EventHandler(NewSearchToolStripMenuItem__Click);


        }

        private void TileToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CascadeToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void ExitToolStripMenuItem__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewSearchToolStripMenuItem__Click(object sender, EventArgs e)
        {
            this.searchForm.ShowDialog();

            if(searchForm.response == "OK")
            {
                HtmlElement htmlElement;

                htmlElement = webBrowser2.Document.GetElementById("searchterm");
                htmlElement.SetAttribute("value", searchForm.searchTerm);

                htmlElement = webBrowser2.Document.GetElementById("limit");
                htmlElement.SetAttribute("value", Convert.ToString(searchForm.maxItems));

                webBrowser2.Document.InvokeScript("searchButtonClicked");

                timer2.Start();
            }
        }

        private void Timer1__Tick(object sender, EventArgs e)
        {
            timer2.Stop();

            HtmlElement htmlElement = webBrowser2.Document.GetElementById("lastelement");

            if(htmlElement != null )
            {
                HtmlElementCollection htmlElementCollection;

                htmlElementCollection = webBrowser2.Document.GetElementsByTagName("img");
                foreach(HtmlElement htmlElement1 in htmlElementCollection)
                {
                    ImageForm imageForm = new ImageForm(this, htmlElement1.GetAttribute("src"), htmlElement1.GetAttribute("title"));
                    imageForm.Show();
                }

                htmlElement.OuterHtml = "";
            }
            else
            {
                timer2.Start();
            }

            
        }

        private void GIfFinder_Load(object sender, EventArgs e)
        {

        }
    }
}
