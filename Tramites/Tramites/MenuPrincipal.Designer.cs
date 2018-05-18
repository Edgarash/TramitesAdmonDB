using System.Windows.Forms;

namespace Tramites
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnTramites = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPersonal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTramites, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDepartamentos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 318);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Tramites.Properties.Resources.icons8_test_parcial_aprobado_642;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(249, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 141);
            this.button1.TabIndex = 2;
            this.button1.Text = "Notas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AgregarNota_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.BackgroundImage = global::Tramites.Properties.Resources.personal;
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonal.Location = new System.Drawing.Point(55, 14);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(130, 130);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.Click += new System.EventHandler(this.AbrirCatalogo);
            // 
            // btnTramites
            // 
            this.btnTramites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTramites.BackColor = System.Drawing.Color.Transparent;
            this.btnTramites.BackgroundImage = global::Tramites.Properties.Resources.tramites;
            this.btnTramites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTramites.FlatAppearance.BorderSize = 0;
            this.btnTramites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTramites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTramites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTramites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTramites.ForeColor = System.Drawing.Color.White;
            this.btnTramites.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTramites.Location = new System.Drawing.Point(302, 22);
            this.btnTramites.Margin = new System.Windows.Forms.Padding(2);
            this.btnTramites.Name = "btnTramites";
            this.btnTramites.Size = new System.Drawing.Size(115, 114);
            this.btnTramites.TabIndex = 1;
            this.btnTramites.Text = "Tramites";
            this.btnTramites.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTramites.UseVisualStyleBackColor = false;
            this.btnTramites.Click += new System.EventHandler(this.AbrirCatalogo);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDepartamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnDepartamentos.BackgroundImage = global::Tramites.Properties.Resources.departamento;
            this.btnDepartamentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDepartamentos.FlatAppearance.BorderSize = 0;
            this.btnDepartamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDepartamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamentos.ForeColor = System.Drawing.Color.White;
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentos.Location = new System.Drawing.Point(9, 168);
            this.btnDepartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(222, 141);
            this.btnDepartamentos.TabIndex = 1;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentos.UseVisualStyleBackColor = false;
            this.btnDepartamentos.Click += new System.EventHandler(this.AbrirCatalogo);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(480, 318);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Button btnPersonal;
        private Button btnTramites;
        private Button btnDepartamentos;
        private Button button1;
    }
}