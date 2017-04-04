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
    public partial class EditModificationFrm : Form
    {

        ProductModificationList modFrm;
        Modification mod;

        public EditModificationFrm(ProductModificationList modFrm,Modification mod)
        {
            InitializeComponent();
            this.modFrm = modFrm;
            this.mod = mod;

            this.lblProduct.Text = mod.Product.Name;
            this.txtAmount.Text = mod.Amount.ToString();
            this.txtComment.Text = mod.Comment;
            this.txtUse.Text = mod.Use;
            this.lblOldModUser.Text = mod.User;
            this.lblNewModUser.Text = Core.Helper.getActualUser();
            this.lblModTime.Text = mod.Timestamp.ToString("dd.MM.yyyy H:mm:ss");
        }

        private void EditModificationFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Update Mod List
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Boolean error = false;
            if (!validateAmount())
            {
                error = true;
            }
            if (error)
            {
                return;
            }
            this.mod.Amount = Convert.ToInt32(this.txtAmount.Text);
            this.mod.Timestamp = DateTime.Now;
            this.mod.User = Helper.getActualUser();
            this.mod.Comment = this.txtComment.Text;
            this.mod.Use = this.txtUse.Text;
            
            Start.Sess.Update(this.mod);
            Start.Sess.Flush();
            this.Close();
            this.modFrm.UpdateModificationList();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditModificationFrm_FormClosed(object sender, FormClosedEventArgs e)
        {

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
    }
}
