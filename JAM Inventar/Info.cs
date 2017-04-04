using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAM_Inventar
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            this.lblVersion.Text = Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("License.html");
            }
            catch (Exception)
            {
                MessageBox.Show("License could not be detected.");
            }
        }
    }
}
