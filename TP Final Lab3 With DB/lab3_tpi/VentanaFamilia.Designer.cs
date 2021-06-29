
namespace lab3_sanchez_pablo_sn
{
    partial class VentanaFamiliaConsulta
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
            this.button1_no = new System.Windows.Forms.Button();
            this.button2_si = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_dni = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Ud. Tiene familia?";
            // 
            // button1_no
            // 
            this.button1_no.Location = new System.Drawing.Point(11, 39);
            this.button1_no.Name = "button1_no";
            this.button1_no.Size = new System.Drawing.Size(75, 23);
            this.button1_no.TabIndex = 1;
            this.button1_no.Text = "No";
            this.button1_no.UseVisualStyleBackColor = true;
            this.button1_no.Click += new System.EventHandler(this.button1_no_Click);
            // 
            // button2_si
            // 
            this.button2_si.Location = new System.Drawing.Point(92, 39);
            this.button2_si.Name = "button2_si";
            this.button2_si.Size = new System.Drawing.Size(75, 23);
            this.button2_si.TabIndex = 2;
            this.button2_si.Text = "Si";
            this.button2_si.UseVisualStyleBackColor = true;
            this.button2_si.Click += new System.EventHandler(this.button2_si_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1_dni);
            this.groupBox1.Location = new System.Drawing.Point(11, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI de su Familiar";
            // 
            // textBox1_dni
            // 
            this.textBox1_dni.Location = new System.Drawing.Point(29, 29);
            this.textBox1_dni.Name = "textBox1_dni";
            this.textBox1_dni.Size = new System.Drawing.Size(100, 20);
            this.textBox1_dni.TabIndex = 0;
            // 
            // VentanaFamiliaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 177);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2_si);
            this.Controls.Add(this.button1_no);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentanaFamiliaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_no;
        private System.Windows.Forms.Button button2_si;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_dni;
        private System.Windows.Forms.Button button1;
    }
}