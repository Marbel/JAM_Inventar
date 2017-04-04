namespace JAM_Inventar
{
    partial class ProductModificationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModificationList));
            this.listViewModifications = new System.Windows.Forms.ListView();
            this.cTimestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cUse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCommentar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewModifications
            // 
            resources.ApplyResources(this.listViewModifications, "listViewModifications");
            this.listViewModifications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cTimestamp,
            this.cAmount,
            this.cUser,
            this.cUse,
            this.cCommentar});
            this.listViewModifications.FullRowSelect = true;
            this.listViewModifications.GridLines = true;
            this.listViewModifications.MultiSelect = false;
            this.listViewModifications.Name = "listViewModifications";
            this.listViewModifications.UseCompatibleStateImageBehavior = false;
            this.listViewModifications.View = System.Windows.Forms.View.Details;
            this.listViewModifications.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewModifications_MouseClick);
            // 
            // cTimestamp
            // 
            resources.ApplyResources(this.cTimestamp, "cTimestamp");
            // 
            // cAmount
            // 
            resources.ApplyResources(this.cAmount, "cAmount");
            // 
            // cUser
            // 
            resources.ApplyResources(this.cUser, "cUser");
            // 
            // cUse
            // 
            resources.ApplyResources(this.cUse, "cUse");
            // 
            // cCommentar
            // 
            resources.ApplyResources(this.cCommentar, "cCommentar");
            // 
            // lblProduct
            // 
            resources.ApplyResources(this.lblProduct, "lblProduct");
            this.lblProduct.Name = "lblProduct";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ProductModificationList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.listViewModifications);
            this.Name = "ProductModificationList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductModificationList_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewModifications;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader cTimestamp;
        private System.Windows.Forms.ColumnHeader cAmount;
        private System.Windows.Forms.ColumnHeader cUser;
        private System.Windows.Forms.ColumnHeader cUse;
        private System.Windows.Forms.ColumnHeader cCommentar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}