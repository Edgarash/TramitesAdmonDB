
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tramites
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirCatalogo(object sender, EventArgs e)
        {
            Hide();
            new VerCatalogo((sender as Control).Text).ShowDialog();
            Show();
        }

        private void AgregarNota_Click(object sender, EventArgs e)
        {
            new FormNotas().ShowDialog();
        }
    }
}
