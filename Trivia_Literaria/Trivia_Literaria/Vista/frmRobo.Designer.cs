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
            this.lblEquipo = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnCorrecto = new System.Windows.Forms.Button();
            this.btnIncorrecto = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.tmTemporizador = new System.Windows.Forms.Timer(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblConteoRegresivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(16, 45);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipos.TabIndex = 0;
            this.cmbEquipos.Visible = false;
            this.cmbEquipos.SelectionChangeCommitted += new System.EventHandler(this.cmbEquipos_SelectionChangeCommitted);
            this.cmbEquipos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEquipos_KeyPress);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEquipo.Location = new System.Drawing.Point(13, 26);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(57, 16);
            this.lblEquipo.TabIndex = 1;
            this.lblEquipo.Text = "Equipo";
            this.lblEquipo.Visible = false;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(16, 79);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(403, 242);
            this.txtPregunta.TabIndex = 2;
            this.txtPregunta.Visible = false;
            // 
            // btnCorrecto
            // 
            this.btnCorrecto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCorrecto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCorrecto.Location = new System.Drawing.Point(194, 34);
            this.btnCorrecto.Name = "btnCorrecto";
            this.btnCorrecto.Size = new System.Drawing.Size(96, 39);
            this.btnCorrecto.TabIndex = 3;
            this.btnCorrecto.Text = "Correcto";
            this.btnCorrecto.UseVisualStyleBackColor = false;
            this.btnCorrecto.Visible = false;
            this.btnCorrecto.Click += new System.EventHandler(this.btnCorrecto_Click);
            // 
            // btnIncorrecto
            // 
            this.btnIncorrecto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIncorrecto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncorrecto.Location = new System.Drawing.Point(323, 34);
            this.btnIncorrecto.Name = "btnIncorrecto";
            this.btnIncorrecto.Size = new System.Drawing.Size(96, 39);
            this.btnIncorrecto.TabIndex = 3;
            this.btnIncorrecto.Text = "Incorrecto";
            this.btnIncorrecto.UseVisualStyleBackColor = false;
            this.btnIncorrecto.Visible = false;
            this.btnIncorrecto.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(251, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "TIME: ";
            this.lblTime.Visible = false;
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Location = new System.Drawing.Point(311, 9);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(16, 16);
            this.lblSegundos.TabIndex = 4;
            this.lblSegundos.Text = "0";
            this.lblSegundos.Visible = false;
            // 
            // tmTemporizador
            // 
            this.tmTemporizador.Enabled = true;
            this.tmTemporizador.Interval = 1000;
            this.tmTemporizador.Tick += new System.EventHandler(this.tmTemporizador_Tick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Red;
            this.btnRegresar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(16, 327);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(95, 31);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblConteoRegresivo
            // 
            this.lblConteoRegresivo.AutoSize = true;
            this.lblConteoRegresivo.BackColor = System.Drawing.Color.Transparent;
            this.lblConteoRegresivo.Font = new System.Drawing.Font("Monotype Corsiva", 150F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteoRegresivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConteoRegresivo.Location = new System.Drawing.Point(116, 79);
            this.lblConteoRegresivo.Name = "lblConteoRegresivo";
            this.lblConteoRegresivo.Size = new System.Drawing.Size(190, 242);
            this.lblConteoRegresivo.TabIndex = 7;
            this.lblConteoRegresivo.Text = "3";
            // 
            // frmRobo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Trivia_Literaria.Properties.Resources.fondo_escenario_P1;
            this.ClientSize = new System.Drawing.Size(445, 360);
            this.Controls.Add(this.lblConteoRegresivo);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnIncorrecto);
            this.Controls.Add(this.btnCorrecto);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.cmbEquipos);
            this.Name = "frmRobo";
            this.Text = "Robo";
            this.Load += new System.EventHandler(this.frmRobo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnCorrecto;
        private System.Windows.Forms.Button btnIncorrecto;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Timer tmTemporizador;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblConteoRegresivo;
    }
}