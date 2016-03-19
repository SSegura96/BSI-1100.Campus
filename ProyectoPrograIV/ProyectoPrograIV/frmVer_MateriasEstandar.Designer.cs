using System;

namespace ProyectoPrograIV
{
    partial class frmVer_MateriasEstandar
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
            this.lblMateria = new System.Windows.Forms.Label();
            this.txtInfoMateria = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pBImagenMateria = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBImagenMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMaterias
            // 
            this.cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbxMaterias.Size = new System.Drawing.Size(245, 24);
            this.cbxMaterias.TabIndex = 0;
            this.cbxMaterias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.White;
            this.lblMateria.Location = new System.Drawing.Point(77, 27);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(66, 20);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia:";
            // 
            // txtInfoMateria
            // 
            this.txtInfoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoMateria.Location = new System.Drawing.Point(213, 93);
            this.txtInfoMateria.Multiline = true;
            this.txtInfoMateria.Name = "txtInfoMateria";
            this.txtInfoMateria.ReadOnly = true;
            this.txtInfoMateria.Size = new System.Drawing.Size(220, 151);
            this.txtInfoMateria.TabIndex = 3;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(158, 266);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(103, 33);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Atras";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pBImagenMateria
            // 
            this.pBImagenMateria.BackColor = System.Drawing.Color.Transparent;
            this.pBImagenMateria.Location = new System.Drawing.Point(12, 93);
            this.pBImagenMateria.Name = "pBImagenMateria";
            this.pBImagenMateria.Size = new System.Drawing.Size(182, 151);
            this.pBImagenMateria.TabIndex = 6;
            this.pBImagenMateria.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(249, 70);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(149, 20);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Descripcion Materia";
            // 
            // frmVer_MateriasEstandar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoPrograIV.Properties.Resources.verBD_Estandar;
            this.ClientSize = new System.Drawing.Size(449, 311);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txtInfoMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.pBImagenMateria);
            this.Controls.Add(this.cbxMaterias);
            this.Name = "frmVer_MateriasEstandar";
            this.Text = "Materias: Lista de Materias";
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
        private System.Windows.Forms.Label lblInfo;
    }
}