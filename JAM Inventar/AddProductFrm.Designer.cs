namespace JAM_Inventar
{
    partial class AddProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductFrm));
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartAmount = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmBoxLocations = new System.Windows.Forms.ComboBox();
            this.txtBoxUnit = new System.Windows.Forms.TextBox();
            this.txtBoxStartAmount = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewProduct
            // 
            resources.ApplyResources(this.lblNewProduct, "lblNewProduct");
            this.errorProvider1.SetError(this.lblNewProduct, resources.GetString("lblNewProduct.Error"));
            this.errorProvider2.SetError(this.lblNewProduct, resources.GetString("lblNewProduct.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblNewProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNewProduct.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblNewProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNewProduct.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblNewProduct, ((int)(resources.GetObject("lblNewProduct.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblNewProduct, ((int)(resources.GetObject("lblNewProduct.IconPadding1"))));
            this.lblNewProduct.Name = "lblNewProduct";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.errorProvider1.SetError(this.lblName, resources.GetString("lblName.Error"));
            this.errorProvider2.SetError(this.lblName, resources.GetString("lblName.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding1"))));
            this.lblName.Name = "lblName";
            // 
            // lblStartAmount
            // 
            resources.ApplyResources(this.lblStartAmount, "lblStartAmount");
            this.errorProvider1.SetError(this.lblStartAmount, resources.GetString("lblStartAmount.Error"));
            this.errorProvider2.SetError(this.lblStartAmount, resources.GetString("lblStartAmount.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblStartAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblStartAmount.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblStartAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblStartAmount.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblStartAmount, ((int)(resources.GetObject("lblStartAmount.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblStartAmount, ((int)(resources.GetObject("lblStartAmount.IconPadding1"))));
            this.lblStartAmount.Name = "lblStartAmount";
            // 
            // lblUnit
            // 
            resources.ApplyResources(this.lblUnit, "lblUnit");
            this.errorProvider1.SetError(this.lblUnit, resources.GetString("lblUnit.Error"));
            this.errorProvider2.SetError(this.lblUnit, resources.GetString("lblUnit.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUnit.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUnit.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblUnit, ((int)(resources.GetObject("lblUnit.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblUnit, ((int)(resources.GetObject("lblUnit.IconPadding1"))));
            this.lblUnit.Name = "lblUnit";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.errorProvider1.SetError(this.lblLocation, resources.GetString("lblLocation.Error"));
            this.errorProvider2.SetError(this.lblLocation, resources.GetString("lblLocation.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLocation.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLocation.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblLocation, ((int)(resources.GetObject("lblLocation.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblLocation, ((int)(resources.GetObject("lblLocation.IconPadding1"))));
            this.lblLocation.Name = "lblLocation";
            // 
            // cmBoxLocations
            // 
            resources.ApplyResources(this.cmBoxLocations, "cmBoxLocations");
            this.cmBoxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorProvider2.SetError(this.cmBoxLocations, resources.GetString("cmBoxLocations.Error"));
            this.errorProvider1.SetError(this.cmBoxLocations, resources.GetString("cmBoxLocations.Error1"));
            this.cmBoxLocations.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmBoxLocations, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmBoxLocations.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.cmBoxLocations, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmBoxLocations.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.cmBoxLocations, ((int)(resources.GetObject("cmBoxLocations.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.cmBoxLocations, ((int)(resources.GetObject("cmBoxLocations.IconPadding1"))));
            this.cmBoxLocations.Name = "cmBoxLocations";
            // 
            // txtBoxUnit
            // 
            resources.ApplyResources(this.txtBoxUnit, "txtBoxUnit");
            this.errorProvider2.SetError(this.txtBoxUnit, resources.GetString("txtBoxUnit.Error"));
            this.errorProvider1.SetError(this.txtBoxUnit, resources.GetString("txtBoxUnit.Error1"));
            this.errorProvider2.SetIconAlignment(this.txtBoxUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxUnit.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtBoxUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxUnit.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.txtBoxUnit, ((int)(resources.GetObject("txtBoxUnit.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtBoxUnit, ((int)(resources.GetObject("txtBoxUnit.IconPadding1"))));
            this.txtBoxUnit.Name = "txtBoxUnit";
            // 
            // txtBoxStartAmount
            // 
            resources.ApplyResources(this.txtBoxStartAmount, "txtBoxStartAmount");
            this.errorProvider2.SetError(this.txtBoxStartAmount, resources.GetString("txtBoxStartAmount.Error"));
            this.errorProvider1.SetError(this.txtBoxStartAmount, resources.GetString("txtBoxStartAmount.Error1"));
            this.errorProvider2.SetIconAlignment(this.txtBoxStartAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxStartAmount.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtBoxStartAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxStartAmount.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.txtBoxStartAmount, ((int)(resources.GetObject("txtBoxStartAmount.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtBoxStartAmount, ((int)(resources.GetObject("txtBoxStartAmount.IconPadding1"))));
            this.txtBoxStartAmount.Name = "txtBoxStartAmount";
            // 
            // txtBoxName
            // 
            resources.ApplyResources(this.txtBoxName, "txtBoxName");
            this.errorProvider2.SetError(this.txtBoxName, resources.GetString("txtBoxName.Error"));
            this.errorProvider1.SetError(this.txtBoxName, resources.GetString("txtBoxName.Error1"));
            this.errorProvider2.SetIconAlignment(this.txtBoxName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtBoxName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxName.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.txtBoxName, ((int)(resources.GetObject("txtBoxName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtBoxName, ((int)(resources.GetObject("txtBoxName.IconPadding1"))));
            this.txtBoxName.Name = "txtBoxName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.errorProvider2.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error1"));
            this.errorProvider2.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding1"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.errorProvider2.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.errorProvider2.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            resources.ApplyResources(this.errorProvider2, "errorProvider2");
            // 
            // AddProductFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxStartAmount);
            this.Controls.Add(this.txtBoxUnit);
            this.Controls.Add(this.cmBoxLocations);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblStartAmount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNewProduct);
            this.Name = "AddProductFrm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartAmount;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmBoxLocations;
        private System.Windows.Forms.TextBox txtBoxUnit;
        private System.Windows.Forms.TextBox txtBoxStartAmount;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}