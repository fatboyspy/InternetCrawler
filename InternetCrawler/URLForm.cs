using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetCrawler
{
    public partial class URLForm : Form
    {
        String url;
        String state;
        String description;
        public URLForm(String url,String state, String description)
        {
            InitializeComponent();
            this.url = url;
            this.state = state;
            this.description = description;

            linkLabURL.Text = url;
            tbState.Text = state;
            tbDescription.Text = description;
        }

        private void linkLabURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }
    }
}
