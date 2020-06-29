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
                picAnimal.BackgroundImage = Resources.Baleia_leite;
            }

            if (tipoAnimal == "cachorro")
            {
                picAnimal.BackgroundImage = Resources.Cachorro_leite;
            }

            if (tipoAnimal == "esquilo")
            {
                picAnimal.BackgroundImage = Resources.Esquilo_leite;
            }

            if (tipoAnimal == "gato")
            {
                picAnimal.BackgroundImage = Resources.Gato_leite;
            }

            if (tipoAnimal == "leao")
            {
                picAnimal.BackgroundImage = Resources.Leao_leite;
            }

            if (tipoAnimal == "morcego")
            {
                picAnimal.BackgroundImage = Resources.Morcego_leite;
            }

            if (tipoAnimal == "ornitorrinco")
            {
                picAnimal.BackgroundImage = Resources.Ornitorrinco_leite;
            }
        }
    }
}