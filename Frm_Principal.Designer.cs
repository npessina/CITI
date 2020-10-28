namespace CITI
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cITIComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCITIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cITIVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarCITIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoDeOperaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.condiciónIVAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoIDCompradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(625, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cITIComprasToolStripMenuItem,
            this.cITIVentasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.archivoToolStripMenuItem.Text = "Inicio";
            // 
            // cITIComprasToolStripMenuItem
            // 
            this.cITIComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarCITIToolStripMenuItem});
            this.cITIComprasToolStripMenuItem.Name = "cITIComprasToolStripMenuItem";
            this.cITIComprasToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.cITIComprasToolStripMenuItem.Text = "Compras";
            // 
            // generarCITIToolStripMenuItem
            // 
            this.generarCITIToolStripMenuItem.Name = "generarCITIToolStripMenuItem";
            this.generarCITIToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.generarCITIToolStripMenuItem.Text = "Generar CITI";
            this.generarCITIToolStripMenuItem.Click += new System.EventHandler(this.generarCITIToolStripMenuItem_Click);
            // 
            // cITIVentasToolStripMenuItem
            // 
            this.cITIVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarCITIToolStripMenuItem1});
            this.cITIVentasToolStripMenuItem.Name = "cITIVentasToolStripMenuItem";
            this.cITIVentasToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.cITIVentasToolStripMenuItem.Text = "Ventas";
            // 
            // generarCITIToolStripMenuItem1
            // 
            this.generarCITIToolStripMenuItem1.Name = "generarCITIToolStripMenuItem1";
            this.generarCITIToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.generarCITIToolStripMenuItem1.Text = "Generar CITI";
            this.generarCITIToolStripMenuItem1.Click += new System.EventHandler(this.generarCITIToolStripMenuItem1_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoComprobantesToolStripMenuItem,
            this.códigoDeOperaciónToolStripMenuItem,
            this.condiciónIVAToolStripMenuItem,
            this.documentoIDCompradorToolStripMenuItem,
            this.monedaToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // tipoComprobantesToolStripMenuItem
            // 
            this.tipoComprobantesToolStripMenuItem.Name = "tipoComprobantesToolStripMenuItem";
            this.tipoComprobantesToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.tipoComprobantesToolStripMenuItem.Text = "Tipo Comprobantes";
            this.tipoComprobantesToolStripMenuItem.Click += new System.EventHandler(this.tipoComprobantesToolStripMenuItem_Click);
            // 
            // códigoDeOperaciónToolStripMenuItem
            // 
            this.códigoDeOperaciónToolStripMenuItem.Name = "códigoDeOperaciónToolStripMenuItem";
            this.códigoDeOperaciónToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.códigoDeOperaciónToolStripMenuItem.Text = "Código de operación";
            this.códigoDeOperaciónToolStripMenuItem.Click += new System.EventHandler(this.códigoDeOperaciónToolStripMenuItem_Click);
            // 
            // condiciónIVAToolStripMenuItem
            // 
            this.condiciónIVAToolStripMenuItem.Name = "condiciónIVAToolStripMenuItem";
            this.condiciónIVAToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.condiciónIVAToolStripMenuItem.Text = "Condición IVA";
            this.condiciónIVAToolStripMenuItem.Click += new System.EventHandler(this.condiciónIVAToolStripMenuItem_Click);
            // 
            // documentoIDCompradorToolStripMenuItem
            // 
            this.documentoIDCompradorToolStripMenuItem.Name = "documentoIDCompradorToolStripMenuItem";
            this.documentoIDCompradorToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.documentoIDCompradorToolStripMenuItem.Text = "Documento ID Comprador";
            this.documentoIDCompradorToolStripMenuItem.Click += new System.EventHandler(this.documentoIDCompradorToolStripMenuItem_Click);
            // 
            // monedaToolStripMenuItem
            // 
            this.monedaToolStripMenuItem.Name = "monedaToolStripMenuItem";
            this.monedaToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.monedaToolStripMenuItem.Text = "Moneda";
            this.monedaToolStripMenuItem.Click += new System.EventHandler(this.monedaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(625, 321);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CITI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cITIComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cITIVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarCITIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarCITIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoComprobantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoDeOperaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem condiciónIVAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoIDCompradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedaToolStripMenuItem;
    }
}

