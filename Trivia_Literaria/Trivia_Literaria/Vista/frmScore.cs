using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Literaria.Vista
{
    public partial class frmScore : Form
    {

        public frmScore()
        {
            InitializeComponent();
        }

        private string[] equipos, equiposSorted;
        private int[] score, ordenar,auxiliar;
        private Pojos.clsScore[] matriz;

        public frmScore(string[] equipos,int[] score) {
            InitializeComponent();
            this.equipos = equipos;
            this.score = score;
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            sort();
            llenarGrid();
        }

        #region Ordenar arreglo
        void sort() {
            ordenar=new int[score.Length];
            auxiliar = new int[score.Length];
            for (int i = 0; i < score.Length;i++ )
            {
                ordenar[i] = score[i];
                auxiliar[i]=score[i];
            }
            Array.Sort(ordenar);
            equiposSorted=new string[ordenar.Length];
            for (int i = 0; i < ordenar.Length;i++ )
            {
                for (int j = 0; j < ordenar.Length;j++ )
                {
                    if(ordenar[i]==auxiliar[j]){
                        equiposSorted[i] = equipos[j];
                        auxiliar[j] = -100;
                        break;
                    }
                }
            }
        }
        #endregion

        #region Llenar el grid
        void llenarGrid() {
            matriz=new Pojos.clsScore[ordenar.Length];
            int ctrl=0;
            for (int i = ordenar.Length-1; i >= 0;i-- )
            {
                matriz[ctrl] = new Pojos.clsScore(equiposSorted[i],ordenar[i]);
                ctrl++;
            }
            dgvScore.DataSource = matriz;
        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
