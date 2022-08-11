
namespace Hotel.Cliente
{
    partial class FrmSobre
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblQualquerCoisa = new System.Windows.Forms.Label();
            this.lblVersaoSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do produto";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(58, 73);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 1;
            this.lblVersao.Text = "Versao";
            // 
            // lblQualquerCoisa
            // 
            this.lblQualquerCoisa.AutoSize = true;
            this.lblQualquerCoisa.Location = new System.Drawing.Point(185, 49);
            this.lblQualquerCoisa.Name = "lblQualquerCoisa";
            this.lblQualquerCoisa.Size = new System.Drawing.Size(86, 13);
            this.lblQualquerCoisa.TabIndex = 2;
            this.lblQualquerCoisa.Text = "lblQualquerCoisa";
            // 
            // lblVersaoSistema
            // 
            this.lblVersaoSistema.AutoSize = true;
            this.lblVersaoSistema.Location = new System.Drawing.Point(185, 73);
            this.lblVersaoSistema.Name = "lblVersaoSistema";
            this.lblVersaoSistema.Size = new System.Drawing.Size(35, 13);
            this.lblVersaoSistema.TabIndex = 3;
            this.lblVersaoSistema.Text = "label4";
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 136);
            this.Controls.Add(this.lblVersaoSistema);
            this.Controls.Add(this.lblQualquerCoisa);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label1);
            this.Name = "FrmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblQualquerCoisa;
        private System.Windows.Forms.Label lblVersaoSistema;
    }
}