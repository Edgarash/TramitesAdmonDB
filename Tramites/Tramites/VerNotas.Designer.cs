namespace Tramites
{
    partial class VerNotas
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
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.rbBuena = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.gbNotas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvNotas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnImprimir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVer, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 322);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbNotas
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbNotas, 2);
            this.gbNotas.Controls.Add(this.rbBuena);
            this.gbNotas.Controls.Add(this.rbMala);
            this.gbNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNotas.Location = new System.Drawing.Point(3, 3);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Size = new System.Drawing.Size(478, 44);
            this.gbNotas.TabIndex = 7;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Tipo de Nota:";
            // 
            // rbBuena
            // 
            this.rbBuena.AutoSize = true;
            this.rbBuena.Checked = true;
            this.rbBuena.Location = new System.Drawing.Point(115, 16);
            this.rbBuena.Name = "rbBuena";
            this.rbBuena.Size = new System.Drawing.Size(92, 17);
            this.rbBuena.TabIndex = 0;
            this.rbBuena.TabStop = true;
            this.rbBuena.Text = "Notas Buenas";
            this.rbBuena.UseVisualStyleBackColor = true;
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Location = new System.Drawing.Point(275, 16);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(84, 17);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Notas Malas";
            this.rbMala.UseVisualStyleBackColor = true;
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AllowUserToResizeRows = false;
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotas.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvNotas, 3);
            this.dgvNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotas.GridColor = System.Drawing.Color.Black;
            this.dgvNotas.Location = new System.Drawing.Point(3, 53);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dgvNotas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvNotas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(721, 216);
            this.dgvNotas.TabIndex = 0;
            this.dgvNotas.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::Tramites.Properties.Resources.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(245, 275);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(236, 44);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Transparent;
            this.btnVer.BackgroundImage = global::Tramites.Properties.Resources.if_Search_858732;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVer.ForeColor = System.Drawing.Color.Black;
            this.btnVer.Location = new System.Drawing.Point(487, 3);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(220, 44);
            this.btnVer.TabIndex = 8;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // VerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VerNotas";
            this.Text = "VerNotas";
            this.Load += new System.EventHandler(this.VerNotas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbNotas.ResumeLayout(false);
            this.gbNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.RadioButton rbBuena;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.Button btnVer;
    }
}