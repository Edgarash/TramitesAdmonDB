namespace Tramites
{
    partial class FormNotas
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
            this.Contenedor = new System.Windows.Forms.TableLayoutPanel();
            this.gbTrabajador = new System.Windows.Forms.GroupBox();
            this.ContenedorTrabajador = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDTrabajador = new System.Windows.Forms.Label();
            this.lblNombreTrabajador = new System.Windows.Forms.Label();
            this.cbNombreTrabajador = new System.Windows.Forms.ComboBox();
            this.tbIDTrabajador = new System.Windows.Forms.TextBox();
            this.labelPuestoTrabajador = new System.Windows.Forms.Label();
            this.lblPuestoTrabajador = new System.Windows.Forms.Label();
            this.lblOficio = new System.Windows.Forms.Label();
            this.tbOficio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbExpide = new System.Windows.Forms.GroupBox();
            this.ContenedorExpide = new System.Windows.Forms.TableLayoutPanel();
            this.lblIDExpide = new System.Windows.Forms.Label();
            this.lblNombreExpide = new System.Windows.Forms.Label();
            this.cbNombreExpide = new System.Windows.Forms.ComboBox();
            this.tbIDExpide = new System.Windows.Forms.TextBox();
            this.labelPuestoExpide = new System.Windows.Forms.Label();
            this.lblPuestoExpide = new System.Windows.Forms.Label();
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.ContenedorNotas = new System.Windows.Forms.TableLayoutPanel();
            this.rbBuena = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.Contenedor.SuspendLayout();
            this.gbTrabajador.SuspendLayout();
            this.ContenedorTrabajador.SuspendLayout();
            this.gbExpide.SuspendLayout();
            this.ContenedorExpide.SuspendLayout();
            this.gbNotas.SuspendLayout();
            this.ContenedorNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.ColumnCount = 2;
            this.Contenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Contenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Contenedor.Controls.Add(this.gbTrabajador, 0, 2);
            this.Contenedor.Controls.Add(this.gbExpide, 0, 1);
            this.Contenedor.Controls.Add(this.gbNotas, 0, 0);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.RowCount = 3;
            this.Contenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.Contenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.Contenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.Contenedor.Size = new System.Drawing.Size(482, 474);
            this.Contenedor.TabIndex = 0;
            // 
            // gbTrabajador
            // 
            this.Contenedor.SetColumnSpan(this.gbTrabajador, 100);
            this.gbTrabajador.Controls.Add(this.ContenedorTrabajador);
            this.gbTrabajador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTrabajador.Location = new System.Drawing.Point(4, 190);
            this.gbTrabajador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTrabajador.Name = "gbTrabajador";
            this.gbTrabajador.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTrabajador.Size = new System.Drawing.Size(474, 279);
            this.gbTrabajador.TabIndex = 4;
            this.gbTrabajador.TabStop = false;
            this.gbTrabajador.Text = "A Trabajador:";
            // 
            // ContenedorTrabajador
            // 
            this.ContenedorTrabajador.ColumnCount = 4;
            this.ContenedorTrabajador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.ContenedorTrabajador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContenedorTrabajador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ContenedorTrabajador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContenedorTrabajador.Controls.Add(this.lblIDTrabajador, 0, 0);
            this.ContenedorTrabajador.Controls.Add(this.lblNombreTrabajador, 1, 0);
            this.ContenedorTrabajador.Controls.Add(this.cbNombreTrabajador, 1, 1);
            this.ContenedorTrabajador.Controls.Add(this.tbIDTrabajador, 0, 1);
            this.ContenedorTrabajador.Controls.Add(this.labelPuestoTrabajador, 2, 0);
            this.ContenedorTrabajador.Controls.Add(this.lblPuestoTrabajador, 2, 1);
            this.ContenedorTrabajador.Controls.Add(this.lblOficio, 0, 3);
            this.ContenedorTrabajador.Controls.Add(this.tbOficio, 1, 3);
            this.ContenedorTrabajador.Controls.Add(this.btnAceptar, 0, 4);
            this.ContenedorTrabajador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorTrabajador.Location = new System.Drawing.Point(4, 24);
            this.ContenedorTrabajador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContenedorTrabajador.Name = "ContenedorTrabajador";
            this.ContenedorTrabajador.RowCount = 5;
            this.ContenedorTrabajador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.ContenedorTrabajador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.ContenedorTrabajador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.ContenedorTrabajador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.ContenedorTrabajador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ContenedorTrabajador.Size = new System.Drawing.Size(466, 250);
            this.ContenedorTrabajador.TabIndex = 0;
            // 
            // lblIDTrabajador
            // 
            this.lblIDTrabajador.AutoSize = true;
            this.lblIDTrabajador.Location = new System.Drawing.Point(4, 0);
            this.lblIDTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDTrabajador.Name = "lblIDTrabajador";
            this.lblIDTrabajador.Size = new System.Drawing.Size(30, 20);
            this.lblIDTrabajador.TabIndex = 0;
            this.lblIDTrabajador.Text = "ID:";
            // 
            // lblNombreTrabajador
            // 
            this.lblNombreTrabajador.AutoSize = true;
            this.lblNombreTrabajador.Location = new System.Drawing.Point(86, 0);
            this.lblNombreTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreTrabajador.Name = "lblNombreTrabajador";
            this.lblNombreTrabajador.Size = new System.Drawing.Size(69, 20);
            this.lblNombreTrabajador.TabIndex = 1;
            this.lblNombreTrabajador.Text = "Nombre:";
            // 
            // cbNombreTrabajador
            // 
            this.cbNombreTrabajador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNombreTrabajador.FormattingEnabled = true;
            this.cbNombreTrabajador.Location = new System.Drawing.Point(86, 28);
            this.cbNombreTrabajador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNombreTrabajador.Name = "cbNombreTrabajador";
            this.cbNombreTrabajador.Size = new System.Drawing.Size(196, 28);
            this.cbNombreTrabajador.TabIndex = 3;
            this.cbNombreTrabajador.TextChanged += new System.EventHandler(this.cbNombres_TextChanged);
            // 
            // tbIDTrabajador
            // 
            this.tbIDTrabajador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIDTrabajador.Location = new System.Drawing.Point(4, 28);
            this.tbIDTrabajador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIDTrabajador.MaxLength = 5;
            this.tbIDTrabajador.Name = "tbIDTrabajador";
            this.tbIDTrabajador.Size = new System.Drawing.Size(74, 26);
            this.tbIDTrabajador.TabIndex = 2;
            this.tbIDTrabajador.TextChanged += new System.EventHandler(this.tbIDs_TextChanged);
            this.tbIDTrabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDExpide_KeyPress);
            // 
            // labelPuestoTrabajador
            // 
            this.labelPuestoTrabajador.AutoSize = true;
            this.labelPuestoTrabajador.Location = new System.Drawing.Point(290, 0);
            this.labelPuestoTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuestoTrabajador.Name = "labelPuestoTrabajador";
            this.labelPuestoTrabajador.Size = new System.Drawing.Size(63, 20);
            this.labelPuestoTrabajador.TabIndex = 1;
            this.labelPuestoTrabajador.Text = "Puesto:";
            // 
            // lblPuestoTrabajador
            // 
            this.lblPuestoTrabajador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPuestoTrabajador.AutoSize = true;
            this.lblPuestoTrabajador.Location = new System.Drawing.Point(290, 32);
            this.lblPuestoTrabajador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuestoTrabajador.Name = "lblPuestoTrabajador";
            this.lblPuestoTrabajador.Size = new System.Drawing.Size(0, 20);
            this.lblPuestoTrabajador.TabIndex = 1;
            // 
            // lblOficio
            // 
            this.lblOficio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOficio.AutoSize = true;
            this.lblOficio.Location = new System.Drawing.Point(4, 94);
            this.lblOficio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(66, 20);
            this.lblOficio.TabIndex = 4;
            this.lblOficio.Text = "# Oficio:";
            // 
            // tbOficio
            // 
            this.tbOficio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbOficio.Location = new System.Drawing.Point(86, 91);
            this.tbOficio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbOficio.MaxLength = 5;
            this.tbOficio.Name = "tbOficio";
            this.tbOficio.Size = new System.Drawing.Size(73, 26);
            this.tbOficio.TabIndex = 5;
            this.tbOficio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDExpide_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.BackgroundImage = global::Tramites.Properties.Resources.icons8_comprobado_90;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContenedorTrabajador.SetColumnSpan(this.btnAceptar, 100);
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(366, 147);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 98);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbExpide
            // 
            this.Contenedor.SetColumnSpan(this.gbExpide, 100);
            this.gbExpide.Controls.Add(this.ContenedorExpide);
            this.gbExpide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbExpide.Location = new System.Drawing.Point(4, 82);
            this.gbExpide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbExpide.Name = "gbExpide";
            this.gbExpide.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbExpide.Size = new System.Drawing.Size(474, 98);
            this.gbExpide.TabIndex = 3;
            this.gbExpide.TabStop = false;
            this.gbExpide.Text = "Expide:";
            // 
            // ContenedorExpide
            // 
            this.ContenedorExpide.ColumnCount = 4;
            this.ContenedorExpide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.ContenedorExpide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContenedorExpide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ContenedorExpide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ContenedorExpide.Controls.Add(this.lblIDExpide, 0, 0);
            this.ContenedorExpide.Controls.Add(this.lblNombreExpide, 1, 0);
            this.ContenedorExpide.Controls.Add(this.cbNombreExpide, 1, 1);
            this.ContenedorExpide.Controls.Add(this.tbIDExpide, 0, 1);
            this.ContenedorExpide.Controls.Add(this.labelPuestoExpide, 2, 0);
            this.ContenedorExpide.Controls.Add(this.lblPuestoExpide, 2, 1);
            this.ContenedorExpide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorExpide.Location = new System.Drawing.Point(4, 24);
            this.ContenedorExpide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContenedorExpide.Name = "ContenedorExpide";
            this.ContenedorExpide.RowCount = 2;
            this.ContenedorExpide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.ContenedorExpide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.ContenedorExpide.Size = new System.Drawing.Size(466, 69);
            this.ContenedorExpide.TabIndex = 0;
            // 
            // lblIDExpide
            // 
            this.lblIDExpide.AutoSize = true;
            this.lblIDExpide.Location = new System.Drawing.Point(4, 0);
            this.lblIDExpide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDExpide.Name = "lblIDExpide";
            this.lblIDExpide.Size = new System.Drawing.Size(30, 20);
            this.lblIDExpide.TabIndex = 0;
            this.lblIDExpide.Text = "ID:";
            // 
            // lblNombreExpide
            // 
            this.lblNombreExpide.AutoSize = true;
            this.lblNombreExpide.Location = new System.Drawing.Point(86, 0);
            this.lblNombreExpide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreExpide.Name = "lblNombreExpide";
            this.lblNombreExpide.Size = new System.Drawing.Size(69, 20);
            this.lblNombreExpide.TabIndex = 1;
            this.lblNombreExpide.Text = "Nombre:";
            // 
            // cbNombreExpide
            // 
            this.cbNombreExpide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNombreExpide.FormattingEnabled = true;
            this.cbNombreExpide.Location = new System.Drawing.Point(86, 28);
            this.cbNombreExpide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNombreExpide.Name = "cbNombreExpide";
            this.cbNombreExpide.Size = new System.Drawing.Size(196, 28);
            this.cbNombreExpide.TabIndex = 3;
            this.cbNombreExpide.TextChanged += new System.EventHandler(this.cbNombres_TextChanged);
            // 
            // tbIDExpide
            // 
            this.tbIDExpide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIDExpide.Location = new System.Drawing.Point(4, 28);
            this.tbIDExpide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIDExpide.MaxLength = 5;
            this.tbIDExpide.Name = "tbIDExpide";
            this.tbIDExpide.Size = new System.Drawing.Size(74, 26);
            this.tbIDExpide.TabIndex = 2;
            this.tbIDExpide.TextChanged += new System.EventHandler(this.tbIDs_TextChanged);
            this.tbIDExpide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIDExpide_KeyPress);
            // 
            // labelPuestoExpide
            // 
            this.labelPuestoExpide.AutoSize = true;
            this.labelPuestoExpide.Location = new System.Drawing.Point(290, 0);
            this.labelPuestoExpide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPuestoExpide.Name = "labelPuestoExpide";
            this.labelPuestoExpide.Size = new System.Drawing.Size(63, 20);
            this.labelPuestoExpide.TabIndex = 1;
            this.labelPuestoExpide.Text = "Puesto:";
            // 
            // lblPuestoExpide
            // 
            this.lblPuestoExpide.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPuestoExpide.AutoSize = true;
            this.lblPuestoExpide.Location = new System.Drawing.Point(290, 36);
            this.lblPuestoExpide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuestoExpide.Name = "lblPuestoExpide";
            this.lblPuestoExpide.Size = new System.Drawing.Size(0, 20);
            this.lblPuestoExpide.TabIndex = 1;
            // 
            // gbNotas
            // 
            this.Contenedor.SetColumnSpan(this.gbNotas, 100);
            this.gbNotas.Controls.Add(this.ContenedorNotas);
            this.gbNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNotas.Location = new System.Drawing.Point(4, 5);
            this.gbNotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNotas.Size = new System.Drawing.Size(474, 67);
            this.gbNotas.TabIndex = 1;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Tipo de Nota:";
            // 
            // ContenedorNotas
            // 
            this.ContenedorNotas.ColumnCount = 3;
            this.ContenedorNotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ContenedorNotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ContenedorNotas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContenedorNotas.Controls.Add(this.rbBuena, 0, 0);
            this.ContenedorNotas.Controls.Add(this.rbMala, 1, 0);
            this.ContenedorNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorNotas.Location = new System.Drawing.Point(4, 24);
            this.ContenedorNotas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContenedorNotas.Name = "ContenedorNotas";
            this.ContenedorNotas.RowCount = 1;
            this.ContenedorNotas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContenedorNotas.Size = new System.Drawing.Size(466, 38);
            this.ContenedorNotas.TabIndex = 0;
            // 
            // rbBuena
            // 
            this.rbBuena.AutoSize = true;
            this.rbBuena.Checked = true;
            this.rbBuena.Location = new System.Drawing.Point(4, 5);
            this.rbBuena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbBuena.Name = "rbBuena";
            this.rbBuena.Size = new System.Drawing.Size(112, 24);
            this.rbBuena.TabIndex = 0;
            this.rbBuena.TabStop = true;
            this.rbBuena.Text = "Nota Buena";
            this.rbBuena.UseVisualStyleBackColor = true;
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Location = new System.Drawing.Point(154, 5);
            this.rbMala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(99, 24);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Nota Mala";
            this.rbMala.UseVisualStyleBackColor = true;
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 474);
            this.Controls.Add(this.Contenedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1138, 513);
            this.MinimumSize = new System.Drawing.Size(498, 513);
            this.Name = "FormNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Contenedor.ResumeLayout(false);
            this.gbTrabajador.ResumeLayout(false);
            this.ContenedorTrabajador.ResumeLayout(false);
            this.ContenedorTrabajador.PerformLayout();
            this.gbExpide.ResumeLayout(false);
            this.ContenedorExpide.ResumeLayout(false);
            this.ContenedorExpide.PerformLayout();
            this.gbNotas.ResumeLayout(false);
            this.ContenedorNotas.ResumeLayout(false);
            this.ContenedorNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Contenedor;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.TableLayoutPanel ContenedorNotas;
        private System.Windows.Forms.RadioButton rbBuena;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.GroupBox gbExpide;
        private System.Windows.Forms.TableLayoutPanel ContenedorExpide;
        private System.Windows.Forms.Label lblIDExpide;
        private System.Windows.Forms.Label lblNombreExpide;
        private System.Windows.Forms.TextBox tbIDExpide;
        private System.Windows.Forms.ComboBox cbNombreExpide;
        private System.Windows.Forms.GroupBox gbTrabajador;
        private System.Windows.Forms.TableLayoutPanel ContenedorTrabajador;
        private System.Windows.Forms.Label lblIDTrabajador;
        private System.Windows.Forms.Label lblNombreTrabajador;
        private System.Windows.Forms.ComboBox cbNombreTrabajador;
        private System.Windows.Forms.TextBox tbIDTrabajador;
        private System.Windows.Forms.Label labelPuestoExpide;
        private System.Windows.Forms.Label lblPuestoExpide;
        private System.Windows.Forms.Label labelPuestoTrabajador;
        private System.Windows.Forms.Label lblPuestoTrabajador;
        private System.Windows.Forms.Label lblOficio;
        private System.Windows.Forms.TextBox tbOficio;
        private System.Windows.Forms.Button btnAceptar;
    }
}