using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Mamifero : Animal
    {
        #region Variáveis
        private int qtdMamas;
        private bool pelo;
        private string corPelo;

        public int QtdMamas { get => qtdMamas; set => qtdMamas = value; }
        public bool Pelo { get => pelo; set => pelo = value; }
        public string CorPelo { get => corPelo; set => corPelo = value; }
        #endregion

        public void Amamentar(string tipoAnimal, ref PictureBox picAnimal)
        {
            if (tipoAnimal == "baleia")
            {
                picAnimal.BackgroundImage = Resources.Baleia;//amamentar
            }

            if (tipoAnimal == "cachorro")
            {
                picAnimal.BackgroundImage = Resources.Cachorro;//amamentar
            }

            if (tipoAnimal == "esquilo")
            {
                picAnimal.BackgroundImage = Resources.Esquilo;//amamentar
            }

            if (tipoAnimal == "gato")
            {
                picAnimal.BackgroundImage = Resources.Gato;//amamentar
            }

            if (tipoAnimal == "leao")
            {
                picAnimal.BackgroundImage = Resources.Leão;//amamentar
            }

            if (tipoAnimal == "morcego")
            {
                picAnimal.BackgroundImage = Resources.Morcego;//amamentar
            }

            if (tipoAnimal == "ornitorrinco")
            {
                picAnimal.BackgroundImage = Resources.Ornitorrinco;//amamentar
            }
        }
    }
}