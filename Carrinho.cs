using System;
using System.Collections.Generic;
namespace interface
{
    public class Carrinho
    {
        //criando a lista de produtos
        List<Produto> carrinho = new List<Produto>();

        //atributo 
        public float TotValor;

        //adicionando produtos na lista
        public void AddProduto( Produto produtoAtr){
            carrinho.Add(produtoAtr);
        }

        //alterar produtos da lista
        public void AlterarProduto(int codigoAtr, Produto alterarProdutoAtr){
            carrinho.Find(x => x.Codigo == codigoAtr).Nome = alterarProdutoAtr.Nome;
            carrinho.Find(x.Codigo == codigoAtr).Preco = alterarProdutoAtr.Preco;
        }

        //ler o produto
        public void LerProduto(){
            Console.WriteLine("----------Carrinho----------");
            Console.WriteLine("\n");

            //varredura pesquisar ais o foreach
            foreach (Produto item in carrinho){
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
        }

        //deletar produto
        public void DeletarProduto(Produto produtoAtr){
            carrinho.Remove(produtoAtr);
        }

        //mostrar total
        public void MostrarTot(){
            foreach(Produto item in carrinho){
                TotValor += item.Preco;
            }
            Console.WriteLine($"Valor Total: {TotValor}");
        }




        
    }
}