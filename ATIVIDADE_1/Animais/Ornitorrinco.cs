using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Ornitorrinco(string nome, DateTime nasc, int idade, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Idade = idade;
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

        public void Botar() { }
        public void Chocar() { }
    }
}