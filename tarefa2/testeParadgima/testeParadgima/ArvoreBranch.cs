using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeParadgima
{
    public class ArvoreBranch
    {
        public int Value { get; set; }

        public ArvoreBranch Direita;

        public ArvoreBranch Esquerda;


        public ArvoreBranch(int Value) {
            this.Value = Value;
        }
    }
}
