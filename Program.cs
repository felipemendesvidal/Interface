using System;

namespace interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //obejto
           Carrinho car = new Carrinho();
           //itens da lista
            Produto p1 = new Produto(1, "teste1",70.89f);
            Produto p2 = new Produto(2, "teste2",250.89f);
            Produto p3 = new Produto(3, "teste3",350.89f);
            Produto p4 = new Produto(4, "teste4",90.89f);

            //adicionando
            car.AddProduto(p1);
            car.AddProduto(p2);
            car.AddProduto(p3);
            car.AddProduto(p4);

            //deletando item
            car.DeletarProduto(p4);

            //adiconando
            Produto AlterarProduto = new Produto(5,"teste5",123f);
            car.AlterarProduto(3, AlterarProduto);
            car.LerProduto();
            car.MostrarTot();

    
        }
    }
}
