namespace Trivia_Literaria
{
    partial class frmAcceso
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
            this.btnEliminatoriaUno = new System.Windows.Forms.Button();
            this.btnEliminatoriaDos = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminatoriaUno
            // 
            this.btnEliminatoriaUno.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminatoriaUno.Location = new System.Drawing.Point(12, 37);
            this.btnEliminatoriaUno.Name = "btnEliminatoriaUno";
            this.btnEliminatoriaUno.Size = new System.Drawing.Size(114, 60);
            this.btnEliminatoriaUno.TabIndex = 0;
            this.btnEliminatoriaUno.Text = "&Eliminatoria 1";
            this.btnEliminatoriaUno.UseVisualStyleBackColor = true;
            this.btnEliminatoriaUno.Click += new System.EventHandler(this.btnEliminatoriaUno_Click);
            // 
            // btnEliminatoriaDos
            // 
            this.btnEliminatoriaDos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminatoriaDos.Location = new System.Drawing.Point(137, 37);
            this.btnEliminatoriaDos.Name = "btnEliminatoriaDos";
            this.btnEliminatoriaDos.Size = new System.Drawing.Size(114, 60);
            this.btnEliminatoriaDos.TabIndex = 1;
            this.btnEliminatoriaDos.Text = "&Eliminatoria 2";
            this.btnEliminatoriaDos.UseVisualStyleBackColor = true;
            this.btnEliminatoriaDos.Click += new System.EventHandler(this.btnEliminatoriaDos_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(268, 37);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(114, 60);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(337, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 320);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnEliminatoriaDos);
            this.Controls.Add(this.btnEliminatoriaUno);
            this.Name = "frmAcceso";
            this.Text = "Acceso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminatoriaUno;
        private System.Windows.Forms.Button btnEliminatoriaDos;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSalir;
    }
}

