
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaServicioALTA
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_nombre = new System.Windows.Forms.TextBox();
            this.textBox3_costo = new System.Windows.Forms.TextBox();
            this.comboBox1_servicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1_premium = new System.Windows.Forms.CheckBox();
            this.button1_aceptar = new System.Windows.Forms.Button();
            this.button2_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_DNI_titular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo";
            // 
            // textBox1_nombre
            // 
            this.textBox1_nombre.Location = new System.Drawing.Point(12, 23);
            this.textBox1_nombre.Name = "textBox1_nombre";
            this.textBox1_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox1_nombre.TabIndex = 4;
            // 
            // textBox3_costo
            // 
            this.textBox3_costo.Location = new System.Drawing.Point(12, 66);
            this.textBox3_costo.Name = "textBox3_costo";
            this.textBox3_costo.Size = new System.Drawing.Size(100, 20);
            this.textBox3_costo.TabIndex = 6;
            // 
            // comboBox1_servicio
            // 
            this.comboBox1_servicio.FormattingEnabled = true;
            this.comboBox1_servicio.Items.AddRange(new object[] {
            "Tv",
            "Luz",
            "Internet"});
            this.comboBox1_servicio.Location = new System.Drawing.Point(118, 22);
            this.comboBox1_servicio.Name = "comboBox1_servicio";
            this.comboBox1_servicio.Size = new System.Drawing.Size(100, 21);
            this.comboBox1_servicio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Servicio";
            // 
            // checkBox1_premium
            // 
            this.checkBox1_premium.AutoSize = true;
            this.checkBox1_premium.Location = new System.Drawing.Point(12, 92);
            this.checkBox1_premium.Name = "checkBox1_premium";
            this.checkBox1_premium.Size = new System.Drawing.Size(66, 17);
            this.checkBox1_premium.TabIndex = 9;
            this.checkBox1_premium.Text = "Premium";
            this.checkBox1_premium.UseVisualStyleBackColor = true;
            // 
            // button1_aceptar
            // 
            this.button1_aceptar.Location = new System.Drawing.Point(143, 115);
            this.button1_aceptar.Name = "button1_aceptar";
            this.button1_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button1_aceptar.TabIndex = 10;
            this.button1_aceptar.Text = "Aceptar";
            this.button1_aceptar.UseVisualStyleBackColor = true;
            this.button1_aceptar.Click += new System.EventHandler(this.button1_aceptar_Click);
            // 
            // button2_cancelar
            // 
            this.button2_cancelar.Location = new System.Drawing.Point(12, 115);
            this.button2_cancelar.Name = "button2_cancelar";
            this.button2_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button2_cancelar.TabIndex = 11;
            this.button2_cancelar.Text = "Cancelar";
            this.button2_cancelar.UseVisualStyleBackColor = true;
            this.button2_cancelar.Click += new System.EventHandler(this.button2_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DNI del titular";
            // 
            // textBox1_DNI_titular
            // 
            this.textBox1_DNI_titular.Location = new System.Drawing.Point(118, 66);
            this.textBox1_DNI_titular.Name = "textBox1_DNI_titular";
            this.textBox1_DNI_titular.Size = new System.Drawing.Size(100, 20);
            this.textBox1_DNI_titular.TabIndex = 13;
            // 
            // VentanaServicioALTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 153);
            this.Controls.Add(this.textBox1_DNI_titular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2_cancelar);
            this.Controls.Add(this.button1_aceptar);
            this.Controls.Add(this.checkBox1_premium);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1_servicio);
            this.Controls.Add(this.textBox3_costo);
            this.Controls.Add(this.textBox1_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaServicioALTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Servicio";
            this.Load += new System.EventHandler(this.VentanaServicioALTA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_nombre;
        private System.Windows.Forms.TextBox textBox3_costo;
        private System.Windows.Forms.ComboBox comboBox1_servicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1_premium;
        private System.Windows.Forms.Button button1_aceptar;
        private System.Windows.Forms.Button button2_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_DNI_titular;
    }
}