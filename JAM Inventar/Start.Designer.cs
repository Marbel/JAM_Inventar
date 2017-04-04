namespace JAM_Inventar
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.lblInventar = new System.Windows.Forms.Label();
            this.txt_SearchName = new System.Windows.Forms.TextBox();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.CName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvailAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInventar
            // 
            resources.ApplyResources(this.lblInventar, "lblInventar");
            this.lblInventar.Name = "lblInventar";
            // 
            // txt_SearchName
            // 
            resources.ApplyResources(this.txt_SearchName, "txt_SearchName");
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.TextChanged += new System.EventHandler(this.txt_SearchName_TextChanged);
            // 
            // listViewProducts
            // 
            resources.ApplyResources(this.listViewProducts, "listViewProducts");
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CName,
            this.AvailAmount,
            this.CUnit,
            this.CLocation});
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            this.listViewProducts.DoubleClick += new System.EventHandler(this.listViewProducts_DoubleClick);
            this.listViewProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewProducts_MouseClick);
            // 
            // CName
            // 
            resources.ApplyResources(this.CName, "CName");
            // 
            // AvailAmount
            // 
            resources.ApplyResources(this.AvailAmount, "AvailAmount");
            // 
            // CLocation
            // 
            resources.ApplyResources(this.CLocation, "CLocation");
            // 
            // CUnit
            // 
            resources.ApplyResources(this.CUnit, "CUnit");
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addActionToolStripMenuItem,
            this.showActionsToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.editProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // addActionToolStripMenuItem
            // 
            resources.ApplyResources(this.addActionToolStripMenuItem, "addActionToolStripMenuItem");
            this.addActionToolStripMenuItem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addActionToolStripMenuItem.Name = "addActionToolStripMenuItem";
            this.addActionToolStripMenuItem.Click += new System.EventHandler(this.addActionToolStripMenuItem_Click);
            // 
            // showActionsToolStripMenuItem
            // 
            resources.ApplyResources(this.showActionsToolStripMenuItem, "showActionsToolStripMenuItem");
            this.showActionsToolStripMenuItem.Name = "showActionsToolStripMenuItem";
            this.showActionsToolStripMenuItem.Click += new System.EventHandler(this.showActionsToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteProductToolStripMenuItem, "deleteProductToolStripMenuItem");
            this.deleteProductToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // editProductToolStripMenuItem
            // 
            resources.ApplyResources(this.editProductToolStripMenuItem, "editProductToolStripMenuItem");
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            resources.ApplyResources(this.dateiToolStripMenuItem, "dateiToolStripMenuItem");
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editLocationsToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            // 
            // editLocationsToolStripMenuItem
            // 
            resources.ApplyResources(this.editLocationsToolStripMenuItem, "editLocationsToolStripMenuItem");
            this.editLocationsToolStripMenuItem.Name = "editLocationsToolStripMenuItem";
            this.editLocationsToolStripMenuItem.Click += new System.EventHandler(this.editLocationsToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            resources.ApplyResources(this.beendenToolStripMenuItem, "beendenToolStripMenuItem");
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // btnAddProduct
            // 
            resources.ApplyResources(this.btnAddProduct, "btnAddProduct");
            this.btnAddProduct.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Start
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.txt_SearchName);
            this.Controls.Add(this.lblInventar);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventar;
        private System.Windows.Forms.TextBox txt_SearchName;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editLocationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ColumnHeader CName;
        private System.Windows.Forms.ColumnHeader AvailAmount;
        private System.Windows.Forms.ColumnHeader CLocation;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader CUnit;
    }
}

