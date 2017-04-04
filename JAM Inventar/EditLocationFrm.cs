using JAM_Inventar.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAM_Inventar
{
    public partial class EditLocationFrm : Form
    {

        LocationListFrm locListFrm;
        Location loc;

        public EditLocationFrm(LocationListFrm locListFrm,Location loc)
        {
            InitializeComponent();
            this.locListFrm = locListFrm;
            this.loc = loc;
            this.txtBoxLocation.Text = this.loc.Name;
            this.lblLocation.Text += this.loc.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validateName())
            {
                return;
            }

            loc.Name = this.txtBoxLocation.Text;

            Start.Sess.SaveOrUpdate(loc);
            Start.Sess.Flush();
            this.locListFrm.UpdateLocationList();
            this.Close();
        }

        private bool validateName()
        {
            if (string.IsNullOrWhiteSpace(this.txtBoxLocation.Text))
            {
                this.errorProvider1.SetError(this.txtBoxLocation, "Bitte einen Namen eingeben.");
                return false;
            }
            else
            {
                this.errorProvider1.SetError(this.txtBoxLocation, "");
                return true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
