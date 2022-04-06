using System;
using Xunit;
using testeParadgima;

namespace testeParadgimaTestes
{
    public class ArvoreServiceTest
    {
        ArvoreService arvoreService = new ArvoreService();

        [Fact(DisplayName = "AdicionarNumeroEsquerda adiciona novo número a esquerda da arvore")]
        public void AdicionarNumeroEsquerda()
        {   
            //arrange
            ArvoreBranch arvore = new ArvoreBranch(1);

            //act
            arvoreService.AdicionarNumeroEsquerda(2, arvore);

            //assert

            Assert.Equal(2, arvore.Esquerda.Value);

        }

        [Fact(DisplayName = "AdicionarNumeroDireita adiciona novo número a esquerda da arvore")]
        public void AdicionarNumeroDireita()
        {
            //arrange
            ArvoreBranch arvore = new ArvoreBranch(1);

            //act
            arvoreService.AdicionarNumeroDireita(2, arvore);

            //assert

            Assert.Equal(2, arvore.Direita.Value);
        }

        [Fact(DisplayName = "CriarArvore  cria arvore com os valores informados")]
        public void CriarArvore()
        {
            //arrange
            int[] valores = new int[] { 2, 10, 1};

            //act
            ArvoreBranch arvoreCriada =  arvoreService.CriarArvore(valores);

            //assert
            Assert.Equal(10, arvoreCriada.Value);
            Assert.Equal(2, arvoreCriada.Esquerda.Value);

        }
        [Fact(DisplayName = "OrdernaArvore ordena os lados de forma descrecente")]
        public void OrdernaArvore()
        {
            //arrange
            ArvoreBranch arvore = new ArvoreBranch(1);
            arvore.Direita = new ArvoreBranch(2);
            arvore.Direita.Direita = new ArvoreBranch(3);

            arvore.Esquerda = new ArvoreBranch(10);
            arvore.Esquerda.Esquerda = new ArvoreBranch(9);

            //act
            arvoreService.OrdernaArvore(arvore);

            //assert
            Assert.True(arvore.Direita.Value > arvore.Direita.Direita.Value);

            Assert.True(arvore.Esquerda.Value > arvore.Esquerda.Esquerda.Value);
        }
    }
}
