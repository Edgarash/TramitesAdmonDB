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
    public partial class VistaNotaBuena : Form
    {
        public string folio;
        public VistaNotaBuena()
        {
            InitializeComponent();
        }

        private void VistaNotaBuena_Load(object sender, EventArgs e)
        {
            Notabuena nota = new Notabuena();
            nota.SetParameterValue("Foli", folio);
            crystalReportViewer1.ReportSource = nota;
        }
        
    }
}
