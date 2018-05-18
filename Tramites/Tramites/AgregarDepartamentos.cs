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
    public partial class AgregarDepartamentos : Form
    {
        DataTable Personal;
        public AgregarDepartamentos()
        {
            InitializeComponent();
            Personal = InterfaceMySQL.ObtenerCatalogo("Personal");
            for (int i = 0; i < Personal.Rows.Count; i++)
            {
                DataRow x = Personal.Rows[i];
                comboBox1.Items.Add(x["Nombre"]);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < Personal?.Rows?.Count; i++)
            {
                if (Personal.Rows[i]["Nombre"].ToString().ToUpper().Equals(comboBox1.Text.ToUpper()))
                {
                    id = Convert.ToInt32(Personal.Rows[i]["ID"]);
                }
            }
            if (txtNombre.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No se han completado los campos");
            }
            else
            {
                InterfaceMySQL.AgregarDepa(txtNombre.Text, id);
                MessageBox.Show("El departamento se ha agregado correctamente");
            }
        }


    }
}

