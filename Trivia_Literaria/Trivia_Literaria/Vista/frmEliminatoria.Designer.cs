namespace Trivia_Literaria.Vista
{
    partial class frmEliminatoria
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
            this.lblEq = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblSco = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCorrecto = new System.Windows.Forms.Button();
            this.btnIncorrecto = new System.Windows.Forms.Button();
            this.btnRobo = new System.Windows.Forms.Button();
            this.tmTemporizador = new System.Windows.Forms.Timer(this.components);
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.btnAclaracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEq
            // 
            this.lblEq.AutoSize = true;
            this.lblEq.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEq.Location = new System.Drawing.Point(13, 9);
            this.lblEq.Name = "lblEq";
            this.lblEq.Size = new System.Drawing.Size(76, 18);
            this.lblEq.TabIndex = 1;
            this.lblEq.Text = "EQUIPO: ";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(85, 9);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(44, 18);
            this.lblEquipo.TabIndex = 1;
            this.lblEquipo.Text = "XXX";
            // 
            // lblSco
            // 
            this.lblSco.AutoSize = true;
            this.lblSco.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSco.Location = new System.Drawing.Point(293, 9);
            this.lblSco.Name = "lblSco";
            this.lblSco.Size = new System.Drawing.Size(66, 18);
            this.lblSco.TabIndex = 1;
            this.lblSco.Text = "SCORE: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(353, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(19, 18);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "N";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(499, 9);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(59, 18);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "TIME: ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(557, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(15, 18);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "0";
            // 
            // btnCorrecto
            // 
            this.btnCorrecto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrecto.Location = new System.Drawing.Point(63, 299);
            this.btnCorrecto.Name = "btnCorrecto";
            this.btnCorrecto.Size = new System.Drawing.Size(89, 35);
            this.btnCorrecto.TabIndex = 4;
            this.btnCorrecto.Text = "Correcto";
            this.btnCorrecto.UseVisualStyleBackColor = true;
            this.btnCorrecto.Visible = false;
            this.btnCorrecto.Click += new System.EventHandler(this.btnCorrecto_Click);
            // 
            // btnIncorrecto
            // 
            this.btnIncorrecto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncorrecto.Location = new System.Drawing.Point(203, 299);
            this.btnIncorrecto.Name = "btnIncorrecto";
            this.btnIncorrecto.Size = new System.Drawing.Size(89, 35);
            this.btnIncorrecto.TabIndex = 4;
            this.btnIncorrecto.Text = "Incorrecto";
            this.btnIncorrecto.UseVisualStyleBackColor = true;
            this.btnIncorrecto.Visible = false;
            this.btnIncorrecto.Click += new System.EventHandler(this.btnIncorrecto_Click);
            // 
            // btnRobo
            // 
            this.btnRobo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRobo.Location = new System.Drawing.Point(365, 299);
            this.btnRobo.Name = "btnRobo";
            this.btnRobo.Size = new System.Drawing.Size(89, 35);
            this.btnRobo.TabIndex = 4;
            this.btnRobo.Text = "Robo";
            this.btnRobo.UseVisualStyleBackColor = true;
            this.btnRobo.Visible = false;
            this.btnRobo.Click += new System.EventHandler(this.btnRobo_Click);
            // 
            // tmTemporizador
            // 
            this.tmTemporizador.Interval = 1000;
            this.tmTemporizador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(502, 91);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(339, 91);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(502, 59);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(170, 91);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(339, 59);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(16, 91);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(170, 59);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 59);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(16, 141);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(561, 143);
            this.txtPregunta.TabIndex = 5;
            this.txtPregunta.TextChanged += new System.EventHandler(this.txtPregunta_TextChanged_1);
            this.txtPregunta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPregunta_KeyPress_1);
            // 
            // btnAclaracion
            // 
            this.btnAclaracion.Location = new System.Drawing.Point(16, 357);
            this.btnAclaracion.Name = "btnAclaracion";
            this.btnAclaracion.Size = new System.Drawing.Size(75, 23);
            this.btnAclaracion.TabIndex = 6;
            this.btnAclaracion.Text = "Aclaración";
            this.btnAclaracion.UseVisualStyleBackColor = true;
            this.btnAclaracion.Visible = false;
            this.btnAclaracion.Click += new System.EventHandler(this.btnAclaracion_Click);
            // 
            // frmEliminatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 392);
            this.Controls.Add(this.btnAclaracion);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.btnRobo);
            this.Controls.Add(this.btnIncorrecto);
            this.Controls.Add(this.btnCorrecto);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSco);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblEq);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "frmEliminatoria";
            this.Text = "Eliminatoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEliminatoria_FormClosing);
            this.Load += new System.EventHandler(this.frmEliminatoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Label lblEq;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblSco;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCorrecto;
        private System.Windows.Forms.Button btnIncorrecto;
        private System.Windows.Forms.Button btnRobo;
        private System.Windows.Forms.Timer tmTemporizador;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Button btnAclaracion;
    }
}