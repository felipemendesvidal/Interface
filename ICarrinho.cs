namespace interface
{
    public interface ICarrinho
    {
         void AddProduto( Produto produtoAtr);
         void AlterarProduto(int codigoAtr, Produto alterarProdutoAtr);
         void LerProduto();
         void DeletarProduto(Produto produtoAtr);
         void MostrarTot();
         
    }
}