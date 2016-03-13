namespace ProyectoPrograIV
{
    partial class VerBD_Estandar
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
            this.cbxMaterias = new System.Windows.Forms.ComboBox();
            this.pBImagenMateria = new System.Windows.Forms.PictureBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtInfoMateria = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagenMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMaterias
            // 
            this.cbxMaterias.FormattingEnabled = true;
            this.cbxMaterias.Items.AddRange(new object[] {
            "1. Artes Industriales.",
            "2. Ciencias de la Naturaleza.",
            "3. Computacion.",
            "4. Educacion Artistica.",
            "5. Educacion Fisica.",
            "6. Educacion del Hogar.",
            "7. Educacion Musical.",
            "8. Español.",
            "9. Educacion Religiosa.",
            "10. Historia y Geografia.",
            "11. Ingles.",
            "12. Matematicas."});
            this.cbxMaterias.Location = new System.Drawing.Point(145, 26);
            this.cbxMaterias.Name = "cbxMaterias";
            this.cbxMaterias.Size = new System.Drawing.Size(245, 21);
            this.cbxMaterias.TabIndex = 0;
            this.cbxMaterias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pBImagenMateria
            // 
            this.pBImagenMateria.Location = new System.Drawing.Point(25, 78);
            this.pBImagenMateria.Name = "pBImagenMateria";
            this.pBImagenMateria.Size = new System.Drawing.Size(177, 151);
            this.pBImagenMateria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBImagenMateria.TabIndex = 1;
            this.pBImagenMateria.TabStop = false;
            this.pBImagenMateria.Click += new System.EventHandler(this.pBImagenMateria_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(77, 27);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(66, 20);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia:";
            // 
            // txtInfoMateria
            // 
            this.txtInfoMateria.Location = new System.Drawing.Point(226, 78);
            this.txtInfoMateria.Multiline = true;
            this.txtInfoMateria.Name = "txtInfoMateria";
            this.txtInfoMateria.ReadOnly = true;
            this.txtInfoMateria.Size = new System.Drawing.Size(220, 151);
            this.txtInfoMateria.TabIndex = 3;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(172, 249);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(110, 30);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // VerBD_Estandar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 291);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtInfoMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.pBImagenMateria);
            this.Controls.Add(this.cbxMaterias);
            this.Name = "VerBD_Estandar";
            this.Text = "VerBD_Estandar";
            ((System.ComponentModel.ISupportInitialize)(this.pBImagenMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.PictureBox pBImagenMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtInfoMateria;
        private System.Windows.Forms.Button btnAtras;
    }
}