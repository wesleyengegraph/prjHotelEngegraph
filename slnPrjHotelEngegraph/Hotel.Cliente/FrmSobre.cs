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
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            lblQualquerCoisa.Text = VersaoSistema.NomeSistema;
            lblVersaoSistema.Text = VersaoSistema.Versao;
            CenterToScreen();
        }
    }
}
