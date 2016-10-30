namespace Trivia_Literaria.Vista
{
    partial class frmRobo
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
            this.components = new System.ComponentModel.Container();
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnCorrecto = new System.Windows.Forms.Button();
            this.btnIncorrecto = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.tmTemporizador = new System.Windows.Forms.Timer(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(67, 25);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipos.TabIndex = 0;
            this.cmbEquipos.SelectionChangeCommitted += new System.EventHandler(this.cmbEquipos_SelectionChangeCommitted);
            this.cmbEquipos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEquipos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipo";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(16, 79);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(261, 191);
            this.txtPregunta.TabIndex = 2;
            // 
            // btnCorrecto
            // 
            this.btnCorrecto.Location = new System.Drawing.Point(283, 77);
            this.btnCorrecto.Name = "btnCorrecto";
            this.btnCorrecto.Size = new System.Drawing.Size(75, 23);
            this.btnCorrecto.TabIndex = 3;
            this.btnCorrecto.Text = "Correcto";
            this.btnCorrecto.UseVisualStyleBackColor = true;
            this.btnCorrecto.Visible = false;
            this.btnCorrecto.Click += new System.EventHandler(this.btnCorrecto_Click);
            // 
            // btnIncorrecto
            // 
            this.btnIncorrecto.Location = new System.Drawing.Point(283, 123);
            this.btnIncorrecto.Name = "btnIncorrecto";
            this.btnIncorrecto.Size = new System.Drawing.Size(75, 23);
            this.btnIncorrecto.TabIndex = 3;
            this.btnIncorrecto.Text = "Incorrecto";
            this.btnIncorrecto.UseVisualStyleBackColor = true;
            this.btnIncorrecto.Visible = false;
            this.btnIncorrecto.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(280, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "TIME: ";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(325, 28);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(13, 13);
            this.lblSegundos.TabIndex = 4;
            this.lblSegundos.Text = "0";
            // 
            // tmTemporizador
            // 
            this.tmTemporizador.Interval = 1000;
            this.tmTemporizador.Tick += new System.EventHandler(this.tmTemporizador_Tick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(16, 276);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmRobo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 311);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnIncorrecto);
            this.Controls.Add(this.btnCorrecto);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEquipos);
            this.Name = "frmRobo";
            this.Text = "Robo";
            this.Load += new System.EventHandler(this.frmRobo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnCorrecto;
        private System.Windows.Forms.Button btnIncorrecto;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Timer tmTemporizador;
        private System.Windows.Forms.Button btnRegresar;
    }
}