namespace JAM_Inventar
{
    partial class EditLocationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLocationFrm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxLocation
            // 
            resources.ApplyResources(this.txtBoxLocation, "txtBoxLocation");
            this.errorProvider1.SetError(this.txtBoxLocation, resources.GetString("txtBoxLocation.Error"));
            this.errorProvider1.SetIconAlignment(this.txtBoxLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxLocation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtBoxLocation, ((int)(resources.GetObject("txtBoxLocation.IconPadding"))));
            this.txtBoxLocation.Name = "txtBoxLocation";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.errorProvider1.SetError(this.lblLocation, resources.GetString("lblLocation.Error"));
            this.errorProvider1.SetIconAlignment(this.lblLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLocation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblLocation, ((int)(resources.GetObject("lblLocation.IconPadding"))));
            this.lblLocation.Name = "lblLocation";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // EditLocationFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.lblLocation);
            this.Name = "EditLocationFrm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}