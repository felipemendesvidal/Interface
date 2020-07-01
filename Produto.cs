using System;
namespace interface
{
    public class Produto
    {
        /*Pesquisar mais formas de manipular o get e o set
         private byte cod;
         public byte Codigo{
            atribuindo o o cod para modificações e leitura
             get{return cod;}
             set{ cod = value;}
         }*/
        //-------------------------------------------------------------------
        //atributos
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public float Preco{get; set;}

        //construtor
        public Produto(){

        }
        public Produto(int cod, string nome, float preco){
            this.Codigo = cod;
            this.Nome = nome;
            this.Preco = preco;
        }

     }



}