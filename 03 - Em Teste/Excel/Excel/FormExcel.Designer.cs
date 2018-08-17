namespace Excel
{
    partial class FormExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcel));
            this.labelHeader = new System.Windows.Forms.Label();
            this.lblCodFunci = new System.Windows.Forms.Label();
            this.txtCodigoFunci = new System.Windows.Forms.TextBox();
            this.lblNomeFunci = new System.Windows.Forms.Label();
            this.txtNomeFunci = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelHeader, "labelHeader");
            this.labelHeader.Name = "labelHeader";
            // 
            // lblCodFunci
            // 
            resources.ApplyResources(this.lblCodFunci, "lblCodFunci");
            this.lblCodFunci.Name = "lblCodFunci";
            // 
            // txtCodigoFunci
            // 
            resources.ApplyResources(this.txtCodigoFunci, "txtCodigoFunci");
            this.txtCodigoFunci.Name = "txtCodigoFunci";
            // 
            // lblNomeFunci
            // 
            resources.ApplyResources(this.lblNomeFunci, "lblNomeFunci");
            this.lblNomeFunci.Name = "lblNomeFunci";
            // 
            // txtNomeFunci
            // 
            resources.ApplyResources(this.txtNomeFunci, "txtNomeFunci");
            this.txtNomeFunci.Name = "txtNomeFunci";
            // 
            // btnNovo
            // 
            resources.ApplyResources(this.btnNovo, "btnNovo");
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            resources.ApplyResources(this.btnAtualizar, "btnAtualizar");
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnProcurar
            // 
            resources.ApplyResources(this.btnProcurar, "btnProcurar");
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // FormExcel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtNomeFunci);
            this.Controls.Add(this.lblNomeFunci);
            this.Controls.Add(this.txtCodigoFunci);
            this.Controls.Add(this.lblCodFunci);
            this.Controls.Add(this.labelHeader);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormExcel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExcel_FormClosing);
            this.Load += new System.EventHandler(this.FormExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label lblCodFunci;
        private System.Windows.Forms.TextBox txtCodigoFunci;
        private System.Windows.Forms.Label lblNomeFunci;
        private System.Windows.Forms.TextBox txtNomeFunci;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

