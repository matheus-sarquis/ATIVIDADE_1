using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    public class Animal
    {
        #region Variáveis
        private string nome;
        private DateTime dataNasc;
        private char sexo;
        private bool carnivoro;
        private bool peconhento;

        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public bool Carnivoro { get => carnivoro; set => carnivoro = value; }
        public bool Peconhento { get => peconhento; set => peconhento = value; }
        #endregion

        public int Idade()
        {
            int idade = 0;
            if (DateTime.Now.Month < DataNasc.Month)
                idade = DateTime.Now.Year - DataNasc.Year - 1;
            else
                idade = DateTime.Now.Year - DataNasc.Year;
            return idade;
        }

        public void Movimentar() { }

        public void Comunicar(ref PictureBox picAnimal, string tipoAnimal)
        {
            if (tipoAnimal == "baleia")
            {
                picAnimal.BackgroundImage = Resources.Baleia;//comunicando
            }

            if (tipoAnimal == "cachorro")
            {
                picAnimal.BackgroundImage = Resources.Cachorro;//comunicando
            }

            if (tipoAnimal == "coruja")
            {
                picAnimal.BackgroundImage = Resources.Coruja;//comunicando
            }

            if (tipoAnimal == "esquilo")
            {
                picAnimal.BackgroundImage = Resources.Esquilo;//comunicando
            }

            if (tipoAnimal == "gato")
            {
                picAnimal.BackgroundImage = Resources.Gato;//comunicando
            }

            if (tipoAnimal == "gaviao")
            {
                picAnimal.BackgroundImage = Resources.Gavião;//comunicando
            }

            if (tipoAnimal == "leao")
            {
                picAnimal.BackgroundImage = Resources.Leão;//comunicando
            }

            if (tipoAnimal == "morcego")
            {
                picAnimal.BackgroundImage = Resources.Morcego;//comunicando
            }

            if (tipoAnimal == "ornitorrinco")
            {
                picAnimal.BackgroundImage = Resources.Ornitorrinco;//comunicando
            }
            if (tipoAnimal == "pato")
            {
                picAnimal.BackgroundImage = Resources.Pato;//comunicando
            }
            if (tipoAnimal == "pinguim")
            {
                picAnimal.BackgroundImage = Resources.Pinguim;//comunicando
            }
            if (tipoAnimal == "pombo")
            {
                picAnimal.BackgroundImage = Resources.Pombo;//comunicando
            }
            if (tipoAnimal == "tartaruga")
            {
                picAnimal.BackgroundImage = Resources.Tartaruga;//comunicando
            }
            if (tipoAnimal == "tubarao")
            {
                picAnimal.BackgroundImage = Resources.Tubarão;//comunicando
            }
        }

        public void Alimentar(ref PictureBox picAnimal, string tipoAnimal)
        {
            if (tipoAnimal == "baleia")
            {
                picAnimal.BackgroundImage = Resources.Baleia_comendo;
            }

            if (tipoAnimal == "cachorro")
            {
                picAnimal.BackgroundImage = Resources.Cachorro_comendo;
            }

            if (tipoAnimal == "coruja")
            {
                picAnimal.BackgroundImage = Resources.Coruja_comendo;
            }

            if (tipoAnimal == "esquilo")
            {
                picAnimal.BackgroundImage = Resources.Esquilo_comendo;
            }

            if (tipoAnimal == "gato")
            {
                picAnimal.BackgroundImage = Resources.Gato_comendo;
            }

            if (tipoAnimal == "gaviao")
            {
                picAnimal.BackgroundImage = Resources.Gavião_comendo;
            }

            if (tipoAnimal == "leao")
            {
                picAnimal.BackgroundImage = Resources.Leão_comendo;
            }

            if (tipoAnimal == "morcego")
            {
                picAnimal.BackgroundImage = Resources.Morcego_comendo;
            }

            if (tipoAnimal == "ornitorrinco")
            {
                picAnimal.BackgroundImage = Resources.Ornitorrinco_comendo;
            }
            if (tipoAnimal == "pato")
            {
                picAnimal.BackgroundImage = Resources.Pato_comendo;
            }
            if (tipoAnimal == "pinguim")
            {
                picAnimal.BackgroundImage = Resources.Pinguim_comendo;
            }
            if (tipoAnimal == "pombo")
            {
                picAnimal.BackgroundImage = Resources.Pombo_comendo;
            }
            if (tipoAnimal == "tartaruga")
            {
                picAnimal.BackgroundImage = Resources.Tartaruga_comendo;
            }
            if (tipoAnimal == "tubarao")
            {
                picAnimal.BackgroundImage = Resources.Tubarão_comendo;
            }
        }
    }
}