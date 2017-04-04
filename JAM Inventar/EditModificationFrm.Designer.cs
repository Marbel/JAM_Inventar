namespace JAM_Inventar
{
    partial class EditModificationFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditModificationFrm));
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtUse = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCommentar = new System.Windows.Forms.Label();
            this.lblUse = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblModUserTxt = new System.Windows.Forms.Label();
            this.lblOldModUser = new System.Windows.Forms.Label();
            this.lblNewModUserTxt = new System.Windows.Forms.Label();
            this.lblNewModUser = new System.Windows.Forms.Label();
            this.lblModTimeTxt = new System.Windows.Forms.Label();
            this.lblModTime = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // txtComment
            // 
            this.txtComment.AcceptsReturn = true;
            resources.ApplyResources(this.txtComment, "txtComment");
            this.errorProvider1.SetError(this.txtComment, resources.GetString("txtComment.Error"));
            this.errorProvider1.SetIconAlignment(this.txtComment, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtComment.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtComment, ((int)(resources.GetObject("txtComment.IconPadding"))));
            this.txtComment.Name = "txtComment";
            // 
            // txtUse
            // 
            resources.ApplyResources(this.txtUse, "txtUse");
            this.errorProvider1.SetError(this.txtUse, resources.GetString("txtUse.Error"));
            this.errorProvider1.SetIconAlignment(this.txtUse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtUse, ((int)(resources.GetObject("txtUse.IconPadding"))));
            this.txtUse.Name = "txtUse";
            // 
            // txtAmount
            // 
            resources.ApplyResources(this.txtAmount, "txtAmount");
            this.errorProvider1.SetError(this.txtAmount, resources.GetString("txtAmount.Error"));
            this.errorProvider1.SetIconAlignment(this.txtAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtAmount, ((int)(resources.GetObject("txtAmount.IconPadding"))));
            this.txtAmount.Name = "txtAmount";
            // 
            // lblCommentar
            // 
            resources.ApplyResources(this.lblCommentar, "lblCommentar");
            this.errorProvider1.SetError(this.lblCommentar, resources.GetString("lblCommentar.Error"));
            this.errorProvider1.SetIconAlignment(this.lblCommentar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCommentar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblCommentar, ((int)(resources.GetObject("lblCommentar.IconPadding"))));
            this.lblCommentar.Name = "lblCommentar";
            // 
            // lblUse
            // 
            resources.ApplyResources(this.lblUse, "lblUse");
            this.errorProvider1.SetError(this.lblUse, resources.GetString("lblUse.Error"));
            this.errorProvider1.SetIconAlignment(this.lblUse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUse.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblUse, ((int)(resources.GetObject("lblUse.IconPadding"))));
            this.lblUse.Name = "lblUse";
            // 
            // lblAmount
            // 
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.errorProvider1.SetError(this.lblAmount, resources.GetString("lblAmount.Error"));
            this.errorProvider1.SetIconAlignment(this.lblAmount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAmount.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblAmount, ((int)(resources.GetObject("lblAmount.IconPadding"))));
            this.lblAmount.Name = "lblAmount";
            // 
            // lblProduct
            // 
            resources.ApplyResources(this.lblProduct, "lblProduct");
            this.errorProvider1.SetError(this.lblProduct, resources.GetString("lblProduct.Error"));
            this.errorProvider1.SetIconAlignment(this.lblProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblProduct.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblProduct, ((int)(resources.GetObject("lblProduct.IconPadding"))));
            this.lblProduct.Name = "lblProduct";
            // 
            // lblModUserTxt
            // 
            resources.ApplyResources(this.lblModUserTxt, "lblModUserTxt");
            this.errorProvider1.SetError(this.lblModUserTxt, resources.GetString("lblModUserTxt.Error"));
            this.errorProvider1.SetIconAlignment(this.lblModUserTxt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblModUserTxt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblModUserTxt, ((int)(resources.GetObject("lblModUserTxt.IconPadding"))));
            this.lblModUserTxt.Name = "lblModUserTxt";
            // 
            // lblOldModUser
            // 
            resources.ApplyResources(this.lblOldModUser, "lblOldModUser");
            this.errorProvider1.SetError(this.lblOldModUser, resources.GetString("lblOldModUser.Error"));
            this.errorProvider1.SetIconAlignment(this.lblOldModUser, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblOldModUser.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblOldModUser, ((int)(resources.GetObject("lblOldModUser.IconPadding"))));
            this.lblOldModUser.Name = "lblOldModUser";
            // 
            // lblNewModUserTxt
            // 
            resources.ApplyResources(this.lblNewModUserTxt, "lblNewModUserTxt");
            this.errorProvider1.SetError(this.lblNewModUserTxt, resources.GetString("lblNewModUserTxt.Error"));
            this.errorProvider1.SetIconAlignment(this.lblNewModUserTxt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNewModUserTxt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblNewModUserTxt, ((int)(resources.GetObject("lblNewModUserTxt.IconPadding"))));
            this.lblNewModUserTxt.Name = "lblNewModUserTxt";
            // 
            // lblNewModUser
            // 
            resources.ApplyResources(this.lblNewModUser, "lblNewModUser");
            this.errorProvider1.SetError(this.lblNewModUser, resources.GetString("lblNewModUser.Error"));
            this.errorProvider1.SetIconAlignment(this.lblNewModUser, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNewModUser.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblNewModUser, ((int)(resources.GetObject("lblNewModUser.IconPadding"))));
            this.lblNewModUser.Name = "lblNewModUser";
            // 
            // lblModTimeTxt
            // 
            resources.ApplyResources(this.lblModTimeTxt, "lblModTimeTxt");
            this.errorProvider1.SetError(this.lblModTimeTxt, resources.GetString("lblModTimeTxt.Error"));
            this.errorProvider1.SetIconAlignment(this.lblModTimeTxt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblModTimeTxt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblModTimeTxt, ((int)(resources.GetObject("lblModTimeTxt.IconPadding"))));
            this.lblModTimeTxt.Name = "lblModTimeTxt";
            // 
            // lblModTime
            // 
            resources.ApplyResources(this.lblModTime, "lblModTime");
            this.errorProvider1.SetError(this.lblModTime, resources.GetString("lblModTime.Error"));
            this.errorProvider1.SetIconAlignment(this.lblModTime, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblModTime.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblModTime, ((int)(resources.GetObject("lblModTime.IconPadding"))));
            this.lblModTime.Name = "lblModTime";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // EditModificationFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblModTimeTxt);
            this.Controls.Add(this.lblNewModUserTxt);
            this.Controls.Add(this.lblModTime);
            this.Controls.Add(this.lblNewModUser);
            this.Controls.Add(this.lblOldModUser);
            this.Controls.Add(this.lblModUserTxt);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtUse);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblCommentar);
            this.Controls.Add(this.lblUse);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblProduct);
            this.Name = "EditModificationFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditModificationFrm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditModificationFrm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtUse;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCommentar;
        private System.Windows.Forms.Label lblUse;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblModUserTxt;
        private System.Windows.Forms.Label lblOldModUser;
        private System.Windows.Forms.Label lblNewModUserTxt;
        private System.Windows.Forms.Label lblNewModUser;
        private System.Windows.Forms.Label lblModTimeTxt;
        private System.Windows.Forms.Label lblModTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}