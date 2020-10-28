namespace CITI
{
    partial class Frm_TipoComprobantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoCodigo = new System.Windows.Forms.TextBox();
            this.campoDescripcion = new System.Windows.Forms.TextBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.bajaCheck = new System.Windows.Forms.CheckBox();
            this.tablaTipoComprobante = new System.Windows.Forms.DataGridView();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonAlta = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoComprobante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPCIÓN";
            // 
            // campoCodigo
            // 
            this.campoCodigo.Enabled = false;
            this.campoCodigo.Location = new System.Drawing.Point(140, 67);
            this.campoCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(80, 20);
            this.campoCodigo.TabIndex = 2;
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.Enabled = false;
            this.campoDescripcion.Location = new System.Drawing.Point(140, 141);
            this.campoDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(356, 20);
            this.campoDescripcion.TabIndex = 3;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(545, 141);
            this.botonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(105, 42);
            this.botonAceptar.TabIndex = 4;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Visible = false;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // bajaCheck
            // 
            this.bajaCheck.AutoSize = true;
            this.bajaCheck.Enabled = false;
            this.bajaCheck.Location = new System.Drawing.Point(440, 64);
            this.bajaCheck.Margin = new System.Windows.Forms.Padding(2);
            this.bajaCheck.Name = "bajaCheck";
            this.bajaCheck.Size = new System.Drawing.Size(52, 17);
            this.bajaCheck.TabIndex = 5;
            this.bajaCheck.Text = "BAJA";
            this.bajaCheck.UseVisualStyleBackColor = true;
            // 
            // tablaTipoComprobante
            // 
            this.tablaTipoComprobante.AllowUserToAddRows = false;
            this.tablaTipoComprobante.AllowUserToDeleteRows = false;
            this.tablaTipoComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTipoComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTipoComprobante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Baja});
            this.tablaTipoComprobante.Location = new System.Drawing.Point(26, 188);
            this.tablaTipoComprobante.Margin = new System.Windows.Forms.Padding(2);
            this.tablaTipoComprobante.Name = "tablaTipoComprobante";
            this.tablaTipoComprobante.ReadOnly = true;
            this.tablaTipoComprobante.RowTemplate.Height = 24;
            this.tablaTipoComprobante.Size = new System.Drawing.Size(742, 219);
            this.tablaTipoComprobante.TabIndex = 6;
            this.tablaTipoComprobante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTipoComprobante_CellClick);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(685, 141);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(105, 42);
            this.botonCancelar.TabIndex = 7;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Visible = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(611, 17);
            this.botonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(105, 42);
            this.botonEditar.TabIndex = 8;
            this.botonEditar.Text = "EDITAR";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(611, 80);
            this.botonAlta.Margin = new System.Windows.Forms.Padding(2);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(105, 42);
            this.botonAlta.TabIndex = 9;
            this.botonAlta.Text = "ALTA";
            this.botonAlta.UseVisualStyleBackColor = true;
            this.botonAlta.Click += new System.EventHandler(this.botonAlta_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            this.Baja.ReadOnly = true;
            // 
            // Frm_TipoComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.botonAlta);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.tablaTipoComprobante);
            this.Controls.Add(this.bajaCheck);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.campoCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_TipoComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Tipo Comprobante";
            this.Load += new System.EventHandler(this.Frm_TipoComprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTipoComprobante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoCodigo;
        private System.Windows.Forms.TextBox campoDescripcion;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.CheckBox bajaCheck;
        private System.Windows.Forms.DataGridView tablaTipoComprobante;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baja;
    }
}