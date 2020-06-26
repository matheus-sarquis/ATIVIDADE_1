using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    class ArvoreBin
    {
        private Nodo raiz = null; // raiz da árvore
        private int qtdeNodosInternos = 0; // qtde de nos internos
        private int numeroIdade = 0;
        private int numAuxVetor = 0;
        private string resultado = ""; // utilizada na listagem dos nodos 
        /// <summary>
        /// Returna a qtde de nós internos
        /// </summary>
        /// <returns></returns>
        public int QtdeNodosInternos() // devolve a qtde de nós internos
        {
            return qtdeNodosInternos;
        }
        /// <summary>
        /// Insere um valor na árvore. Não aceita valores repetidos!!!
        /// </summary>
        /// <param name="valor">valor a ser inserido</param>
        public void Insere(Animal valor) // insere um valor int
        {
            Nodo no_aux;
            if (qtdeNodosInternos == 0) // árvore vazia!
            {
                // árvore vazia, devemos criar o primeiro Nodo, que será a raiz
                no_aux = new Nodo();
                raiz = no_aux;
            }
            else
            {
                // localiza onde deve ser inserido o novo nó.
                no_aux = PesquisaValor(valor, raiz);
                if (no_aux.EhInterno())
                {
                    throw new Exception("Este valor já existe na árvore!!!!");
                }
            }
            // este era um Nodo externo e portanto não tinha filhos.
            // Agora ele passará a ser interno, portanto devemos criar outros 2
            // nodos externos (filhos) para ele.
            no_aux.SetValor(valor);
            no_aux.SetNoEsquerda(Nodo.CriaNoExterno(no_aux));
            no_aux.SetNoDireita(Nodo.CriaNoExterno(no_aux));
            qtdeNodosInternos++;
        }
        private void PercursoInterfixadoNome(Nodo no)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixadoNome(no.GetNoEsquerda());
            resultado += " - " + no.GetAnimal().Nome + Environment.NewLine;
            PercursoInterfixadoNome(no.GetNoDireita());
        }
        /// <summary>
        /// Devolve um string com os elementos da árvore, em ordem alfabetica
        /// </summary>
        /// <returns></returns>
        public string ListagemNomesEmOrdem()
        {
            resultado = "";
            if (qtdeNodosInternos != 0)
                PercursoInterfixadoNome(raiz);
            return resultado;
        }

        private void PercursoInterfixadoClass(Nodo no, string classe)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixadoClass(no.GetNoEsquerda(), classe);
            if (no.GetAnimal().GetType().BaseType.Name == classe)
                resultado += " - " + no.GetAnimal().Nome + Environment.NewLine;
            PercursoInterfixadoClass(no.GetNoDireita(), classe);
        }
        /// <summary>
        /// Devolve um string com os elementos da árvore, de acordo com uma classe herdada
        /// </summary>
        /// <returns></returns>
        public string ListagemClassesEmOrdem(string classe)
        {
            resultado = "";
            if (qtdeNodosInternos != 0)
                PercursoInterfixadoClass(raiz, classe);
            return resultado;
        }

        private void PercursoInterfixadoInterface(Nodo no, string inter)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixadoInterface(no.GetNoEsquerda(), inter);
            object[] interfaces = new object[4];
            interfaces = no.GetAnimal().GetType().GetInterfaces();
            foreach (object interfac in interfaces)
            {
                if (interfac.ToString().Contains(inter))
                    resultado += " - " + no.GetAnimal().Nome + Environment.NewLine;
            }
            PercursoInterfixadoInterface(no.GetNoDireita(), inter);
        }
        /// <summary>
        /// Devolve um string com os elementos da árvore, de acordo com as Interfaces
        /// </summary>
        /// <returns></returns>
        public string ListagemInterfaceEmOrdem(string inter)
        {
            resultado = "";
            if (qtdeNodosInternos != 0)
                PercursoInterfixadoInterface(raiz, inter);
            return resultado;
        }

        private void PercursoInterfixadoIdade(Nodo no, Animal[] animals)
        {

            if (no.EhExterno())
                return;

            PercursoInterfixadoIdade(no.GetNoEsquerda(), animals);
            animals[numeroIdade++] = no.GetAnimal();
            PercursoInterfixadoIdade(no.GetNoDireita(), animals);
        }
        /// <summary>
        /// Devolve um string com os elementos da árvore, em ordem alfabetica
        /// </summary>
        /// <returns></returns>
        public string ListagemIdadeEmOrdem()
        {
            numeroIdade = 0;
            resultado = "";
            Animal[] animals = new Animal[qtdeNodosInternos];
            if (qtdeNodosInternos != 0)
                PercursoInterfixadoIdade(raiz, animals);
            //animals = animals.OrderBy(o => o.Idade()).ToArray();
            return ColocaremOrdemNum(animals);
        }

        public string ColocaremOrdemNum(Animal[] animals)
        {
            int i;
            Animal[] a = new Animal[qtdeNodosInternos];
            a = animals;
            //Sorting the values  
            for (i = 0; i <= qtdeNodosInternos; i++)
            {
                for (int j = 0; j <= qtdeNodosInternos - 2; j++)
                {
                    if (a[j].Idade() > a[j + 1].Idade())
                    {
                        Animal temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            string conteudo = "";
            for (i = 1; i <= qtdeNodosInternos - 1; i++)
            {
                conteudo += $" - {a[i].Nome}" + Environment.NewLine;
            }
            return conteudo;
        }

        public Animal[] PegaAnimais()
        {
            numAuxVetor = 0;
            Animal[] vetor = new Animal[qtdeNodosInternos];
            PercursoInterfixadoAnimal(raiz, ref vetor);
            return vetor;
        }
        private void PercursoInterfixadoAnimal(Nodo no, ref Animal[] animals)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixadoAnimal(no.GetNoEsquerda(),ref animals);
            animals[numAuxVetor++] = no.GetAnimal();
            PercursoInterfixadoAnimal(no.GetNoDireita(),ref animals);
        }
        /// <summary>
        /// Pesquisa um nodo na árvore e devolve o nodo. Caso não encontre, devolve o nodo
        /// externo onde a pesquisa parou.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        private Nodo PesquisaValor(Animal valor, Nodo no)
        {
            if (no.EhExterno())
                return no; // não achou!
            else if (valor.Nome.CompareTo(no.GetAnimal().Nome) == 0)
                return no;
            else if (valor.Nome.CompareTo(no.GetAnimal().Nome) == 1)
                return PesquisaValor(valor, no.GetNoDireita());
            else
                return PesquisaValor(valor, no.GetNoEsquerda());
        }
        /// <summary>
        /// Remove um valor da árvore
        /// </summary>
        /// <param name="valor"></param>
        public void Remove(Animal valor)
        {
            //primeiro, procuramos o nodo que tem o valor:
            Nodo noQueSeraApagado = PesquisaValor(valor, raiz);
            if (noQueSeraApagado == null || noQueSeraApagado.EhExterno())
                throw new Exception("Valor não existe na árvore");
            else
            {
                // um dos filhos é um nó externo
                if (noQueSeraApagado.GetNoEsquerda().EhExterno() ||
                noQueSeraApagado.GetNoDireita().EhExterno())
                {
                    ExcluiComNodoExterno(noQueSeraApagado);
                }
                else
                {
                    ExcluiSemNodoExterno(noQueSeraApagado);
                }
            }
        }
        /// <summary>
        /// Exclui um nodo que abaixo dele possua, ao menos, 1 nodo exteno.
        /// </summary>
        /// <param name="noQueSeraApagado"></param>
        private void ExcluiComNodoExterno(Nodo noQueSeraApagado)
        {
            qtdeNodosInternos--;
            //descobre quem será o nodo que irá ficar no lugar do que foi apagado
            Nodo nodo_substituto;
            if (noQueSeraApagado.GetNoEsquerda().EhInterno())
                nodo_substituto = noQueSeraApagado.GetNoEsquerda();
            else
                nodo_substituto = noQueSeraApagado.GetNoDireita();
            // substitui o apagado pelo novo nodo
            Nodo PaiNodoApagado = noQueSeraApagado.GetNoPai();
            //altera o pai do novo substituto
            nodo_substituto.SetNoPai(PaiNodoApagado);
            //o pai do nodo substituto também deve ter sua referência de filho corrigida.
            //mas primeiro precisamos saber o no apagado er a raiz, que neste caso não tem pai.
            if (PaiNodoApagado != null)
            {
                if (PaiNodoApagado.GetNoDireita() == noQueSeraApagado)
                    PaiNodoApagado.SetNoDireita(nodo_substituto);
                else
                    PaiNodoApagado.SetNoEsquerda(nodo_substituto);
            }
            else
                raiz = nodo_substituto;
        }
        /// <summary>
        /// Pesquisa o próximo nodo Interno seguindo o percurso interfixado.
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        private Nodo PesquisaNodoInternoInterfixado(Nodo no)
        {
            if (no.EhExterno())
                return null;
            Nodo retorno = PesquisaNodoInternoInterfixado(no.GetNoEsquerda());
            if (retorno == null)
                return no;
            else
                return retorno;
        }
        /// <summary>
        /// Exclui um nodo que abaixo dele não há nodos externos.
        /// </summary>
        /// <param name="noQueSeraApagado"></param>
        private void ExcluiSemNodoExterno(Nodo noQueSeraApagado)
        {
            //encontra o nodo substituto
            Nodo NodoSubstituto = PesquisaNodoInternoInterfixado(noQueSeraApagado.GetNoDireita());
            Console.Write("Nodo substituto: " + NodoSubstituto.GetAnimal());
            //Altera o valor do nodo que será removido pelo valor do nodo substituto
            noQueSeraApagado.SetValor(NodoSubstituto.GetAnimal());
            //Remove o nodo substituto
            ExcluiComNodoExterno(NodoSubstituto);
        }
    }
}