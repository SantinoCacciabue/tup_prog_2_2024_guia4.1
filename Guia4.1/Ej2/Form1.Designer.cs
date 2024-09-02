namespace Ej2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBcodigo = new System.Windows.Forms.TextBox();
            this.bVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBcostos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBdetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bAgregarCosto = new System.Windows.Forms.Button();
            this.bGuardarEnvio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBlista = new System.Windows.Forms.TextBox();
            this.bListar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bVer);
            this.groupBox1.Controls.Add(this.tBcodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver/Cargar envío";
            // 
            // tBcodigo
            // 
            this.tBcodigo.Location = new System.Drawing.Point(9, 44);
            this.tBcodigo.Name = "tBcodigo";
            this.tBcodigo.Size = new System.Drawing.Size(120, 20);
            this.tBcodigo.TabIndex = 0;
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(203, 44);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(75, 36);
            this.bVer.TabIndex = 1;
            this.bVer.Text = "Ver/Cargar envío";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código aduanero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa de transporte: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bGuardarEnvio);
            this.groupBox2.Controls.Add(this.bAgregarCosto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tBdetalle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cBcostos);
            this.groupBox2.Location = new System.Drawing.Point(13, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edición de costos";
            // 
            // cBcostos
            // 
            this.cBcostos.FormattingEnabled = true;
            this.cBcostos.Location = new System.Drawing.Point(12, 41);
            this.cBcostos.Name = "cBcostos";
            this.cBcostos.Size = new System.Drawing.Size(194, 21);
            this.cBcostos.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costos";
            // 
            // tBdetalle
            // 
            this.tBdetalle.Location = new System.Drawing.Point(12, 99);
            this.tBdetalle.Multiline = true;
            this.tBdetalle.Name = "tBdetalle";
            this.tBdetalle.Size = new System.Drawing.Size(194, 62);
            this.tBdetalle.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Detalle";
            // 
            // bAgregarCosto
            // 
            this.bAgregarCosto.Location = new System.Drawing.Point(212, 25);
            this.bAgregarCosto.Name = "bAgregarCosto";
            this.bAgregarCosto.Size = new System.Drawing.Size(93, 55);
            this.bAgregarCosto.TabIndex = 4;
            this.bAgregarCosto.Text = "Seleccionar y agregar costo";
            this.bAgregarCosto.UseVisualStyleBackColor = true;
            this.bAgregarCosto.Click += new System.EventHandler(this.bAgregarCosto_Click);
            // 
            // bGuardarEnvio
            // 
            this.bGuardarEnvio.Location = new System.Drawing.Point(212, 127);
            this.bGuardarEnvio.Name = "bGuardarEnvio";
            this.bGuardarEnvio.Size = new System.Drawing.Size(90, 34);
            this.bGuardarEnvio.TabIndex = 6;
            this.bGuardarEnvio.Text = "Guardar envío";
            this.bGuardarEnvio.UseVisualStyleBackColor = true;
            this.bGuardarEnvio.Click += new System.EventHandler(this.bGuardarEnvio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bListar);
            this.groupBox3.Controls.Add(this.tBlista);
            this.groupBox3.Location = new System.Drawing.Point(13, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Envíos cargados";
            // 
            // tBlista
            // 
            this.tBlista.Location = new System.Drawing.Point(8, 19);
            this.tBlista.Multiline = true;
            this.tBlista.Name = "tBlista";
            this.tBlista.Size = new System.Drawing.Size(297, 123);
            this.tBlista.TabIndex = 7;
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(310, 19);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(54, 46);
            this.bListar.TabIndex = 7;
            this.bListar.Text = "Listar envíos\r\n";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 487);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Envíos cargados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBcodigo;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBcostos;
        private System.Windows.Forms.Button bAgregarCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBdetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bGuardarEnvio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tBlista;
        private System.Windows.Forms.Button bListar;
    }
}

