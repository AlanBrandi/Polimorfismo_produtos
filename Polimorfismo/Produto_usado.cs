using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Produto_usado : Produto
    {
        //Criação da variável tempo + encapsulamento.
        public DateTime Data { get; set; }
        //instanciando produto + encapsulamento.
        public Produto_usado(string nome, double preco, DateTime data) : base(nome, preco)
        {
            Data = data;
        }
        //método toString.
        public override string ToString()
        {
            return Nome+ ", " + Preco + ", " + ("fabricado: (" + Data.Day.ToString() + "/"+ Data.Month.ToString() + "/" + Data.Year.ToString() + ")");
        }



    }
}
