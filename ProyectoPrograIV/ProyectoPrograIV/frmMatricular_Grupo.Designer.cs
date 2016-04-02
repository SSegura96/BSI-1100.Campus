namespace ProyectoPrograIV
{
    partial class frmMatricular_Grupo
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.cbxProfesores = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cbxMaterias = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cbxAlumnos = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnPrimerCiclo = new System.Windows.Forms.RadioButton();
            this.rdBtnSegundoCiclo = new System.Windows.Forms.RadioButton();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.cbxSeccion = new System.Windows.Forms.ComboBox();
            this.cbxGrado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 41);
            this.label1.TabIndex = 30;
            this.label1.Text = "Por favor llene todos los espacios con informacion correcta. Revise que los datos" +
    " no se repitan en la base de datos.";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(116, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 34);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.Location = new System.Drawing.Point(11, 201);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(66, 17);
            this.lblProfesor.TabIndex = 28;
            this.lblProfesor.Text = "Profesor:";
            // 
            // cbxProfesores
            // 
            this.cbxProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProfesores.FormattingEnabled = true;
            this.cbxProfesores.Location = new System.Drawing.Point(83, 198);
            this.cbxProfesores.Name = "cbxProfesores";
            this.cbxProfesores.Size = new System.Drawing.Size(338, 24);
            this.cbxProfesores.TabIndex = 27;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(18, 171);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(59, 17);
            this.lblMateria.TabIndex = 26;
            this.lblMateria.Text = "Materia:";
            // 
            // cbxMaterias
            // 
            this.cbxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaterias.FormattingEnabled = true;
            this.cbxMaterias.Location = new System.Drawing.Point(83, 168);
            this.cbxMaterias.Name = "cbxMaterias";
            this.cbxMaterias.Size = new System.Drawing.Size(338, 24);
            this.cbxMaterias.TabIndex = 25;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(18, 231);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(59, 17);
            this.lblAlumno.TabIndex = 24;
            this.lblAlumno.Text = "Alumno:";
            // 
            // cbxAlumnos
            // 
            this.cbxAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlumnos.FormattingEnabled = true;
            this.cbxAlumnos.Location = new System.Drawing.Point(83, 228);
            this.cbxAlumnos.Name = "cbxAlumnos";
            this.cbxAlumnos.Size = new System.Drawing.Size(338, 24);
            this.cbxAlumnos.TabIndex = 23;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(262, 258);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 34);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtnPrimerCiclo);
            this.panel1.Controls.Add(this.rdBtnSegundoCiclo);
            this.panel1.Location = new System.Drawing.Point(127, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 38);
            this.panel1.TabIndex = 21;
            // 
            // rdBtnPrimerCiclo
            // 
            this.rdBtnPrimerCiclo.AutoSize = true;
            this.rdBtnPrimerCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnPrimerCiclo.Location = new System.Drawing.Point(14, 16);
            this.rdBtnPrimerCiclo.Name = "rdBtnPrimerCiclo";
            this.rdBtnPrimerCiclo.Size = new System.Drawing.Size(101, 21);
            this.rdBtnPrimerCiclo.TabIndex = 0;
            this.rdBtnPrimerCiclo.TabStop = true;
            this.rdBtnPrimerCiclo.Text = "Primer Ciclo";
            this.rdBtnPrimerCiclo.UseVisualStyleBackColor = true;
            this.rdBtnPrimerCiclo.CheckedChanged += new System.EventHandler(this.rdBtnPrimerCiclo_CheckedChanged);
            // 
            // rdBtnSegundoCiclo
            // 
            this.rdBtnSegundoCiclo.AutoSize = true;
            this.rdBtnSegundoCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnSegundoCiclo.Location = new System.Drawing.Point(121, 16);
            this.rdBtnSegundoCiclo.Name = "rdBtnSegundoCiclo";
            this.rdBtnSegundoCiclo.Size = new System.Drawing.Size(117, 21);
            this.rdBtnSegundoCiclo.TabIndex = 1;
            this.rdBtnSegundoCiclo.TabStop = true;
            this.rdBtnSegundoCiclo.Text = "Segundo Ciclo";
            this.rdBtnSegundoCiclo.UseVisualStyleBackColor = true;
            this.rdBtnSegundoCiclo.CheckedChanged += new System.EventHandler(this.rdBtnSegundoCiclo_CheckedChanged);
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(15, 141);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(62, 17);
            this.lblSeccion.TabIndex = 20;
            this.lblSeccion.Text = "Seccion:";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.Location = new System.Drawing.Point(25, 111);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(52, 17);
            this.lblGrado.TabIndex = 19;
            this.lblGrado.Text = "Grado:";
            // 
            // cbxSeccion
            // 
            this.cbxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSeccion.FormattingEnabled = true;
            this.cbxSeccion.Location = new System.Drawing.Point(83, 138);
            this.cbxSeccion.Name = "cbxSeccion";
            this.cbxSeccion.Size = new System.Drawing.Size(338, 24);
            this.cbxSeccion.TabIndex = 18;
            // 
            // cbxGrado
            // 
            this.cbxGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGrado.FormattingEnabled = true;
            this.cbxGrado.Location = new System.Drawing.Point(83, 108);
            this.cbxGrado.Name = "cbxGrado";
            this.cbxGrado.Size = new System.Drawing.Size(338, 24);
            this.cbxGrado.TabIndex = 17;
            this.cbxGrado.SelectedIndexChanged += new System.EventHandler(this.cbxGrado_SelectedIndexChanged);
            // 
            // frmMatricular_Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cbxProfesores);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cbxMaterias);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.cbxAlumnos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.cbxSeccion);
            this.Controls.Add(this.cbxGrado);
            this.Name = "frmMatricular_Grupo";
            this.Text = "Matricular en Grupo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox cbxProfesores;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cbxMaterias;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cbxAlumnos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnPrimerCiclo;
        private System.Windows.Forms.RadioButton rdBtnSegundoCiclo;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.ComboBox cbxSeccion;
        private System.Windows.Forms.ComboBox cbxGrado;
    }
}