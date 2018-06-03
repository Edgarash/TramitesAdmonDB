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
    public partial class ActualizarTramite : Form
    {
        int valor;
        public ActualizarTramite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if(rbSi.Checked)
                {
                    valor = 1;
                }
                if(rbNo.Checked)
                {
                    valor = 0;
                }
                InterfaceMySQL.AgregarTramite(txtNombre.Text, valor);
                MessageBox.Show("El tramire se ha agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void ActualizarTramite_Load(object sender, EventArgs e)
        {

        }
    }
}
