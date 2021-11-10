using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Produto
    {
        //encapsulamento.
       public string Nome { get; set; }
       public double Preco { get; set; }
        //construtor padrão.
        public Produto()
        {
        }
         //construtor personalizado.
       public Produto(string nome, double preco)
       {
            Nome = nome;
            Preco = preco;
       }
        //método precoTag.
        public string precoTag()
        {
            return Nome + ", " + "R$" + Preco;
        }
    }
}
