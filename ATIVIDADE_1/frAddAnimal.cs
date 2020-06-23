using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    public partial class frAddAnimal : Form
    {
        public frAddAnimal()
        {
            InitializeComponent();
        }

        public void LimpaCampos()
        {
            txtData.Clear();
            txtNome.Clear();
            cbAnimal.Text = "";
            cbCorPelos.Text = "";
            cbCorPena.Text = "";
            cbSexo.Text = "";
            nupIdade.Value = 0;
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            switch (cbAnimal.SelectedItem)
            {
                case "Baleia":
                    break;

                case "Cachorro":
                    break;

                case "Coruja":
                    break;

                case "Gato":
                    break;

                case "Gavião":
                    break;

                case "Leão":
                    break;

                case "Morcego":
                    break;

                case "Ornitorrinco":
                    break;

                case "Pato":
                    break;

                case "Pinguim":
                    break;

                case "Pombo":
                    break;

                case "Tartaruga":
                    break;

                default:
                    MessageBox.Show("Selecione um Animal");
                    break;
            }
        }
    }
}