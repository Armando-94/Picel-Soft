namespace Trivia_Literaria.Vista
{
    partial class frmAgregarEquiposTrivia
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
            this.cmbTrivias = new System.Windows.Forms.ComboBox();
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTrivia = new System.Windows.Forms.Label();
            this.lblEquipos = new System.Windows.Forms.Label();
            this.dgvEquiposTrivia = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposTrivia)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTrivias
            // 
            this.cmbTrivias.FormattingEnabled = true;
            this.cmbTrivias.Items.AddRange(new object[] {
            "Trivia A",
            "Trivia B"});
            this.cmbTrivias.Location = new System.Drawing.Point(146, 31);
            this.cmbTrivias.Name = "cmbTrivias";
            this.cmbTrivias.Size = new System.Drawing.Size(121, 21);
            this.cmbTrivias.TabIndex = 0;
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Location = new System.Drawing.Point(146, 88);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(74, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblTrivia
            // 
            this.lblTrivia.AutoSize = true;
            this.lblTrivia.Location = new System.Drawing.Point(13, 31);
            this.lblTrivia.Name = "lblTrivia";
            this.lblTrivia.Size = new System.Drawing.Size(33, 13);
            this.lblTrivia.TabIndex = 3;
            this.lblTrivia.Text = "Trivia";
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.Location = new System.Drawing.Point(16, 88);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(45, 13);
            this.lblEquipos.TabIndex = 4;
            this.lblEquipos.Text = "Equipos";
            // 
            // dgvEquiposTrivia
            // 
            this.dgvEquiposTrivia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquiposTrivia.Location = new System.Drawing.Point(19, 175);
            this.dgvEquiposTrivia.Name = "dgvEquiposTrivia";
            this.dgvEquiposTrivia.Size = new System.Drawing.Size(303, 177);
            this.dgvEquiposTrivia.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(329, 233);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarEquiposTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 382);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvEquiposTrivia);
            this.Controls.Add(this.lblEquipos);
            this.Controls.Add(this.lblTrivia);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEquipos);
            this.Controls.Add(this.cmbTrivias);
            this.Name = "frmAgregarEquiposTrivia";
            this.Text = "Seleccionar Equipos para trivia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposTrivia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTrivias;
        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTrivia;
        private System.Windows.Forms.Label lblEquipos;
        private System.Windows.Forms.DataGridView dgvEquiposTrivia;
        private System.Windows.Forms.Button btnAceptar;
    }
}