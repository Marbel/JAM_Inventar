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
    public partial class LocationListFrm : Form
    {
        Start startFrm;

        public LocationListFrm(Start startFrm)
        {
            InitializeComponent();
            this.startFrm = startFrm;
        }

        public void UpdateLocationList()
        {
            this.listViewLocation.Items.Clear();
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
            IQuery q = Start.Sess.CreateQuery("from Location");

            var list = q.List<Domain.Location>();


            foreach (Location loc in list)
            {
                ListViewItem listItem = new ListViewItem(loc.Name);
                listItem.Tag = loc.Id;
                this.listViewLocation.Items.Add(listItem);
            }

            this.listViewLocation.Sort();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            AddLocationFrm addLocFrm = new AddLocationFrm(this);
            addLocFrm.ShowDialog(this);
        }

        private void LocationListFrm_Load(object sender, EventArgs e)
        {
            this.UpdateLocationList();
        }

        private void listViewLocation_DoubleClick(object sender, EventArgs e)
        {
            Location loc = Start.Sess.Get<Location>(this.listViewLocation.SelectedItems[0].Tag);
            EditLocationFrm editLocFrm = new EditLocationFrm(this,loc);
            editLocFrm.ShowDialog(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Location loc = Start.Sess.Get<Location>(this.listViewLocation.SelectedItems[0].Tag);
            EditLocationFrm editLocFrm = new EditLocationFrm(this, loc);
            editLocFrm.ShowDialog(this);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Location loc = Start.Sess.Get<Location>(this.listViewLocation.SelectedItems[0].Tag);

            DialogResult result = MessageBox.Show("Möchtest du wirklich das Lager ["+loc.Name+"] löschen? (Alle Artikel im Lager werden gelöscht!)", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                return;
            }

            IList<Product> list = Start.Sess.QueryOver<Product>().Where(x => x.Location == loc).List();
            
            foreach (Product product in list)
            {
                Start.Sess.Delete(product);
            }
            Start.Sess.Delete(loc);
            Start.Sess.Flush();
            this.UpdateLocationList();
        }

        private void listViewLocation_Click(object sender, EventArgs e)
        {
            //not Used
        }

        private void listViewLocation_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewLocation.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void LocationListFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }

        private void LocationListFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.startFrm.UpdateProductList();
        }
    }
}
