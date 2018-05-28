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
    public partial class ActualizarDepartamentos : Form
    {
        DataTable Personal;
        DataTable Departamento;
        string Nombre { get; set; }
        string Jefe { get; set; }
        string ID { get; set; }
        public ActualizarDepartamentos(string id,string Nombre, string Jefe)
        {
            InitializeComponent();
            this.Nombre = Nombre;
            this.Jefe = Jefe;
            this.ID = id;

            Personal = InterfaceMySQL.ObtenerCatalogo("Personal");
            for (int i = 0; i < Personal.Rows.Count; i++)
            {
                DataRow x = Personal.Rows[i];
                comboBox1.Items.Add(x["Nombre"]);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < Personal?.Rows?.Count; i++)
            {
                if (Personal.Rows[i]["Nombre"].ToString().ToUpper().Equals(comboBox1.Text.ToUpper()))
                {
                    id = Convert.ToInt32(Personal.Rows[i]["ID"]);
                }
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("No se han completado los campos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InterfaceMySQL.ActualizarDepa( Convert.ToInt32(lblNum.Text),txtNombre.Text, id);
                MessageBox.Show("El departamento se ha actualizado correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            
        }

        private void ActualizarDepartamentos_Load(object sender, EventArgs e)
        {
            Departamento = InterfaceMySQL.ObtenerCatalogo("Departamento");
            lblNum.Text = ID;
            txtNombre.Text = Nombre;
            comboBox1.Text = Jefe;
        }
    }
}

