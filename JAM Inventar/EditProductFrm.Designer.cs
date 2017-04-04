namespace JAM_Inventar
{
    partial class EditProductFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductFrm));
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxStartAmount = new System.Windows.Forms.TextBox();
            this.txtBoxUnit = new System.Windows.Forms.TextBox();
            this.cmBoxLocations = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblStartAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            resources.ApplyResources(this.lblProduct, "lblProduct");
            this.errorProvider1.SetError(this.lblProduct, resources.GetString("lblProduct.Error"));
            this.lblProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorProvider1.SetIconAlignment(this.lblProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblProduct.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblProduct, ((int)(resources.GetObject("lblProduct.IconPadding"))));
            this.lblProduct.Name = "lblProduct";
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
            // txtBoxName
            // 
            resources.ApplyResources(this.txtBoxName, "txtBoxName");
            this.errorProvider1.SetError(this.txtBoxName, resources.GetString("txtBoxName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtBoxName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtBoxName, ((int)(resources.GetObject("txtBoxName.IconPadding"))));
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxName_Validating);
            // 
            // txtBoxStartAmount
            // 
            resources.ApplyResources(this.txtBoxStartAmount, "txtBoxStartAmount");
            this.errorProvider1.SetError(this.txtBoxStartAmount, resources.GetString("txtBoxStartAmount.Error"));
            this.errorProvider1.SetIconAlignment(this.txtBoxStartAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxStartAmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtBoxStartAmount, ((int)(resources.GetObject("txtBoxStartAmount.IconPadding"))));
            this.txtBoxStartAmount.Name = "txtBoxStartAmount";
            this.txtBoxStartAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStartAmount_Validating);
            // 
            // txtBoxUnit
            // 
            resources.ApplyResources(this.txtBoxUnit, "txtBoxUnit");
            this.errorProvider1.SetError(this.txtBoxUnit, resources.GetString("txtBoxUnit.Error"));
            this.errorProvider1.SetIconAlignment(this.txtBoxUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtBoxUnit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtBoxUnit, ((int)(resources.GetObject("txtBoxUnit.IconPadding"))));
            this.txtBoxUnit.Name = "txtBoxUnit";
            this.txtBoxUnit.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxUnit_Validating);
            // 
            // cmBoxLocations
            // 
            resources.ApplyResources(this.cmBoxLocations, "cmBoxLocations");
            this.cmBoxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorProvider1.SetError(this.cmBoxLocations, resources.GetString("cmBoxLocations.Error"));
            this.cmBoxLocations.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cmBoxLocations, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmBoxLocations.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.cmBoxLocations, ((int)(resources.GetObject("cmBoxLocations.IconPadding"))));
            this.cmBoxLocations.Name = "cmBoxLocations";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.errorProvider1.SetError(this.lblLocation, resources.GetString("lblLocation.Error"));
            this.lblLocation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorProvider1.SetIconAlignment(this.lblLocation, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLocation.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblLocation, ((int)(resources.GetObject("lblLocation.IconPadding"))));
            this.lblLocation.Name = "lblLocation";
            // 
            // lblUnit
            // 
            resources.ApplyResources(this.lblUnit, "lblUnit");
            this.errorProvider1.SetError(this.lblUnit, resources.GetString("lblUnit.Error"));
            this.lblUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorProvider1.SetIconAlignment(this.lblUnit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUnit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblUnit, ((int)(resources.GetObject("lblUnit.IconPadding"))));
            this.lblUnit.Name = "lblUnit";
            // 
            // lblStartAmount
            // 
            resources.ApplyResources(this.lblStartAmount, "lblStartAmount");
            this.errorProvider1.SetError(this.lblStartAmount, resources.GetString("lblStartAmount.Error"));
            this.lblStartAmount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorProvider1.SetIconAlignment(this.lblStartAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblStartAmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblStartAmount, ((int)(resources.GetObject("lblStartAmount.IconPadding"))));
            this.lblStartAmount.Name = "lblStartAmount";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.errorProvider1.SetError(this.lblName, resources.GetString("lblName.Error"));
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorProvider1.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding"))));
            this.lblName.Name = "lblName";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // EditProductFrm
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
            this.Controls.Add(this.lblProduct);
            this.MaximizeBox = false;
            this.Name = "EditProductFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProductFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxStartAmount;
        private System.Windows.Forms.TextBox txtBoxUnit;
        private System.Windows.Forms.ComboBox cmBoxLocations;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblStartAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}