﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class Gato : Mamifero, IPredador
    {
        public void Atacar() { }

        public Gato(string nome, DateTime nasc, int idade, char sexo)
        {
            Nome = nome;
            DataNasc = nasc;
            Idade = idade;
            Sexo = sexo;

            QtdMamas = 8;
            Pelo = true;
            CorPelo = "Cinza"; //<------------------------------------------------------------------------------
            Carnivoro = true;
            Peconhento = false;
        }
    }
}