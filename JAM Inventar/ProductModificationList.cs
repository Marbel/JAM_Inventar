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
    public partial class ProductModificationList : Form
    {

        Start startFrm;
        Product prod;

        public ProductModificationList(Start startFrm,Product prod)
        {
            InitializeComponent();
            this.startFrm = startFrm;
            this.prod = prod;
            this.lblProduct.Text = prod.Name;
            this.UpdateModificationList();
        }

        public void UpdateModificationList()
        {
            this.listViewModifications.Items.Clear();
            // Create Columns

            // Create a Product...
            //var product = new Domain.Product
            //{
            //    Name = "Kaffee",
            //    StartAmount = 100
            //};

            //// And save it to the database
            //sess.Save(product);

            // Note that we do not use the table name specified
            // in the mapping, but the class name, which is a nice
            // abstraction that comes with NHibernate
            IQuery q = Start.Sess.CreateQuery("from Modification m where m.Product = :id").SetParameter("id", this.prod.Id);

            var list = q.List<Domain.Modification>();


            foreach (Modification mod in list)
            {
                string[] arr = new String[5];
                arr[0] = mod.Timestamp.ToString();
                arr[1] = Convert.ToString(mod.Amount);
                arr[2] = mod.User;
                arr[3] = mod.Use;
                arr[4] = mod.Comment;
                ListViewItem listItem = new ListViewItem(arr);
                listItem.Tag = mod.Id;
                this.listViewModifications.Items.Add(listItem);
            }

            this.listViewModifications.Sort();
        }

        private void ProductModificationList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startFrm.UpdateProductList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewModifications_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.listViewModifications.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Modification mod = Start.Sess.Get<Modification>(this.listViewModifications.SelectedItems[0].Tag);

                EditModificationFrm editModFrm = new EditModificationFrm(this, mod);
                editModFrm.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an Error while loading the Modification.");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modification mod = Start.Sess.Get<Modification>(this.listViewModifications.SelectedItems[0].Tag);

            DialogResult result = MessageBox.Show("Möchtest du wirklich die Anpassung löschen?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            this.prod.Modifications.Remove(mod);
            Start.Sess.Delete(mod);
            Start.Sess.SaveOrUpdate(this.prod);
            Start.Sess.Flush();
            this.UpdateModificationList();
        }
    }
}
