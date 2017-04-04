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
    public partial class AddLocationFrm : Form
    {
        LocationListFrm LocFrm;

        public AddLocationFrm(LocationListFrm locFrm)
        {
            InitializeComponent();
            this.LocFrm = locFrm;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.LocFrm.UpdateLocationList();
            this.Close();
        }

        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.validateLocationName())
            {
                var location = new Domain.Location
                {
                    Name = this.txtBoxLocation.Text
                };

                // save it to the database
                Start.Sess.Save(location);
                Start.Sess.Flush();
                this.LocFrm.UpdateLocationList();
                this.Close();
            }
            else
            {
                
            }
        }

        private void txtBoxLocation_Validating(object sender, CancelEventArgs e)
        {
            validateLocationName();
        }

        private Boolean validateLocationName()
        {
            if (string.IsNullOrWhiteSpace(this.txtBoxLocation.Text))
            {
                this.errorProvider1.SetError(this.txtBoxLocation, "Du musst einen Lager Namen vergeben.");
                return false;
            }
            else
            {
                this.errorProvider1.SetError(this.txtBoxLocation, "");
                return true;
            }
        }
    }
}
