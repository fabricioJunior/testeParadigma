using System;

namespace testeParadgima
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayEntrada = new int[] { 7, 5, 13, 9, 1, 6, 4 };
            ArvoreService arvoreService = new ArvoreService();

            ArvoreBranch arvore = arvoreService.CriarArvore(arrayEntrada);

            arvoreService.OrdernaArvore(arvore);

            arvoreService.ImprimirArvore(arvore);
            
        }
    }
}
