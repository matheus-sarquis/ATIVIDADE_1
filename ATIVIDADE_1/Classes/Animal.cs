using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Animal
    {
        #region Variáveis
        private string nome;
        private DateTime dataNasc;
        private char sexo;
        private bool carnivoro;
        private bool peçnhento;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public bool Carnivoro { get => carnivoro; set => carnivoro = value; }
        public bool Peçnhento { get => peçnhento; set => peçnhento = value; }
        public int Idade { get => idade; set => idade = value; }
        #endregion

        public void Movimentar() { }
        public void Comunicar() { }
        public void Alimentar() { }
    }
}