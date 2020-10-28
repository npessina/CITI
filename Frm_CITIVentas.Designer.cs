namespace CITI
{
    partial class Frm_CITIVentas
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
            this.labelMes = new System.Windows.Forms.Label();
            this.seleccionMes = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.seleccion = new System.Windows.Forms.ComboBox();
            this.btnGenerarArchivo = new System.Windows.Forms.Button();
            this.tablaDatos = new System.Windows.Forms.DataGridView();
            this.IDComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipoResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtotalNoGravado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAutorizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenceCAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultadoAFIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(18, 14);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(107, 17);
            this.labelMes.TabIndex = 11;
            this.labelMes.Text = "Seleccione mes";
            // 
            // seleccionMes
            // 
            this.seleccionMes.Location = new System.Drawing.Point(131, 14);
            this.seleccionMes.Name = "seleccionMes";
            this.seleccionMes.Size = new System.Drawing.Size(200, 22);
            this.seleccionMes.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(337, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 33);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // seleccion
            // 
            this.seleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccion.FormattingEnabled = true;
            this.seleccion.Items.AddRange(new object[] {
            "CABECERA",
            "ALICUOTA IVA"});
            this.seleccion.Location = new System.Drawing.Point(492, 391);
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(121, 24);
            this.seleccion.TabIndex = 13;
            this.seleccion.SelectedIndexChanged += new System.EventHandler(this.seleccion_SelectedIndexChanged);
            // 
            // btnGenerarArchivo
            // 
            this.btnGenerarArchivo.Location = new System.Drawing.Point(632, 391);
            this.btnGenerarArchivo.Name = "btnGenerarArchivo";
            this.btnGenerarArchivo.Size = new System.Drawing.Size(150, 47);
            this.btnGenerarArchivo.TabIndex = 12;
            this.btnGenerarArchivo.Text = "Generar Archivo";
            this.btnGenerarArchivo.UseVisualStyleBackColor = true;
            this.btnGenerarArchivo.Click += new System.EventHandler(this.btnGenerarArchivo_Click);
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDComprobante,
            this.Comprobante,
            this.Tipo,
            this.Puesto,
            this.Numero,
            this.Fecha,
            this.IDCliente,
            this.Compania,
            this.IDTipoResponsable,
            this.CUIT,
            this.Calle,
            this.Ciudad,
            this.Provincia,
            this.IDVendedor,
            this.Condicion,
            this.Total,
            this.SubtotalNoGravado,
            this.Transporte,
            this.Entrega,
            this.Paquete,
            this.Observaciones,
            this.Usuario,
            this.Saldo,
            this.FechaAutorizada,
            this.Mail,
            this.CP,
            this.CAE,
            this.VenceCAE,
            this.ResultadoAFIP});
            this.tablaDatos.Location = new System.Drawing.Point(20, 90);
            this.tablaDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.RowTemplate.Height = 24;
            this.tablaDatos.Size = new System.Drawing.Size(761, 271);
            this.tablaDatos.TabIndex = 14;
            // 
            // IDComprobante
            // 
            this.IDComprobante.HeaderText = "ID Comprobante";
            this.IDComprobante.Name = "IDComprobante";
            this.IDComprobante.ReadOnly = true;
            // 
            // Comprobante
            // 
            this.Comprobante.HeaderText = "Comprobante";
            this.Comprobante.Name = "Comprobante";
            this.Comprobante.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // IDCliente
            // 
            this.IDCliente.HeaderText = "ID Cliente";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            // 
            // Compania
            // 
            this.Compania.HeaderText = "Compania";
            this.Compania.Name = "Compania";
            this.Compania.ReadOnly = true;
            // 
            // IDTipoResponsable
            // 
            this.IDTipoResponsable.HeaderText = "ID Tipo Responsable";
            this.IDTipoResponsable.Name = "IDTipoResponsable";
            this.IDTipoResponsable.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // IDVendedor
            // 
            this.IDVendedor.HeaderText = "ID Vendedor";
            this.IDVendedor.Name = "IDVendedor";
            this.IDVendedor.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // SubtotalNoGravado
            // 
            this.SubtotalNoGravado.HeaderText = "Subtotal No Gravado";
            this.SubtotalNoGravado.Name = "SubtotalNoGravado";
            this.SubtotalNoGravado.ReadOnly = true;
            // 
            // Transporte
            // 
            this.Transporte.HeaderText = "Transporte";
            this.Transporte.Name = "Transporte";
            this.Transporte.ReadOnly = true;
            // 
            // Entrega
            // 
            this.Entrega.HeaderText = "Entrega";
            this.Entrega.Name = "Entrega";
            this.Entrega.ReadOnly = true;
            // 
            // Paquete
            // 
            this.Paquete.HeaderText = "Paquete";
            this.Paquete.Name = "Paquete";
            this.Paquete.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // FechaAutorizada
            // 
            this.FechaAutorizada.HeaderText = "Fecha Autorizada";
            this.FechaAutorizada.Name = "FechaAutorizada";
            this.FechaAutorizada.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // CP
            // 
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            // 
            // CAE
            // 
            this.CAE.HeaderText = "CAE";
            this.CAE.Name = "CAE";
            this.CAE.ReadOnly = true;
            // 
            // VenceCAE
            // 
            this.VenceCAE.HeaderText = "Vence CAE";
            this.VenceCAE.Name = "VenceCAE";
            this.VenceCAE.ReadOnly = true;
            // 
            // ResultadoAFIP
            // 
            this.ResultadoAFIP.HeaderText = "ResultadoAFIP";
            this.ResultadoAFIP.Name = "ResultadoAFIP";
            this.ResultadoAFIP.ReadOnly = true;
            // 
            // Frm_CITIVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.seleccion);
            this.Controls.Add(this.btnGenerarArchivo);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.seleccionMes);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Frm_CITIVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CITI Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.DateTimePicker seleccionMes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox seleccion;
        private System.Windows.Forms.Button btnGenerarArchivo;
        private System.Windows.Forms.DataGridView tablaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipoResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtotalNoGravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAutorizada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenceCAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultadoAFIP;
    }
}