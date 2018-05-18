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
    public partial class ActualizarPersonal : Form
    {
        DataTable Departamentos;
        DataTable Personal;
        string NumEmp { get; set; }
        string RFC { get; set; }
        string Nombre{ get; set; }
        string APaterno { get; set; }
        string AMaterno { get; set; }
        string Departamento { get; set; }
        string Puesto { get; set; }
        string FechaIngreso { get; set; }

        public ActualizarPersonal(string NumEmp, string RFC, string Nombre, string APaterno, string AMaterno, string Departamento, string Puesto, string FechaIngreso)
            
        {
            InitializeComponent();
            this.NumEmp = NumEmp;
            this.RFC = RFC;
            this.Nombre = Nombre;
            this.APaterno = APaterno;
            this.AMaterno = AMaterno;
            this.Departamento = Departamento;
            this.Puesto = Puesto;
            this.FechaIngreso = FechaIngreso;
            

            Departamentos = InterfaceMySQL.ObtenerCatalogo("Departamentos");
            this.Load += ActualizarPersonal_Load;
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

      

        private void ActualizarPersonal_Load(object sender, EventArgs e)
        {
            Personal = InterfaceMySQL.ObtenerCatalogo("Personal");
            lblEmpleado.Text = NumEmp;
            txtRFC.Text = RFC;
            txtNombre.Text = Nombre;
            txtAPaterno.Text = APaterno;
            txtAMaterno.Text = AMaterno;
            cbDepas.Text = Departamento;
            txtPuesto.Text = Puesto;
            lblFecha.Text = FechaIngreso;

        }

        private void button1_Click_1(object sender, EventArgs e)
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

            if (txtRFC.Text == "" || txtNombre.Text == "" || txtAPaterno.Text == "" || txtAMaterno.Text == "" || cbDepas.SelectedIndex == -1 || txtPuesto.Text == "")
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                InterfaceMySQL.ActualizarPersonal(Convert.ToInt32(lblEmpleado.Text),txtRFC.Text, txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text,id, txtPuesto.Text, FechaIng);
                MessageBox.Show("El empleado se ha actualizado correctamente");
            }
        }
    }
}
