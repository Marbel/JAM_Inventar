namespace JAM_Inventar
{
    partial class LocationListFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationListFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewLocation = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listViewLocation
            // 
            this.listViewLocation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName});
            this.listViewLocation.FullRowSelect = true;
            this.listViewLocation.GridLines = true;
            resources.ApplyResources(this.listViewLocation, "listViewLocation");
            this.listViewLocation.MultiSelect = false;
            this.listViewLocation.Name = "listViewLocation";
            this.listViewLocation.UseCompatibleStateImageBehavior = false;
            this.listViewLocation.View = System.Windows.Forms.View.Details;
            this.listViewLocation.Click += new System.EventHandler(this.listViewLocation_Click);
            this.listViewLocation.DoubleClick += new System.EventHandler(this.listViewLocation_DoubleClick);
            this.listViewLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewLocation_MouseClick);
            // 
            // cName
            // 
            resources.ApplyResources(this.cName, "cName");
            // 
            // btnAddLocation
            // 
            resources.ApplyResources(this.btnAddLocation, "btnAddLocation");
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // LocationListFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.listViewLocation);
            this.Controls.Add(this.label1);
            this.Name = "LocationListFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocationListFrm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LocationListFrm_FormClosed);
            this.Load += new System.EventHandler(this.LocationListFrm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewLocation;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}