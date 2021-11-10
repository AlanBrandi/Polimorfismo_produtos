using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Polimorfismo
{
    class Produto_importado : Produto
    {
        //variáveis + encapsulamento.
        public double Taxa { get; set; }
       public  double valorTaxa { get; set; }


        //instanciando produto + encapsulamento.
        public Produto_importado(string name, double preco, double taxa) : base(name, preco)
        {
            Taxa = taxa;
        }
        //método para taxar.
        public void Taxar(double preco)
        {
            valorTaxa = preco * Taxa;
            preco = valorTaxa - preco;
        }
        //método toString.
        public override string ToString()
        {
            return Nome + ", " + Preco + ", " + ("taxa: " + valorTaxa.ToString("F2") + ")");
        }
    }
}
