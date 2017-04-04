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
    public partial class EditProductFrm : Form
    {
        Start startFrm;

        Product prod;

        public EditProductFrm(Start startFrm,Product prod)
        {
            InitializeComponent();
            this.startFrm = startFrm;
            this.prod = prod;
            this.lblProduct.Text += prod.Name;
            this.txtBoxName.Text = prod.Name;
            this.txtBoxStartAmount.Text = prod.StartAmount.ToString();
            this.txtBoxUnit.Text = prod.Unit;

            IQuery q = Start.Sess.CreateQuery("from Location");

            var list = q.List<Domain.Location>();

            this.cmBoxLocations.DataSource = list;
            this.cmBoxLocations.DisplayMember = "Name";
            this.cmBoxLocations.ValueMember = "Id";


            this.cmBoxLocations.SelectedIndex = this.cmBoxLocations.FindStringExact(prod.Location.Name);
        }

        private void EditProductFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            startFrm.UpdateProductList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            if (!validateName())
            {
                error = true;
            }
            if (!validateAmount())
            {
                error = true;
            }
            if (!validateUnit())
            {
                error = true;
            }
            if (error)
            {
                return;
            }
            prod.Name = this.txtBoxName.Text;
            prod.StartAmount = Convert.ToInt32(this.txtBoxStartAmount.Text);
            prod.Unit = this.txtBoxUnit.Text;

            Location loc = Start.Sess.Get<Location>(this.cmBoxLocations.SelectedValue);
            prod.Location = loc;

            Start.Sess.SaveOrUpdate(prod);
            Start.Sess.Flush();
            this.startFrm.UpdateProductList();
            this.Close();

        }

        private void txtBoxName_Validating(object sender, CancelEventArgs e)
        {
            validateName();
        }

        private void txtBoxStartAmount_Validating(object sender, CancelEventArgs e)
        {
            validateAmount();
        }

        private void txtBoxUnit_Validating(object sender, CancelEventArgs e)
        {
            validateUnit();
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
                this.errorProvider1.SetError(this.txtBoxStartAmount, "Bitte nur Zahlen eintragen.");
                return false;
            }
            else
            {
                this.errorProvider1.SetError(this.txtBoxStartAmount, "");
                return true;
            }
        }

        private Boolean validateUnit()
        {
            if (string.IsNullOrWhiteSpace(this.txtBoxUnit.Text))
            {
                this.errorProvider1.SetError(this.txtBoxUnit, "Error");
                return false;
            }
            else
            {
                this.errorProvider1.SetError(this.txtBoxUnit, "");
                return true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
