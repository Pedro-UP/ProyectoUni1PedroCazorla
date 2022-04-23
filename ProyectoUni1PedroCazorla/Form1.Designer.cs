namespace ProyectoUni1PedroCazorla
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.lista2 = new System.Windows.Forms.ComboBox();
            this.lista1 = new System.Windows.Forms.ComboBox();
            this.txtConvertir = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Cantidad Deseada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convertir Moneda de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convertir Moneda a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Conversion de Moneda Realizada";
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(104, 84);
            this.txtCantidad1.Multiline = true;
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(130, 21);
            this.txtCantidad1.TabIndex = 4;
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Items.AddRange(new object[] {
            "ConvertirMXN",
            "ConvertirARS",
            "ConvertirBOB",
            "ConvertirBRL",
            "ConvertirVEF"});
            this.lista2.Location = new System.Drawing.Point(558, 84);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(136, 21);
            this.lista2.TabIndex = 6;
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Items.AddRange(new object[] {
            "PesoArgentino",
            "PesoMexicano",
            "Boliviano",
            "RealBrasileño",
            "Bolivar"});
            this.lista1.Location = new System.Drawing.Point(329, 84);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(136, 21);
            this.lista1.TabIndex = 7;
            // 
            // txtConvertir
            // 
            this.txtConvertir.Location = new System.Drawing.Point(316, 198);
            this.txtConvertir.Name = "txtConvertir";
            this.txtConvertir.Size = new System.Drawing.Size(164, 20);
            this.txtConvertir.TabIndex = 8;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(357, 150);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(90, 29);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(584, 166);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 29);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(584, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 29);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 441);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtConvertir);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.txtCantidad1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.ComboBox lista2;
        private System.Windows.Forms.ComboBox lista1;
        private System.Windows.Forms.TextBox txtConvertir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

