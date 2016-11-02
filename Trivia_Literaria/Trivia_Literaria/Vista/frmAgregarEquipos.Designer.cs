namespace Trivia_Literaria
{
    partial class frmAgregarEquipos
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
            this.lblTrivia = new System.Windows.Forms.Label();
            this.cmbTrivia = new System.Windows.Forms.ComboBox();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.txtIntegrantes = new System.Windows.Forms.TextBox();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.txtLibro6 = new System.Windows.Forms.TextBox();
            this.lblLibro6 = new System.Windows.Forms.Label();
            this.txtNombre6 = new System.Windows.Forms.TextBox();
            this.lblNom6 = new System.Windows.Forms.Label();
            this.txtLibro5 = new System.Windows.Forms.TextBox();
            this.lblLibro5 = new System.Windows.Forms.Label();
            this.txtNombre5 = new System.Windows.Forms.TextBox();
            this.lblNom5 = new System.Windows.Forms.Label();
            this.txtLibro4 = new System.Windows.Forms.TextBox();
            this.lblLibro4 = new System.Windows.Forms.Label();
            this.txtNombre4 = new System.Windows.Forms.TextBox();
            this.lblNom4 = new System.Windows.Forms.Label();
            this.txtLibro3 = new System.Windows.Forms.TextBox();
            this.lblLibro3 = new System.Windows.Forms.Label();
            this.txtNombre3 = new System.Windows.Forms.TextBox();
            this.lblNom3 = new System.Windows.Forms.Label();
            this.txtLibro2 = new System.Windows.Forms.TextBox();
            this.lblLibro2 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblNom2 = new System.Windows.Forms.Label();
            this.txtLibro1 = new System.Windows.Forms.TextBox();
            this.lblLibro1 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lblNom1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbEquipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrivia
            // 
            this.lblTrivia.AutoSize = true;
            this.lblTrivia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrivia.Location = new System.Drawing.Point(13, 9);
            this.lblTrivia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrivia.Name = "lblTrivia";
            this.lblTrivia.Size = new System.Drawing.Size(48, 18);
            this.lblTrivia.TabIndex = 0;
            this.lblTrivia.Text = "Trivia";
            // 
            // cmbTrivia
            // 
            this.cmbTrivia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrivia.FormattingEnabled = true;
            this.cmbTrivia.Items.AddRange(new object[] {
            "Trivia A",
            "Trivia B"});
            this.cmbTrivia.Location = new System.Drawing.Point(177, 3);
            this.cmbTrivia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrivia.Name = "cmbTrivia";
            this.cmbTrivia.Size = new System.Drawing.Size(268, 26);
            this.cmbTrivia.TabIndex = 3;
            this.cmbTrivia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTrivia_KeyPress);
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipo.Location = new System.Drawing.Point(177, 40);
            this.txtEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(268, 25);
            this.txtEquipo.TabIndex = 8;
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(13, 47);
            this.lblEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(55, 18);
            this.lblEquipo.TabIndex = 6;
            this.lblEquipo.Text = "Equipo";
            // 
            // txtIntegrantes
            // 
            this.txtIntegrantes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegrantes.Location = new System.Drawing.Point(176, 82);
            this.txtIntegrantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntegrantes.Name = "txtIntegrantes";
            this.txtIntegrantes.Size = new System.Drawing.Size(41, 25);
            this.txtIntegrantes.TabIndex = 13;
            this.txtIntegrantes.TextChanged += new System.EventHandler(this.txtIntegrantes_TextChanged);
            this.txtIntegrantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntegrantes_KeyPress);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(13, 85);
            this.lblIntegrantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(155, 18);
            this.lblIntegrantes.TabIndex = 12;
            this.lblIntegrantes.Text = "Número de Integrantes";
            // 
            // gbEquipo
            // 
            this.gbEquipo.Controls.Add(this.txtLibro6);
            this.gbEquipo.Controls.Add(this.lblLibro6);
            this.gbEquipo.Controls.Add(this.txtNombre6);
            this.gbEquipo.Controls.Add(this.lblNom6);
            this.gbEquipo.Controls.Add(this.txtLibro5);
            this.gbEquipo.Controls.Add(this.lblLibro5);
            this.gbEquipo.Controls.Add(this.txtNombre5);
            this.gbEquipo.Controls.Add(this.lblNom5);
            this.gbEquipo.Controls.Add(this.txtLibro4);
            this.gbEquipo.Controls.Add(this.lblLibro4);
            this.gbEquipo.Controls.Add(this.txtNombre4);
            this.gbEquipo.Controls.Add(this.lblNom4);
            this.gbEquipo.Controls.Add(this.txtLibro3);
            this.gbEquipo.Controls.Add(this.lblLibro3);
            this.gbEquipo.Controls.Add(this.txtNombre3);
            this.gbEquipo.Controls.Add(this.lblNom3);
            this.gbEquipo.Controls.Add(this.txtLibro2);
            this.gbEquipo.Controls.Add(this.lblLibro2);
            this.gbEquipo.Controls.Add(this.txtNombre2);
            this.gbEquipo.Controls.Add(this.lblNom2);
            this.gbEquipo.Controls.Add(this.txtLibro1);
            this.gbEquipo.Controls.Add(this.lblLibro1);
            this.gbEquipo.Controls.Add(this.txtNombre1);
            this.gbEquipo.Controls.Add(this.lblNom1);
            this.gbEquipo.Location = new System.Drawing.Point(16, 125);
            this.gbEquipo.Name = "gbEquipo";
            this.gbEquipo.Size = new System.Drawing.Size(407, 334);
            this.gbEquipo.TabIndex = 19;
            this.gbEquipo.TabStop = false;
            this.gbEquipo.Text = "Nombre del equipo";
            // 
            // txtLibro6
            // 
            this.txtLibro6.Location = new System.Drawing.Point(282, 269);
            this.txtLibro6.Name = "txtLibro6";
            this.txtLibro6.Size = new System.Drawing.Size(100, 25);
            this.txtLibro6.TabIndex = 23;
            // 
            // lblLibro6
            // 
            this.lblLibro6.AutoSize = true;
            this.lblLibro6.Location = new System.Drawing.Point(230, 272);
            this.lblLibro6.Name = "lblLibro6";
            this.lblLibro6.Size = new System.Drawing.Size(45, 18);
            this.lblLibro6.TabIndex = 22;
            this.lblLibro6.Text = "Libro";
            // 
            // txtNombre6
            // 
            this.txtNombre6.Location = new System.Drawing.Point(77, 269);
            this.txtNombre6.Name = "txtNombre6";
            this.txtNombre6.Size = new System.Drawing.Size(100, 25);
            this.txtNombre6.TabIndex = 21;
            // 
            // lblNom6
            // 
            this.lblNom6.AutoSize = true;
            this.lblNom6.Location = new System.Drawing.Point(13, 272);
            this.lblNom6.Name = "lblNom6";
            this.lblNom6.Size = new System.Drawing.Size(58, 18);
            this.lblNom6.TabIndex = 20;
            this.lblNom6.Text = "Nombre";
            // 
            // txtLibro5
            // 
            this.txtLibro5.Location = new System.Drawing.Point(282, 223);
            this.txtLibro5.Name = "txtLibro5";
            this.txtLibro5.Size = new System.Drawing.Size(100, 25);
            this.txtLibro5.TabIndex = 19;
            // 
            // lblLibro5
            // 
            this.lblLibro5.AutoSize = true;
            this.lblLibro5.Location = new System.Drawing.Point(230, 226);
            this.lblLibro5.Name = "lblLibro5";
            this.lblLibro5.Size = new System.Drawing.Size(45, 18);
            this.lblLibro5.TabIndex = 18;
            this.lblLibro5.Text = "Libro";
            // 
            // txtNombre5
            // 
            this.txtNombre5.Location = new System.Drawing.Point(77, 223);
            this.txtNombre5.Name = "txtNombre5";
            this.txtNombre5.Size = new System.Drawing.Size(100, 25);
            this.txtNombre5.TabIndex = 17;
            // 
            // lblNom5
            // 
            this.lblNom5.AutoSize = true;
            this.lblNom5.Location = new System.Drawing.Point(13, 226);
            this.lblNom5.Name = "lblNom5";
            this.lblNom5.Size = new System.Drawing.Size(58, 18);
            this.lblNom5.TabIndex = 16;
            this.lblNom5.Text = "Nombre";
            // 
            // txtLibro4
            // 
            this.txtLibro4.Location = new System.Drawing.Point(282, 177);
            this.txtLibro4.Name = "txtLibro4";
            this.txtLibro4.Size = new System.Drawing.Size(100, 25);
            this.txtLibro4.TabIndex = 15;
            // 
            // lblLibro4
            // 
            this.lblLibro4.AutoSize = true;
            this.lblLibro4.Location = new System.Drawing.Point(230, 180);
            this.lblLibro4.Name = "lblLibro4";
            this.lblLibro4.Size = new System.Drawing.Size(45, 18);
            this.lblLibro4.TabIndex = 14;
            this.lblLibro4.Text = "Libro";
            // 
            // txtNombre4
            // 
            this.txtNombre4.Location = new System.Drawing.Point(77, 177);
            this.txtNombre4.Name = "txtNombre4";
            this.txtNombre4.Size = new System.Drawing.Size(100, 25);
            this.txtNombre4.TabIndex = 13;
            // 
            // lblNom4
            // 
            this.lblNom4.AutoSize = true;
            this.lblNom4.Location = new System.Drawing.Point(13, 180);
            this.lblNom4.Name = "lblNom4";
            this.lblNom4.Size = new System.Drawing.Size(58, 18);
            this.lblNom4.TabIndex = 12;
            this.lblNom4.Text = "Nombre";
            // 
            // txtLibro3
            // 
            this.txtLibro3.Location = new System.Drawing.Point(282, 129);
            this.txtLibro3.Name = "txtLibro3";
            this.txtLibro3.Size = new System.Drawing.Size(100, 25);
            this.txtLibro3.TabIndex = 11;
            // 
            // lblLibro3
            // 
            this.lblLibro3.AutoSize = true;
            this.lblLibro3.Location = new System.Drawing.Point(230, 132);
            this.lblLibro3.Name = "lblLibro3";
            this.lblLibro3.Size = new System.Drawing.Size(45, 18);
            this.lblLibro3.TabIndex = 10;
            this.lblLibro3.Text = "Libro";
            // 
            // txtNombre3
            // 
            this.txtNombre3.Location = new System.Drawing.Point(77, 129);
            this.txtNombre3.Name = "txtNombre3";
            this.txtNombre3.Size = new System.Drawing.Size(100, 25);
            this.txtNombre3.TabIndex = 9;
            // 
            // lblNom3
            // 
            this.lblNom3.AutoSize = true;
            this.lblNom3.Location = new System.Drawing.Point(13, 132);
            this.lblNom3.Name = "lblNom3";
            this.lblNom3.Size = new System.Drawing.Size(58, 18);
            this.lblNom3.TabIndex = 8;
            this.lblNom3.Text = "Nombre";
            // 
            // txtLibro2
            // 
            this.txtLibro2.Location = new System.Drawing.Point(282, 83);
            this.txtLibro2.Name = "txtLibro2";
            this.txtLibro2.Size = new System.Drawing.Size(100, 25);
            this.txtLibro2.TabIndex = 7;
            // 
            // lblLibro2
            // 
            this.lblLibro2.AutoSize = true;
            this.lblLibro2.Location = new System.Drawing.Point(230, 86);
            this.lblLibro2.Name = "lblLibro2";
            this.lblLibro2.Size = new System.Drawing.Size(45, 18);
            this.lblLibro2.TabIndex = 6;
            this.lblLibro2.Text = "Libro";
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(77, 83);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(100, 25);
            this.txtNombre2.TabIndex = 5;
            // 
            // lblNom2
            // 
            this.lblNom2.AutoSize = true;
            this.lblNom2.Location = new System.Drawing.Point(13, 86);
            this.lblNom2.Name = "lblNom2";
            this.lblNom2.Size = new System.Drawing.Size(58, 18);
            this.lblNom2.TabIndex = 4;
            this.lblNom2.Text = "Nombre";
            // 
            // txtLibro1
            // 
            this.txtLibro1.Location = new System.Drawing.Point(282, 35);
            this.txtLibro1.Name = "txtLibro1";
            this.txtLibro1.Size = new System.Drawing.Size(100, 25);
            this.txtLibro1.TabIndex = 3;
            // 
            // lblLibro1
            // 
            this.lblLibro1.AutoSize = true;
            this.lblLibro1.Location = new System.Drawing.Point(230, 38);
            this.lblLibro1.Name = "lblLibro1";
            this.lblLibro1.Size = new System.Drawing.Size(45, 18);
            this.lblLibro1.TabIndex = 2;
            this.lblLibro1.Text = "Libro";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(77, 35);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 25);
            this.txtNombre1.TabIndex = 1;
            // 
            // lblNom1
            // 
            this.lblNom1.AutoSize = true;
            this.lblNom1.Location = new System.Drawing.Point(13, 38);
            this.lblNom1.Name = "lblNom1";
            this.lblNom1.Size = new System.Drawing.Size(58, 18);
            this.lblNom1.TabIndex = 0;
            this.lblNom1.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(249, 466);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 32);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(32, 466);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 32);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAgregarEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 115);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbEquipo);
            this.Controls.Add(this.txtIntegrantes);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.cmbTrivia);
            this.Controls.Add(this.lblTrivia);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAgregarEquipos";
            this.Text = "Agregar Equipos";
            this.Load += new System.EventHandler(this.frmAgregarEquipos_Load);
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrivia;
        private System.Windows.Forms.ComboBox cmbTrivia;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.TextBox txtIntegrantes;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.TextBox txtLibro5;
        private System.Windows.Forms.Label lblLibro5;
        private System.Windows.Forms.TextBox txtNombre5;
        private System.Windows.Forms.Label lblNom5;
        private System.Windows.Forms.TextBox txtLibro4;
        private System.Windows.Forms.Label lblLibro4;
        private System.Windows.Forms.TextBox txtNombre4;
        private System.Windows.Forms.Label lblNom4;
        private System.Windows.Forms.TextBox txtLibro3;
        private System.Windows.Forms.Label lblLibro3;
        private System.Windows.Forms.TextBox txtNombre3;
        private System.Windows.Forms.Label lblNom3;
        private System.Windows.Forms.TextBox txtLibro2;
        private System.Windows.Forms.Label lblLibro2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lblNom2;
        private System.Windows.Forms.TextBox txtLibro1;
        private System.Windows.Forms.Label lblLibro1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lblNom1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtLibro6;
        private System.Windows.Forms.Label lblLibro6;
        private System.Windows.Forms.TextBox txtNombre6;
        private System.Windows.Forms.Label lblNom6;
    }
}