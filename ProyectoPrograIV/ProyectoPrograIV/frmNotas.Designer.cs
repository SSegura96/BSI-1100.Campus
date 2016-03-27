namespace ProyectoPrograIV
{
    partial class frmNotas
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
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCarne
            // 
            this.txtCarne.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarne.Location = new System.Drawing.Point(68, 32);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(187, 27);
            this.txtCarne.TabIndex = 0;
            this.txtCarne.Text = "Carné";
            this.txtCarne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCarne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.Location = new System.Drawing.Point(68, 87);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(187, 27);
            this.txtEstudiante.TabIndex = 1;
            this.txtEstudiante.Text = "Nombre Estudiante";
            this.txtEstudiante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(57, 150);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(179, 150);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(88, 30);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 202);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.txtCarne);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSiguiente;
    }
}