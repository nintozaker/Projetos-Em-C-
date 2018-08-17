namespace JournalScreenControl.UI
{
    partial class frmMain
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.svdTela = new System.Windows.Forms.SaveFileDialog();
            this.picTela = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTela)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(232, 315);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 325);
            this.treeView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 325);
            this.panel1.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(232, 274);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // svdTela
            // 
            this.svdTela.Filter = "JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png";
            // 
            // picTela
            // 
            this.picTela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTela.BackColor = System.Drawing.Color.White;
            this.picTela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTela.Location = new System.Drawing.Point(219, 179);
            this.picTela.Name = "picTela";
            this.picTela.Size = new System.Drawing.Size(149, 77);
            this.picTela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTela.TabIndex = 4;
            this.picTela.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.Controls.Add(this.picTela);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIniciar);
            this.Name = "frmMain";
            this.Text = "Journal Screen Control";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.SaveFileDialog svdTela;
        private System.Windows.Forms.PictureBox picTela;
    }
}