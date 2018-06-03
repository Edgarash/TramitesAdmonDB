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
    public partial class VerNotas : Form
    {
        public VerNotas()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.VerCatalogo_Resize);
        }
        private void VerCatalogo_Resize(object sender, EventArgs e)
        {
            AjustarData();
        }

        private void AjustarData()
        {
            dgvNotas.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (dgvNotas.ColumnCount > 0)
                if (dgvNotas.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed) >= dgvNotas.Width)
                    dgvNotas.Columns[dgvNotas.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                else
                    dgvNotas.Columns[dgvNotas.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (rbBuena.Checked)
            {
                dgvNotas.DataSource = InterfaceMySQL.MostrarNotasBuenas();
                AjustarData();
            }
            else{
                dgvNotas.DataSource = InterfaceMySQL.MostrarNotasMalas();
                AjustarData();
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rbBuena.Checked)
            {
                VistaNotaBuena vista = new VistaNotaBuena();
                string fol = dgvNotas[0, dgvNotas.CurrentCell.RowIndex].Value.ToString();
                vista.folio = fol;
                vista.ShowDialog();
            }
            else
            {
                VistaNotaMala vista = new VistaNotaMala();
                string fol = dgvNotas[0, dgvNotas.CurrentCell.RowIndex].Value.ToString();
                vista.folio = fol;
                vista.ShowDialog();

            }
        }
    }
}
