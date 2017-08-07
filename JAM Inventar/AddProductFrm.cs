using JAM_Inventar.Core;
using JAM_Inventar.Domain;
using NHibernate;
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
    public partial class AddProductFrm : Form
    {
        Start startFrm;

        public AddProductFrm(Start startFrm)
        {
            InitializeComponent();
            this.startFrm = startFrm;
            this.LoadLocations();
        }

        public void LoadLocations()
        {
            IQuery q = Start.Sess.CreateQuery("from Location");

            var list = q.List<Domain.Location>();

            this.cmBoxLocations.DataSource = list;
            this.cmBoxLocations.DisplayMember = "Name";
            this.cmBoxLocations.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateName()
        {
            if (string.IsNullOrWhiteSpace(this.txtBoxName.Text))
            {
                this.errorProvider1.SetError(this.txtBoxName, "Bitte einen Namen eingeben.");
                return false;
            }
            else
            {
                this.errorProvider1.SetError(this.txtBoxName, "");
                return true;
            }
        }

        private bool validateAmount()
        {
            if (!Helper.IsDigitsOnly(this.txtBoxStartAmount.Text) || String.IsNullOrWhiteSpace(this.txtBoxStartAmount.Text))
            {
                this.errorProvider2.SetError(this.txtBoxStartAmount, "Bitte nur Zahlen eintragen.");
                return false;
            }
            else
            {
                this.errorProvider2.SetError(this.txtBoxStartAmount, "");
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!validateAmount())
            {
                error = true;
            }
            if (!validateName())
            {
                error = true;
            }
            if (error)
            {
                return;
            }
            Location loc = Start.Sess.Get<Location>(this.cmBoxLocations.SelectedValue);

            Product prod = new Product
            {
                Location = loc,
                Name = this.txtBoxName.Text,
                StartAmount = Convert.ToInt32(this.txtBoxStartAmount.Text),
                Unit = this.txtBoxUnit.Text,
                Modifications = new List<Modification>()
            };

            Start.Sess.Save(prod);
            Start.Sess.Flush();
            this.startFrm.UpdateProductList();
            this.Close();
        }
    }
}
