using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeParadgima
{
    public class ArvoreService
    {
        public ArvoreService()
        {

        }
        public ArvoreBranch CriarArvore(int[] valores)
        {
            ArvoreBranch arvoreBranch = new ArvoreBranch(valores[0]);
            bool esquerda = false;
            for (int x = 1; x < valores.Length; x++)
            {
                int numeroEntrada = valores[x];
                if (arvoreBranch.Value < numeroEntrada && !esquerda)
                {
                    esquerda = true;
                    var novoNode = new ArvoreBranch(numeroEntrada);
                    novoNode.Esquerda = arvoreBranch;
                    arvoreBranch = novoNode;
                }
                else
                {
                    if (!esquerda)
                    {
                        AdicionarNumeroEsquerda(numeroEntrada, arvoreBranch);
                    }
                    else
                    {
                        AdicionarNumeroDireita(numeroEntrada, arvoreBranch);
                    }
                }

            }
           return arvoreBranch;
        }

        public void AdicionarNumeroEsquerda(int value, ArvoreBranch raiz)
        {
            ArvoreBranch variavelDeBusca = raiz;
            if (variavelDeBusca.Esquerda == null)
            {
                variavelDeBusca.Esquerda = NovoNode(value);
            }
            else
            {
                AdicionarNumeroEsquerda(value, variavelDeBusca.Esquerda);

            }

        }

        public void AdicionarNumeroDireita(int value, ArvoreBranch raiz) {
            ArvoreBranch variavelDeBusca = raiz;
            if (variavelDeBusca.Direita == null)
            {
                variavelDeBusca.Direita = NovoNode(value);
            }
            else
            {
            AdicionarNumeroDireita(value, variavelDeBusca.Direita);

            }
        }

       public void OrdernaArvore(ArvoreBranch raiz)
        {
            OrdernaLadoEsquerdo(raiz);
            OrdernaLadoDireito(raiz);
        }
      
       private void OrdernaLadoEsquerdo(ArvoreBranch raiz)
        {
            ArvoreBranch variavelDeBusca = raiz.Esquerda;

            List<ArvoreBranch> values = new List<ArvoreBranch>();
            while (variavelDeBusca != null)
            {
                values.Add(variavelDeBusca);
                variavelDeBusca = variavelDeBusca.Esquerda;
            }

            values = (from value in values orderby value.Value descending select value).ToList();

            raiz.Esquerda = null;

            foreach (ArvoreBranch arvoreNode in values)
            {
                AdicionarNumeroEsquerda(arvoreNode.Value, raiz);
            }

        }


         private void OrdernaLadoDireito(ArvoreBranch raiz)
        {
            ArvoreBranch variavelDeBusca = raiz.Direita;

            List<ArvoreBranch> values = new List<ArvoreBranch>();
            while (variavelDeBusca != null)
            {
                values.Add(variavelDeBusca);
                variavelDeBusca = variavelDeBusca.Direita;
            }

            values = (from value in values orderby value.Value descending select value).ToList();

            raiz.Direita = null;

            foreach (ArvoreBranch arvoreNode in values)
            {
                AdicionarNumeroDireita(arvoreNode.Value, raiz);
            }

        }
        static  public ArvoreBranch NovoNode(int value) {
            return new ArvoreBranch(value);
        }

        public void ImprimirArvore(ArvoreBranch raiz)
        {
            Console.WriteLine("Raiz");
            Console.WriteLine(raiz.Value);
            Console.WriteLine("Lado Esquerdo:");
            ImprimirLadoEsquerdoArvore(raiz);
            Console.WriteLine("Lado Direito:");
            ImprimirLadoDireitoArvore(raiz);
       }
        private void ImprimirLadoEsquerdoArvore(ArvoreBranch raiz)
        {
            ArvoreBranch variavelDeBusca = raiz.Esquerda;
            while (variavelDeBusca != null)
            {
                Console.WriteLine(variavelDeBusca.Value);
                variavelDeBusca = variavelDeBusca.Esquerda;
            }
        }
         private void ImprimirLadoDireitoArvore(ArvoreBranch raiz)
        {
            ArvoreBranch variavelDeBusca = raiz.Direita;
            while (variavelDeBusca != null)
            {
                Console.WriteLine(variavelDeBusca.Value);
                variavelDeBusca = variavelDeBusca.Direita;
            }
        }
    }
}
