using JAM_Inventar.Core;
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
    public partial class AddModificationFrm : Form
    {
        Start startFrm;

        Product product;

        public AddModificationFrm(Start startFrm,Product product)
        {
            InitializeComponent();
            this.startFrm = startFrm;
            this.product = product;
            this.lblProduct.Text = product.Name;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.validateAmount())
            {
                return;
            }
            Modification mod = new Modification
            {
                Amount = Convert.ToInt32(this.txtAmount.Text),
                Product = this.product,
                User = Helper.getActualUser(),
                Timestamp = DateTime.Now,
                Use = this.txtUse.Text,
                Comment = this.txtComment.Text
            };

            this.product.Modifications.Add(mod);

            // save it to the database
            Start.Sess.SaveOrUpdate(mod.Product);
            Start.Sess.Flush();
            this.Close();
            this.startFrm.UpdateProductList();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateAmount()
        {
            if (Helper.IsDigitsOnly(this.txtAmount.Text))
            {
                this.errorProvider1.SetError(this.txtAmount, "Du musst eine gültige Zahl eingeben.");
                return true;
            }
            else
            {
                this.errorProvider1.SetError(this.txtAmount, "");
                return false;
            }

            
        }

        private void AddModificationFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.startFrm.UpdateProductList();
        }
    }
}
