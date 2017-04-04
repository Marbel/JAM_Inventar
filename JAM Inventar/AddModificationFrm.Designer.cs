namespace JAM_Inventar
{
    partial class AddModificationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModificationFrm));
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblUse = new System.Windows.Forms.Label();
            this.lblCommentar = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUse = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            resources.ApplyResources(this.lblProduct, "lblProduct");
            this.errorProvider1.SetError(this.lblProduct, resources.GetString("lblProduct.Error"));
            this.errorProvider1.SetIconAlignment(this.lblProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblProduct.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblProduct, ((int)(resources.GetObject("lblProduct.IconPadding"))));
            this.lblProduct.Name = "lblProduct";
            // 
            // lblAmount
            // 
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.errorProvider1.SetError(this.lblAmount, resources.GetString("lblAmount.Error"));
            this.errorProvider1.SetIconAlignment(this.lblAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblAmount, ((int)(resources.GetObject("lblAmount.IconPadding"))));
            this.lblAmount.Name = "lblAmount";
            // 
            // lblUse
            // 
            resources.ApplyResources(this.lblUse, "lblUse");
            this.errorProvider1.SetError(this.lblUse, resources.GetString("lblUse.Error"));
            this.errorProvider1.SetIconAlignment(this.lblUse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblUse, ((int)(resources.GetObject("lblUse.IconPadding"))));
            this.lblUse.Name = "lblUse";
            // 
            // lblCommentar
            // 
            resources.ApplyResources(this.lblCommentar, "lblCommentar");
            this.errorProvider1.SetError(this.lblCommentar, resources.GetString("lblCommentar.Error"));
            this.errorProvider1.SetIconAlignment(this.lblCommentar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCommentar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblCommentar, ((int)(resources.GetObject("lblCommentar.IconPadding"))));
            this.lblCommentar.Name = "lblCommentar";
            // 
            // txtAmount
            // 
            resources.ApplyResources(this.txtAmount, "txtAmount");
            this.errorProvider1.SetError(this.txtAmount, resources.GetString("txtAmount.Error"));
            this.errorProvider1.SetIconAlignment(this.txtAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtAmount, ((int)(resources.GetObject("txtAmount.IconPadding"))));
            this.txtAmount.Name = "txtAmount";
            // 
            // txtUse
            // 
            resources.ApplyResources(this.txtUse, "txtUse");
            this.errorProvider1.SetError(this.txtUse, resources.GetString("txtUse.Error"));
            this.errorProvider1.SetIconAlignment(this.txtUse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtUse, ((int)(resources.GetObject("txtUse.IconPadding"))));
            this.txtUse.Name = "txtUse";
            // 
            // txtComment
            // 
            this.txtComment.AcceptsReturn = true;
            resources.ApplyResources(this.txtComment, "txtComment");
            this.errorProvider1.SetError(this.txtComment, resources.GetString("txtComment.Error"));
            this.errorProvider1.SetIconAlignment(this.txtComment, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtComment.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtComment, ((int)(resources.GetObject("txtComment.IconPadding"))));
            this.txtComment.Name = "txtComment";
            // 
            // BtnSave
            // 
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.errorProvider1.SetError(this.BtnSave, resources.GetString("BtnSave.Error"));
            this.errorProvider1.SetIconAlignment(this.BtnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BtnSave.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.BtnSave, ((int)(resources.GetObject("BtnSave.IconPadding"))));
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.errorProvider1.SetError(this.BtnCancel, resources.GetString("BtnCancel.Error"));
            this.errorProvider1.SetIconAlignment(this.BtnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("BtnCancel.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.BtnCancel, ((int)(resources.GetObject("BtnCancel.IconPadding"))));
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // AddModificationFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtUse);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblCommentar);
            this.Controls.Add(this.lblUse);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddModificationFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddModificationFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.Label lblCommentar;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUse;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}