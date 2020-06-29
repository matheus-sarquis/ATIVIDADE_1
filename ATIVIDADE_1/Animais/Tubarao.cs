using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Tubarao : Animal, IOviparo, IAquatico, IPredador
    {
        #region Variáveis
        private bool viveEmT;
        private bool mergulho;
        private bool aguaDoce;

        public bool ViveEmT { get => viveEmT; set => viveEmT = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
        #endregion

        public void Atacar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Tubarão_atacando;
        }

        public void Botar(ref PictureBox picAnimal) { }
        public void Chocar(ref PictureBox picAnimal) { }

        public Tubarao(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            ViveEmT = false;
            Mergulho = true;
            AguaDoce = false;
            Carnivoro = true;
            Peconhento = false;
        }
    }
}
