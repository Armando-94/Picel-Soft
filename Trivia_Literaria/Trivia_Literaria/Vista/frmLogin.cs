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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            #region Verificar Contraseña
                if (txtPassword.Text.Equals("NANCYTODOPODEROSA")){
                    //Accede la pantalla de Control
                    frmControl objControl = new frmControl();
                    this.Hide();
                    objControl.ShowDialog();
                    this.Close();
                }
                else {
                    //Indica que no es correcto el password
                    MessageBox.Show("Acceso Denegado");
                    txtPassword.Text = "";
                }
            #endregion
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Verificación de Enter
                if((int)e.KeyChar == 13){
                    btnAcceder_Click(sender, e);
                }
            #endregion
        }
    }
}
