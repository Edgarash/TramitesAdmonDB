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
    public partial class ActualizaTra : Form
    {
        DataTable Tramites;
        string NoTra { get; set; }
        string Nombre { get; set; }
        string local { get; set; }
        int valor;
        public ActualizaTra(string NoTra, string Nombre, string local)
        {
            InitializeComponent();
            this.NoTra = NoTra;
            this.Nombre = Nombre;
            this.local = local;
        }

      
        private void ActualizaTra_Load(object sender, EventArgs e)
        {
            Tramites = InterfaceMySQL.ObtenerCatalogo("Tramites");
            lblNoTramite.Text = NoTra;
            txtNombre.Text = Nombre;
            if(local == "SI")
            {
                rbSi.Checked = true;
            }else
            {
                rbNo.Checked = true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rbSi.Checked)
                {
                    valor = 1;
                }
                if (rbNo.Checked)
                {
                    valor = 0;
                }
                InterfaceMySQL.ActualizarTramite(Convert.ToInt32(lblNoTramite.Text),txtNombre.Text, valor);
                MessageBox.Show("El tramire se ha actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
