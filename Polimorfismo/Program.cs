using System;
using System.Globalization;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pegando quantos produtos serão adicionados.
            Console.WriteLine("Quantos produtos serão adicionados?");
            int QtProdutos = int.Parse(Console.ReadLine());
            //Criando variável data.
            DateTime Data;
            //Criando as listas de cada produto.
            List<Produto> listComum = new List<Produto>();
            List<Produto_importado> listImportado = new List<Produto_importado>();
            List<Produto_usado> listUsado = new List<Produto_usado>();
            //Pedindo informações ao cliente.
            for (int i = 1; i <= QtProdutos; i++)
            {
                //Buscando quando tipo de produto vai ser.
                Console.WriteLine($"Produto#{i}");
                Console.WriteLine("Comum, usado ou importado? (C/U/I)");
                char ch = char.Parse(Console.ReadLine());
                //Se a caso for comum entre aqui.
                if (ch == 'C')
                {
                   //Pegando informações básicas.
                    Console.WriteLine("Nome: ");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Preço: ");
                    double Preco = double.Parse(Console.ReadLine());
                    //Adicionando o produto na lista.
                    listComum.Add(new Produto(Nome, Preco));
                    
                }
                //Se a caso for usado entre aqui.
                else if (ch == 'U')
                {
                    //Informações básicas.
                    Console.WriteLine("Nome: ");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Preço: ");
                    double Preco = double.Parse(Console.ReadLine());
                    //Pegando a data.
                    Console.WriteLine("Data de fabricação(Dia)[DD]:");
                    int Dia = int.Parse(Console.ReadLine());
                    Console.WriteLine("Data de fabricação(Mês)[MM]:");
                    int Mes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Data de fabricação(Ano)[AAAA]:");
                    int Ano = int.Parse(Console.ReadLine());
                    //Criando a data.
                    Data = new DateTime(Ano,Mes,Dia);
                    //Adicionando na lista.
                    listUsado.Add(new Produto_usado(Nome, Preco, Data));
                }
                //Se a caso for importado entre aqui.
                else if (ch == 'I')
                {
                    //Informações básicas.
                    Console.WriteLine("Nome: ");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Preço: ");
                    double Preco = double.Parse(Console.ReadLine());
                    //Pegando a taxa.
                    Console.WriteLine("Taxa: ");
                    double Taxa = double.Parse(Console.ReadLine());
                    //Adicionando na lista.
                    listImportado.Add(new Produto_importado(Nome, Preco, Taxa));
                    listImportado[i-1].Taxar(Preco);
                }
            }
            //Mostrando cada produto.
            Console.WriteLine("Etiquetas: ");
            //Percorrendo por quando produtos existem.
           for(int i = 0; i < QtProdutos; i++)
           {
                //Mostrar todos da lista comum caso não esteja vazio.
                if (listComum != null)
                {
                    Console.WriteLine(listComum[i].precoTag());
                }
                //Mostrar todos da lista usado caso não esteja vazio.
                else if (listUsado != null)
                {
                    Console.WriteLine(listUsado[i].ToString());
                }
                //Mostrar todos da lista Importado caso não esteja vazio.
                else if (listImportado != null)
                {
                    Console.WriteLine(listImportado[i].ToString());
                }
           }

        }
            
    }
}
    

