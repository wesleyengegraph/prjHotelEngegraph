using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Cliente
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = string.Concat(VersaoSistema.NomeSistema, " ", VersaoSistema.Versao);
            CenterToScreen();
        }

        private void mnSobre_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sobre...", "Ajuda");
            new FrmSobre().ShowDialog(); 
        }

        private void tipoDeUHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadTipoUh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void uHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadUh();
            frm.ShowDialog();
        }
    }
}
