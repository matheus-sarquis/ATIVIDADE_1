using ATIVIDADE_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_1
{
    class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        #region Variáveis
        private bool viveEmT;
        private bool mergulho;
        private bool aguaDoce;

        public bool ViveEmT { get => viveEmT; set => viveEmT = value; }
        public bool Mergulho { get => mergulho; set => mergulho = value; }
        public bool AguaDoce { get => aguaDoce; set => aguaDoce = value; }
        #endregion

        public Ornitorrinco(string nome, DateTime nasc, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Sexo = sexo;

            ViveEmT = true;
            Mergulho = true;
            AguaDoce = true;
            Carnivoro = false;
            Peconhento = true;
            QtdMamas = 0;
            Pelo = true;
            CorPelo = "Marrom";
        }

        public void Botar(ref PictureBox picAnimal)
        {
            picAnimal.BackgroundImage = Resources.Ornitorrinco_com_ovo;
        }

        public void Chocar(ref PictureBox picAnimal)
        {           
        }
    }
}