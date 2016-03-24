namespace ProyectoPrograIV
{
    partial class frmContrasenna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContrasenna));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.PbInfo = new System.Windows.Forms.PictureBox();
            this.PbAcceder = new System.Windows.Forms.PictureBox();
            this.PbRegistarse = new System.Windows.Forms.PictureBox();
            this.PbCerrar = new System.Windows.Forms.PictureBox();
            this.Wallpaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAcceder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRegistarse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(144, 217);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(271, 29);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenna.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenna.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContrasenna.Location = new System.Drawing.Point(143, 308);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.PasswordChar = '*';
            this.txtContrasenna.Size = new System.Drawing.Size(271, 29);
            this.txtContrasenna.TabIndex = 4;
            this.txtContrasenna.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PbInfo
            // 
            this.PbInfo.Image = ((System.Drawing.Image)(resources.GetObject("PbInfo.Image")));
            this.PbInfo.Location = new System.Drawing.Point(473, 426);
            this.PbInfo.Name = "PbInfo";
            this.PbInfo.Size = new System.Drawing.Size(25, 26);
            this.PbInfo.TabIndex = 14;
            this.PbInfo.TabStop = false;
            this.PbInfo.Click += new System.EventHandler(this.PbInfo_Click);
            this.PbInfo.MouseLeave += new System.EventHandler(this.PbInfo_MouseLeave);
            this.PbInfo.MouseHover += new System.EventHandler(this.PbInfo_MouseHover);
            // 
            // PbAcceder
            // 
            this.PbAcceder.Image = global::ProyectoPrograIV.Properties.Resources.btn_E_Acceder;
            this.PbAcceder.Location = new System.Drawing.Point(363, 384);
            this.PbAcceder.Name = "PbAcceder";
            this.PbAcceder.Size = new System.Drawing.Size(93, 33);
            this.PbAcceder.TabIndex = 13;
            this.PbAcceder.TabStop = false;
            this.PbAcceder.Click += new System.EventHandler(this.PbAcceder_Click);
            this.PbAcceder.MouseLeave += new System.EventHandler(this.PbAcceder_MouseLeave);
            this.PbAcceder.MouseHover += new System.EventHandler(this.PbAcceder_MouseHover);
            // 
            // PbRegistarse
            // 
            this.PbRegistarse.Image = global::ProyectoPrograIV.Properties.Resources.btn_E_Registarse;
            this.PbRegistarse.Location = new System.Drawing.Point(207, 385);
            this.PbRegistarse.Name = "PbRegistarse";
            this.PbRegistarse.Size = new System.Drawing.Size(105, 33);
            this.PbRegistarse.TabIndex = 12;
            this.PbRegistarse.TabStop = false;
            this.PbRegistarse.Click += new System.EventHandler(this.PbRegistarse_Click);
            this.PbRegistarse.MouseLeave += new System.EventHandler(this.PbRegistarse_MouseLeave);
            this.PbRegistarse.MouseHover += new System.EventHandler(this.PbRegistarse_MouseHover);
            // 
            // PbCerrar
            // 
            this.PbCerrar.Image = global::ProyectoPrograIV.Properties.Resources.btn_E_Cerrar;
            this.PbCerrar.Location = new System.Drawing.Point(58, 384);
            this.PbCerrar.Name = "PbCerrar";
            this.PbCerrar.Size = new System.Drawing.Size(94, 33);
            this.PbCerrar.TabIndex = 11;
            this.PbCerrar.TabStop = false;
            this.PbCerrar.Click += new System.EventHandler(this.pictureBox3_Click);
            this.PbCerrar.MouseLeave += new System.EventHandler(this.PbCerrar_MouseLeave);
            this.PbCerrar.MouseHover += new System.EventHandler(this.PbCerrar_MouseHover);
            // 
            // Wallpaper
            // 
            this.Wallpaper.Image = global::ProyectoPrograIV.Properties.Resources.BaseContrasena;
            this.Wallpaper.Location = new System.Drawing.Point(-1, 0);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.Size = new System.Drawing.Size(514, 461);
            this.Wallpaper.TabIndex = 9;
            this.Wallpaper.TabStop = false;
            // 
            // frmContrasenna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 458);
            this.Controls.Add(this.PbInfo);
            this.Controls.Add(this.PbAcceder);
            this.Controls.Add(this.PbRegistarse);
            this.Controls.Add(this.PbCerrar);
            this.Controls.Add(this.txtContrasenna);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Wallpaper);
            this.MaximizeBox = false;
            this.Name = "frmContrasenna";
            this.Text = "Inicio de sesion Estandar";
            ((System.ComponentModel.ISupportInitialize)(this.PbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAcceder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRegistarse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Wallpaper;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.PictureBox PbCerrar;
        private System.Windows.Forms.PictureBox PbRegistarse;
        private System.Windows.Forms.PictureBox PbAcceder;
        private System.Windows.Forms.PictureBox PbInfo;
    }
}