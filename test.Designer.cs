namespace CITI
{
    partial class test
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
            this.txtIVAVentas = new System.Windows.Forms.TextBox();
            this.txtTablaVentas = new System.Windows.Forms.TextBox();
            this.txtIVACompras = new System.Windows.Forms.TextBox();
            this.txtNombreDB = new System.Windows.Forms.TextBox();
            this.txtTablaCompras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIVAVentas
            // 
            this.txtIVAVentas.Location = new System.Drawing.Point(155, 172);
            this.txtIVAVentas.Name = "txtIVAVentas";
            this.txtIVAVentas.Size = new System.Drawing.Size(100, 20);
            this.txtIVAVentas.TabIndex = 0;
            // 
            // txtTablaVentas
            // 
            this.txtTablaVentas.Location = new System.Drawing.Point(155, 120);
            this.txtTablaVentas.Name = "txtTablaVentas";
            this.txtTablaVentas.Size = new System.Drawing.Size(100, 20);
            this.txtTablaVentas.TabIndex = 1;
            // 
            // txtIVACompras
            // 
            this.txtIVACompras.Location = new System.Drawing.Point(155, 146);
            this.txtIVACompras.Name = "txtIVACompras";
            this.txtIVACompras.Size = new System.Drawing.Size(100, 20);
            this.txtIVACompras.TabIndex = 2;
            // 
            // txtNombreDB
            // 
            this.txtNombreDB.Location = new System.Drawing.Point(155, 68);
            this.txtNombreDB.Name = "txtNombreDB";
            this.txtNombreDB.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDB.TabIndex = 3;
            // 
            // txtTablaCompras
            // 
            this.txtTablaCompras.Location = new System.Drawing.Point(155, 94);
            this.txtTablaCompras.Name = "txtTablaCompras";
            this.txtTablaCompras.Size = new System.Drawing.Size(100, 20);
            this.txtTablaCompras.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre DB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabla Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tabla Ventas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "IVA Compras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IVA Ventas";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(306, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(76, 213);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTablaCompras);
            this.Controls.Add(this.txtNombreDB);
            this.Controls.Add(this.txtIVACompras);
            this.Controls.Add(this.txtTablaVentas);
            this.Controls.Add(this.txtIVAVentas);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIVAVentas;
        private System.Windows.Forms.TextBox txtTablaVentas;
        private System.Windows.Forms.TextBox txtIVACompras;
        private System.Windows.Forms.TextBox txtNombreDB;
        private System.Windows.Forms.TextBox txtTablaCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnTest;
    }
}