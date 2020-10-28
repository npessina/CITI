﻿namespace CITI
{
    partial class Frm_Moneda
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
            this.botonAlta = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.tablaMoneda = new System.Windows.Forms.DataGridView();
            this.bajaCheck = new System.Windows.Forms.CheckBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.campoMoneda = new System.Windows.Forms.TextBox();
            this.campoCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // botonAlta
            // 
            this.botonAlta.Location = new System.Drawing.Point(622, 101);
            this.botonAlta.Margin = new System.Windows.Forms.Padding(2);
            this.botonAlta.Name = "botonAlta";
            this.botonAlta.Size = new System.Drawing.Size(105, 42);
            this.botonAlta.TabIndex = 19;
            this.botonAlta.Text = "ALTA";
            this.botonAlta.UseVisualStyleBackColor = true;
            this.botonAlta.Click += new System.EventHandler(this.botonAlta_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(622, 37);
            this.botonEditar.Margin = new System.Windows.Forms.Padding(2);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(105, 42);
            this.botonEditar.TabIndex = 18;
            this.botonEditar.Text = "EDITAR";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(695, 162);
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(105, 42);
            this.botonCancelar.TabIndex = 17;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Visible = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // tablaMoneda
            // 
            this.tablaMoneda.AllowUserToAddRows = false;
            this.tablaMoneda.AllowUserToDeleteRows = false;
            this.tablaMoneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Moneda,
            this.Baja});
            this.tablaMoneda.Location = new System.Drawing.Point(37, 209);
            this.tablaMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.tablaMoneda.Name = "tablaMoneda";
            this.tablaMoneda.ReadOnly = true;
            this.tablaMoneda.RowTemplate.Height = 24;
            this.tablaMoneda.Size = new System.Drawing.Size(742, 219);
            this.tablaMoneda.TabIndex = 16;
            this.tablaMoneda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMoneda_CellClick);
            // 
            // bajaCheck
            // 
            this.bajaCheck.AutoSize = true;
            this.bajaCheck.Enabled = false;
            this.bajaCheck.Location = new System.Drawing.Point(451, 84);
            this.bajaCheck.Margin = new System.Windows.Forms.Padding(2);
            this.bajaCheck.Name = "bajaCheck";
            this.bajaCheck.Size = new System.Drawing.Size(52, 17);
            this.bajaCheck.TabIndex = 15;
            this.bajaCheck.Text = "BAJA";
            this.bajaCheck.UseVisualStyleBackColor = true;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(556, 162);
            this.botonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(105, 42);
            this.botonAceptar.TabIndex = 14;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Visible = false;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // campoMoneda
            // 
            this.campoMoneda.Enabled = false;
            this.campoMoneda.Location = new System.Drawing.Point(151, 162);
            this.campoMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.campoMoneda.Name = "campoMoneda";
            this.campoMoneda.Size = new System.Drawing.Size(356, 20);
            this.campoMoneda.TabIndex = 13;
            // 
            // campoCodigo
            // 
            this.campoCodigo.Enabled = false;
            this.campoCodigo.Location = new System.Drawing.Point(151, 88);
            this.campoCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(80, 20);
            this.campoCodigo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MONEDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CODIGO";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            this.Baja.ReadOnly = true;
            // 
            // Frm_Moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 465);
            this.Controls.Add(this.botonAlta);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.tablaMoneda);
            this.Controls.Add(this.bajaCheck);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.campoMoneda);
            this.Controls.Add(this.campoCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Moneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Moneda";
            this.Load += new System.EventHandler(this.Frm_Moneda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMoneda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonAlta;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.DataGridView tablaMoneda;
        private System.Windows.Forms.CheckBox bajaCheck;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox campoMoneda;
        private System.Windows.Forms.TextBox campoCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baja;
    }
}