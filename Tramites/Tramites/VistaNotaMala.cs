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
    public partial class VistaNotaMala : Form
    {
        public string folio;
        public VistaNotaMala()
        {
            InitializeComponent();
        }

        private void VistaNotaMala_Load(object sender, EventArgs e)
        {
            Notamala nota = new Notamala();
            nota.SetParameterValue("Foli", folio);
            vistamala.ReportSource = nota;
        }
    }
}
