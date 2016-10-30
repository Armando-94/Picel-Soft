using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Literaria
{
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Agregar Trivia
                frmAgregarTrivia objAgregarTrivia = new frmAgregarTrivia();
                this.Hide();
                objAgregarTrivia.ShowDialog();
                this.Show();
            #endregion
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Consultar Trivia
                frmConsultarTrivia objConsultarTrivia = new frmConsultarTrivia();
                this.Hide();
                objConsultarTrivia.ShowDialog();
                this.Show();
            #endregion
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Agregar Equipo
                frmAgregarEquipos objAgregarEquipo = new frmAgregarEquipos();
                this.Hide();
                objAgregarEquipo.ShowDialog();
                this.Show();
            #endregion
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Eliminar Equipo
                frmEliminarEquipo objEliminarEquipo = new frmEliminarEquipo();
                this.Hide();
                objEliminarEquipo.ShowDialog();
                this.Show();
            #endregion
        }
    }
}
