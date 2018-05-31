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
    public partial class MenuNotas : Form
    {
        public MenuNotas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Hide();
            new FormNotas().ShowDialog();
            Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Hide();
            new VerNotas().ShowDialog();
            Show();
        }
    }
}
