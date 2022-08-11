
namespace Hotel.Cliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fórmasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDePagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.walkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.mmConsultasOcupacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mmCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.mmCheckoutCheckout = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmCadastros,
            this.mmReservas,
            this.mmCheckIn,
            this.mmConsultas,
            this.mmCheckout,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mmCadastros
            // 
            this.mmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.uHToolStripMenuItem,
            this.tiposDePagamentosToolStripMenuItem});
            this.mmCadastros.Name = "mmCadastros";
            this.mmCadastros.Size = new System.Drawing.Size(71, 20);
            this.mmCadastros.Text = "&Cadastros";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeUHToolStripMenuItem,
            this.uHToolStripMenuItem1});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.novoToolStripMenuItem.Text = "&Hotel";
            // 
            // tipoDeUHToolStripMenuItem
            // 
            this.tipoDeUHToolStripMenuItem.Name = "tipoDeUHToolStripMenuItem";
            this.tipoDeUHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeUHToolStripMenuItem.Text = "&Tipo de UH";
            this.tipoDeUHToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUHToolStripMenuItem_Click);
            // 
            // uHToolStripMenuItem1
            // 
            this.uHToolStripMenuItem1.Name = "uHToolStripMenuItem1";
            this.uHToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.uHToolStripMenuItem1.Text = "&UH";
            this.uHToolStripMenuItem1.Click += new System.EventHandler(this.uHToolStripMenuItem1_Click);
            // 
            // uHToolStripMenuItem
            // 
            this.uHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fórmasDePagamentoToolStripMenuItem});
            this.uHToolStripMenuItem.Name = "uHToolStripMenuItem";
            this.uHToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.uHToolStripMenuItem.Text = "&Financeiro";
            // 
            // fórmasDePagamentoToolStripMenuItem
            // 
            this.fórmasDePagamentoToolStripMenuItem.Name = "fórmasDePagamentoToolStripMenuItem";
            this.fórmasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.fórmasDePagamentoToolStripMenuItem.Text = "&Fórmas de Pagamento";
            // 
            // tiposDePagamentosToolStripMenuItem
            // 
            this.tiposDePagamentosToolStripMenuItem.Name = "tiposDePagamentosToolStripMenuItem";
            this.tiposDePagamentosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tiposDePagamentosToolStripMenuItem.Text = "&Tipos de Pagamentos";
            // 
            // mmReservas
            // 
            this.mmReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.novaReservaToolStripMenuItem});
            this.mmReservas.Name = "mmReservas";
            this.mmReservas.Size = new System.Drawing.Size(64, 20);
            this.mmReservas.Text = "&Reservas";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.consultaToolStripMenuItem.Text = "&Consulta";
            // 
            // novaReservaToolStripMenuItem
            // 
            this.novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            this.novaReservaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.novaReservaToolStripMenuItem.Text = "&Nova Reserva";
            // 
            // mmCheckIn
            // 
            this.mmCheckIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem1,
            this.walkInToolStripMenuItem});
            this.mmCheckIn.Name = "mmCheckIn";
            this.mmCheckIn.Size = new System.Drawing.Size(65, 20);
            this.mmCheckIn.Text = "Check &In";
            // 
            // checkInToolStripMenuItem1
            // 
            this.checkInToolStripMenuItem1.Name = "checkInToolStripMenuItem1";
            this.checkInToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.checkInToolStripMenuItem1.Text = "&CheckIn";
            // 
            // walkInToolStripMenuItem
            // 
            this.walkInToolStripMenuItem.Name = "walkInToolStripMenuItem";
            this.walkInToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.walkInToolStripMenuItem.Text = "&WalkIn";
            // 
            // mmConsultas
            // 
            this.mmConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmConsultasOcupacao});
            this.mmConsultas.Name = "mmConsultas";
            this.mmConsultas.Size = new System.Drawing.Size(71, 20);
            this.mmConsultas.Text = "C&onsultas";
            // 
            // mmConsultasOcupacao
            // 
            this.mmConsultasOcupacao.Name = "mmConsultasOcupacao";
            this.mmConsultasOcupacao.Size = new System.Drawing.Size(128, 22);
            this.mmConsultasOcupacao.Text = "&Ocupação";
            // 
            // mmCheckout
            // 
            this.mmCheckout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmCheckoutCheckout});
            this.mmCheckout.Name = "mmCheckout";
            this.mmCheckout.Size = new System.Drawing.Size(72, 20);
            this.mmCheckout.Text = "Check&Out";
            // 
            // mmCheckoutCheckout
            // 
            this.mmCheckoutCheckout.Name = "mmCheckoutCheckout";
            this.mmCheckoutCheckout.Size = new System.Drawing.Size(125, 22);
            this.mmCheckoutCheckout.Text = "&Checkout";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // mnSobre
            // 
            this.mnSobre.Name = "mnSobre";
            this.mnSobre.Size = new System.Drawing.Size(180, 22);
            this.mnSobre.Text = "&Sobre";
            this.mnSobre.Click += new System.EventHandler(this.mnSobre_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Hotel Engegraph";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mmCadastros;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fórmasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDePagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmReservas;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmCheckIn;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem walkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmConsultas;
        private System.Windows.Forms.ToolStripMenuItem mmConsultasOcupacao;
        private System.Windows.Forms.ToolStripMenuItem mmCheckout;
        private System.Windows.Forms.ToolStripMenuItem mmCheckoutCheckout;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSobre;
    }
}

