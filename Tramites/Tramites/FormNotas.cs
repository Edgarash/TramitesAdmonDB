using System;
using System.Data;
using System.Windows.Forms;

namespace Tramites
{
    public partial class FormNotas : Form
    {
        DataTable Personal;
        public FormNotas()
        {
            InitializeComponent();
            Cargar();
        }

        private void Cargar()
        {
            Personal = InterfaceMySQL.ObtenerCatalogo("Personal");
            DataView temp = Personal.DefaultView;
            temp.Sort = "Apellido Paterno asc";
            Personal = temp.ToTable();
            for (int i = 0; i < Personal?.Rows?.Count; i++) {
                DataRow x = Personal.Rows[i];
                string Nombre = x["Apellido Paterno"].ToString() + " " + x["Apellido Materno"].ToString() + " " + x["Nombre"].ToString();
                cbNombreExpide.Items.Add(Nombre);
                cbNombreTrabajador.Items.Add(Nombre);
            }
        }

        private int ObtenerID_Personal(string Nombre)
        {
            for (int i = 0; i < Personal?.Rows?.Count; i++) {
                DataRow x = Personal.Rows[i];
                string Buscando = x["Apellido Paterno"].ToString() + " " + x["Apellido Materno"].ToString() + " " + x["Nombre"].ToString();
                if (Buscando.Equals(Nombre)) {
                    return Convert.ToInt32(x["ID"]);
                }
            }
            return 0;
        }

        private string ObtenerNombre_Personal(int ID)
        {
            for (int i = 0; i < Personal?.Rows?.Count; i++) {
                DataRow x = Personal.Rows[i];
                int Buscando = Convert.ToInt32(x["ID"]);
                if (Buscando.Equals(ID)) {
                    return x["Apellido Paterno"].ToString() + " " + x["Apellido Materno"].ToString() + " " + x["Nombre"].ToString();
                }
            }
            return "NO EXISTE";
        }

        private string ObtenerPuesto_Personal(int ID)
        {
            for (int i = 0; i < Personal?.Rows?.Count; i++) {
                DataRow x = Personal.Rows[i];
                int Buscando = Convert.ToInt32(x["ID"]);
                if (Buscando.Equals(ID)) {
                    return x["Puesto"].ToString();
                }
            }
            return "NO EXISTE";
        }

        private string ObtenerPuesto_Personal(string Nombre)
        {
            for (int i = 0; i < Personal?.Rows?.Count; i++) {
                DataRow x = Personal.Rows[i];
                string Buscando = x["Apellido Paterno"].ToString() + " " + x["Apellido Materno"].ToString() + " " + x["Nombre"].ToString();
                if (Buscando.Equals(Nombre)) {
                    return x["Puesto"].ToString();
                }
            }
            return "NO EXISTE";
        }

        private bool ExisteID(int ID)
        {
            for (int i = 0; i < Personal?.Rows?.Count; i++) {
                DataRow x = Personal.Rows[i];
                int Buscando = Convert.ToInt32(x["ID"]);
                if (Buscando.Equals(ID)) {
                    return true;
                }
            }
            return false;
        }

        private void cbNombres_TextChanged(object sender, EventArgs e)
        {
            string Nombre = (sender as Control).Text;
            string ID = ObtenerID_Personal(Nombre).ToString();
            string Puesto = ObtenerPuesto_Personal(Nombre);
            if (sender == cbNombreExpide) {
                tbIDExpide.Text = ID;
                lblPuestoExpide.Text = Puesto;
            }
            if (sender == cbNombreTrabajador) {
                tbIDTrabajador.Text = ID;
                lblPuestoTrabajador.Text = Puesto;
            }
        }

        private void tbIDs_TextChanged(object sender, EventArgs e)
        {
            int ID = 0;
            if (!string.IsNullOrWhiteSpace((sender as Control).Text))
                ID = Convert.ToInt32((sender as Control).Text);
            string
                Nombre = ObtenerNombre_Personal(ID),
                Puesto = ObtenerPuesto_Personal(ID);
            if (sender == tbIDExpide) {
                cbNombreExpide.Text = Nombre;
                lblPuestoExpide.Text = Puesto;
            }
            if (sender == tbIDTrabajador) {
                cbNombreTrabajador.Text = Nombre;
                lblPuestoTrabajador.Text = Puesto;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Puesto = lblPuestoExpide.Text;
            if (!string.IsNullOrWhiteSpace(tbIDExpide.Text) && !string.IsNullOrWhiteSpace(tbIDTrabajador.Text)) {
                if (Puesto.Contains("JEFE") || Puesto.Contains("SUBDIRECTOR") || Puesto.Contains("DIRECTOR")) {
                    int Expide, Trabajador, NoOficio;
                    Expide = Convert.ToInt32(tbIDExpide.Text);
                    Trabajador = Convert.ToInt32(tbIDTrabajador.Text);
                    NoOficio = Convert.ToInt32(string.IsNullOrWhiteSpace(tbOficio.Text) ? "0" : tbOficio.Text);
                    if (Expide != 0 && Trabajador != 0) {
                        if (rbBuena.Checked) { //Nota Buena
                            if (InterfaceMySQL.NotaBuena(Expide, Trabajador, NoOficio)) {
                                MessageBox.Show("Registro Insertado con éxito", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else {
                                MessageBox.Show("Registro no insertado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else { //Nota Mala
                            if (InterfaceMySQL.NotaMala(Expide, Trabajador, NoOficio)) {
                                MessageBox.Show("Registro Insertado con éxito", "LISTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else {
                                MessageBox.Show("Registro no insertado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    } else {
                        MessageBox.Show("Verifique los ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else {
                    MessageBox.Show("No tiene los privilegios para hacer la nota", "PRIVILEGIOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Verifique los ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbIDExpide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b') {
                if (!char.IsDigit(e.KeyChar)) {
                    e.Handled = true;
                }
            }
        }
    }
}