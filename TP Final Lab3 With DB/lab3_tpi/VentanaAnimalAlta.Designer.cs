
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaAnimalAlta
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
            this.button2_cancelar = new System.Windows.Forms.Button();
            this.button1_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_edad = new System.Windows.Forms.TextBox();
            this.textBox1_origen = new System.Windows.Forms.TextBox();
            this.textBox2_tipo = new System.Windows.Forms.TextBox();
            this.textBox1_nombre = new System.Windows.Forms.TextBox();
            this.textBox1_DNI_titular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2_cancelar
            // 
            this.button2_cancelar.Location = new System.Drawing.Point(12, 154);
            this.button2_cancelar.Name = "button2_cancelar";
            this.button2_cancelar.Size = new System.Drawing.Size(100, 23);
            this.button2_cancelar.TabIndex = 26;
            this.button2_cancelar.Text = "Cancelar";
            this.button2_cancelar.UseVisualStyleBackColor = true;
            this.button2_cancelar.Click += new System.EventHandler(this.button2_cancelar_Click);
            // 
            // button1_aceptar
            // 
            this.button1_aceptar.Location = new System.Drawing.Point(118, 154);
            this.button1_aceptar.Name = "button1_aceptar";
            this.button1_aceptar.Size = new System.Drawing.Size(100, 23);
            this.button1_aceptar.TabIndex = 25;
            this.button1_aceptar.Text = "Aceptar";
            this.button1_aceptar.UseVisualStyleBackColor = true;
            this.button1_aceptar.Click += new System.EventHandler(this.button1_aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // textBox1_edad
            // 
            this.textBox1_edad.Location = new System.Drawing.Point(118, 76);
            this.textBox1_edad.Name = "textBox1_edad";
            this.textBox1_edad.Size = new System.Drawing.Size(100, 20);
            this.textBox1_edad.TabIndex = 2;
            // 
            // textBox1_origen
            // 
            this.textBox1_origen.Location = new System.Drawing.Point(118, 117);
            this.textBox1_origen.Name = "textBox1_origen";
            this.textBox1_origen.Size = new System.Drawing.Size(100, 20);
            this.textBox1_origen.TabIndex = 4;
            // 
            // textBox2_tipo
            // 
            this.textBox2_tipo.Location = new System.Drawing.Point(12, 117);
            this.textBox2_tipo.Name = "textBox2_tipo";
            this.textBox2_tipo.Size = new System.Drawing.Size(100, 20);
            this.textBox2_tipo.TabIndex = 3;
            // 
            // textBox1_nombre
            // 
            this.textBox1_nombre.Location = new System.Drawing.Point(12, 76);
            this.textBox1_nombre.Name = "textBox1_nombre";
            this.textBox1_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox1_nombre.TabIndex = 1;
            // 
            // textBox1_DNI_titular
            // 
            this.textBox1_DNI_titular.Location = new System.Drawing.Point(12, 21);
            this.textBox1_DNI_titular.Name = "textBox1_DNI_titular";
            this.textBox1_DNI_titular.Size = new System.Drawing.Size(100, 20);
            this.textBox1_DNI_titular.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "DNI del Dueño";
            // 
            // VentanaAnimalAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 190);
            this.Controls.Add(this.textBox1_DNI_titular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2_cancelar);
            this.Controls.Add(this.button1_aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_edad);
            this.Controls.Add(this.textBox1_origen);
            this.Controls.Add(this.textBox2_tipo);
            this.Controls.Add(this.textBox1_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaAnimalAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Animales";
            this.Load += new System.EventHandler(this.VentanaAnimalAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2_cancelar;
        private System.Windows.Forms.Button button1_aceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_edad;
        private System.Windows.Forms.TextBox textBox1_origen;
        private System.Windows.Forms.TextBox textBox2_tipo;
        private System.Windows.Forms.TextBox textBox1_nombre;
        private System.Windows.Forms.TextBox textBox1_DNI_titular;
        private System.Windows.Forms.Label label5;
    }
}