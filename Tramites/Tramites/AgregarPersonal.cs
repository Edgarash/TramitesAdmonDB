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
    public partial class AgregarPersonal : Form
    {
        DataTable Departamentos;
        public AgregarPersonal()
        {
            InitializeComponent();
            Departamentos = InterfaceMySQL.ObtenerCatalogo("Departamentos");
            for (int i = 0; i < Departamentos.Rows.Count; i++)
            {
                DataRow x = Departamentos.Rows[i];
                cbDepas.Items.Add(x["Departamento"]);
            }
        }
        public string FormatoFecha(DateTime Fecha)
        {
            return Fecha.Year + "-" + Fecha.Month + "-" + Fecha.Day;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            string FechaIng = FormatoFecha(dateTimePicker1.Value);
            for (int i = 0; i < Departamentos?.Rows?.Count; i++)
            {
                if (Departamentos.Rows[i]["Departamento"].ToString().ToUpper().Equals(cbDepas.Text.ToUpper()))
                {
                    id = Convert.ToInt32(Departamentos.Rows[i]["ID"]);
                }
            }

            if (txtRFC.Text == "" || txtNombre.Text == "" || txtAPaterno.Text == "" || txtAMaterno.Text == "" || cbDepas.SelectedIndex == -1 || txtPuesto.Text == "" || txtUsuario.Text =="" || txtContraseña.Text == "")
            {
                MessageBox.Show("Llene todos los campos");
            }  
            else
            {
                InterfaceMySQL.AgregarPersonal(txtRFC.Text, txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text, id, txtPuesto.Text, FechaIng, txtUsuario.Text, txtContraseña.Text);
                MessageBox.Show("El empleado se ha agregado correctamente");
            }

        }
    }
}
