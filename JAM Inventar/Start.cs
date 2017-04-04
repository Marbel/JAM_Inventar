using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Diagnostics;
using JAM_Inventar.Domain;
using System.Globalization;
using System.Resources;
using Microsoft.Win32;
using System.Threading;

namespace JAM_Inventar
{
    public partial class Start : Form
    {

        
        public static Configuration Cfg
        {
            get; set;
        }

        public static ISession Sess
        {
            get; set;
        }

        public Start()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.UpdateProductList();
        }

        public void UpdateProductList()
        {
            this.listViewProducts.Items.Clear();
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
            IQuery q = Start.Sess.CreateQuery("from Product p where p.Name like :name").SetParameter("name","%"+this.txt_SearchName.Text+"%");

            var list = q.List<Domain.Product>();
            

            foreach (Product product in list)
            {
                int amountChanged = 0;
                if(product.Modifications != null)
                {
                    foreach (Modification mod in product.Modifications)
                    {
                        amountChanged += mod.Amount;
                    }
                }

                int amount = product.StartAmount + amountChanged;

                string[] arr = new String[4];
                arr[0] = product.Name;
                arr[1] = Convert.ToString(amount);
                arr[2] = product.Unit;
                arr[3] = product.Location.Name;
                ListViewItem listItem = new ListViewItem(arr);
                listItem.Tag = product.Id;
                this.listViewProducts.Items.Add(listItem);
            }

            this.listViewProducts.Sort();
        }

        

        private void listViewProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewProducts.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            this.UpdateProductList();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocationListFrm locationFrm = new LocationListFrm(this);
            locationFrm.ShowDialog(this);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductFrm addProdFrm = new AddProductFrm(this);
            addProdFrm.ShowDialog(this);
        }

        private void listViewProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Product prod = Sess.Get<Product>(this.listViewProducts.SelectedItems[0].Tag);
                AddModificationFrm addModFrm = new AddModificationFrm(this, prod);
                addModFrm.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an Error while loading the Product.");
            }
        }

        private void addActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = Sess.Get<Product>(this.listViewProducts.SelectedItems[0].Tag);
                AddModificationFrm addModFrm = new AddModificationFrm(this, prod);
                addModFrm.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an Error while loading the Product.");
            }
        }

        private void showActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = Sess.Get<Product>(this.listViewProducts.SelectedItems[0].Tag);

                ProductModificationList prodModFrm = new ProductModificationList(this,prod);
                prodModFrm.ShowDialog(this);
                
            }
            catch (Exception)
            {
                MessageBox.Show("There was an Error while loading the Product.");
            }

            
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prod = Start.Sess.Get<Product>(this.listViewProducts.SelectedItems[0].Tag);

            DialogResult result = MessageBox.Show("Möchtest du wirklich den Artikel [" + prod.Name + "] löschen?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            
            Start.Sess.Delete(prod);
            Start.Sess.Flush();
            this.UpdateProductList();
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = Sess.Get<Product>(this.listViewProducts.SelectedItems[0].Tag);

                EditProductFrm editProdFrm = new EditProductFrm(this, prod);
                editProdFrm.ShowDialog(this);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an Error while loading the Product.");
            }

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info infoFrm = new Info();
            infoFrm.ShowDialog(this);
        }
    }
}
