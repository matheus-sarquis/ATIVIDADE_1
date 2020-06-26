using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(DateTime.Now.Month < DataNasc.Month)
                idade = DateTime.Now.Year - DataNasc.Year -1;
            else
                idade = DateTime.Now.Year - DataNasc.Year;
            return idade;
        }

        public void Movimentar() { }
        public void Comunicar() { }
        public void Alimentar() { }
    }
}