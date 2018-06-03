namespace Tramites
{
    partial class VistaNotaMala
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
            this.vistamala = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // vistamala
            // 
            this.vistamala.ActiveViewIndex = -1;
            this.vistamala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vistamala.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.vistamala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistamala.Location = new System.Drawing.Point(0, 0);
            this.vistamala.Name = "vistamala";
            this.vistamala.ShowCloseButton = false;
            this.vistamala.ShowCopyButton = false;
            this.vistamala.ShowGroupTreeButton = false;
            this.vistamala.ShowLogo = false;
            this.vistamala.ShowParameterPanelButton = false;
            this.vistamala.ShowTextSearchButton = false;
            this.vistamala.Size = new System.Drawing.Size(759, 464);
            this.vistamala.TabIndex = 1;
            this.vistamala.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.vistamala.UseWaitCursor = true;
            // 
            // VistaNotaMala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 464);
            this.Controls.Add(this.vistamala);
            this.Name = "VistaNotaMala";
            this.Text = "VistaNotaMala";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VistaNotaMala_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer vistamala;
    }
}