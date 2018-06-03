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
    public partial class VerCatalogo : Form
    {
        public enum Catalogo { Personal, Departamentos, Tramites };
        Catalogo TipoCatalogo { get; set; }
        string Tipo { get; set; }
        public VerCatalogo(string Tipo)
        {
            InitializeComponent();
            this.Tipo = Tipo;
            this.TipoForm();
            this.Vista();
            this.Resize += new System.EventHandler(this.VerCatalogo_Resize);
        }

        private void Vista()
        {
            switch (TipoCatalogo)
            {
                case Catalogo.Personal:
                    Text += " Personal";
                    break;
                case Catalogo.Departamentos:
                    Text += " Departamentos";
                    break;
                case Catalogo.Tramites:
                    Text += " Tramites";
                    break;
                default:
                    break;
            }
        }

        private void TipoForm()
        {
            switch (Tipo)
            {
                case "Departamentos":
                    TipoCatalogo = Catalogo.Departamentos;
                    break;
                case "Personal":
                    TipoCatalogo = Catalogo.Personal;
                    break;
                case "Tramites":
                    TipoCatalogo = Catalogo.Tramites;
                    break;
                default:
                    break;
            }
            dgvLista.DataSource = InterfaceMySQL.ObtenerCatalogo(Tipo);
            AjustarData();
        }

        private void VerCatalogo_Resize(object sender, EventArgs e)
        {
            AjustarData();
        }

        private void AjustarData()
        {
            dgvLista.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (dgvLista.ColumnCount > 0)
                if (dgvLista.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed) >= dgvLista.Width)
                    dgvLista.Columns[dgvLista.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                else
                    dgvLista.Columns[dgvLista.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (Tipo) {
                case "Departamentos":
                    TipoCatalogo = Catalogo.Departamentos;
                    new AgregarDepartamentos().ShowDialog();

                    break;
                case "Personal":
                    TipoCatalogo = Catalogo.Personal;
                    if ((InterfaceMySQL.ObtenerCatalogo("Departamentos")?.Rows?.Count > 0))
                        new AgregarPersonal().ShowDialog();
                    else {
                        MessageBox.Show(
                            "No se pueden agregar usuarios si no hay departamentos",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                            );
                    }
                    break;
                case "Tramites":
                    TipoCatalogo = Catalogo.Tramites;
                    new ActualizarTramite().ShowDialog();
                    break;
                default:
                    break;
            }
            dgvLista.DataSource = InterfaceMySQL.ObtenerCatalogo(Tipo);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {if (dgvLista.CurrentCell != null) {
                switch (Tipo) {
                    case "Departamentos":
                        TipoCatalogo = Catalogo.Departamentos;
                        string Idep = dgvLista[0, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string Nombre = dgvLista[1, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string Jefe = dgvLista[2, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        DataTable Departamento;
                        Departamento = InterfaceMySQL.ObtenerCatalogo("Departamento");
                        InterfaceMySQL.MostrarDepartamento(Convert.ToInt32(Idep));
                        new ActualizarDepartamentos(Idep, Nombre, Jefe).ShowDialog();
                        break;
                    case "Personal":
                        TipoCatalogo = Catalogo.Personal;
                        string NumEmp = dgvLista[0, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string RFC = dgvLista[1, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string Nombre2 = dgvLista[2, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string APaterno = dgvLista[3, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string AMaterno = dgvLista[4, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string Departamento2 = dgvLista[5, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string Puesto = dgvLista[6, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string FechaIngreso = dgvLista[7, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        DataTable Personal;
                        Personal = InterfaceMySQL.ObtenerCatalogo("Personal");
                        InterfaceMySQL.MostrarPersonal(Convert.ToInt32(NumEmp));
                        new ActualizarPersonal(NumEmp, RFC, Nombre2, APaterno, AMaterno, Departamento2, Puesto, FechaIngreso).ShowDialog();
                        break;
                    case "Tramites":
                        TipoCatalogo = Catalogo.Tramites;
                        string NoTra = dgvLista[0, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string Nombre3 = dgvLista[1, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        string local = dgvLista[2, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        DataTable Tramites;
                        Tramites = InterfaceMySQL.ObtenerCatalogo("Tramites");
                        InterfaceMySQL.MostrarTramite(Convert.ToInt32(NoTra));
                        new ActualizaTra(NoTra,Nombre3,local).ShowDialog();
                        break;
                    default:
                        break;
                }
                dgvLista.DataSource = InterfaceMySQL.ObtenerCatalogo(Tipo);
            }
            else {
                MessageBox.Show("Ningun dato seleccionado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentCell != null) {
                switch (Tipo) {
                    case "Departamentos":
                        TipoCatalogo = Catalogo.Departamentos;
                        string Idep = dgvLista[0, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        InterfaceMySQL.EliminarDepartamento(Convert.ToInt32(Idep));
                        break;
                    case "Personal":
                        TipoCatalogo = Catalogo.Personal;
                        string NumEmp = dgvLista[0, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        InterfaceMySQL.EliminarPersonal(Convert.ToInt32(NumEmp));
                        break;
                    case "Tramites":
                        TipoCatalogo = Catalogo.Tramites;
                        string NoTra = dgvLista[0, dgvLista.CurrentCell.RowIndex].Value.ToString();
                        InterfaceMySQL.EliminarTramite(Convert.ToInt32(NoTra));
                        break;
                    default:
                        break;
                }
                dgvLista.DataSource = InterfaceMySQL.ObtenerCatalogo(Tipo);
            }
            else {
                MessageBox.Show("Ningun dato seleccionado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}