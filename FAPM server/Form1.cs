using SevenZipExtractor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAPM_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Public/http server/Command/start.bat - Shortcut.lnk");    
                }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Public/http server/Command/stop.bat - Shortcut.lnk");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Public/http server/Command/restart.bat - Shortcut.lnk");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Public/http server/Command/reinstall.bat - Shortcut.lnk");     
                }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Public/http server/Apache24/htdocs");     
                }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1/phpinfo.php");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1/phpmyadmin/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (ArchiveFile archiveFile = new ArchiveFile("C:/Users/Public/http server/WP/wordpress.zip"))
            {
                archiveFile.Extract("C:/Users/Public/http server/Apache24/htdocs"); // extract all
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1/wordpress");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Directory.Delete("C:/Users/Public/http server/Apache24/htdocs/wordpress", true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = (label1.Text + " OK");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            about about = new about();
            about.ShowDialog();        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/asciiblues/FAPM-server/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Public/http server/Command/install.bat - Shortcut.lnk");
                }
    }
}
