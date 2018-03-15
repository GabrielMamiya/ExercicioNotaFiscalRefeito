using System;
namespace NotaFiscalRefazendoHard
{
    public class Produto
    {

        public int codigoDoProduto { get; set; }
        public string descricaoDoProduto { get; set; }
        public double precoDoProduto { get; set; }

        public Produto(int codigoDoProduto, string descricaoDoProduto, double precoDoProduto)
        {
            this.codigoDoProduto = codigoDoProduto;
            this.descricaoDoProduto = descricaoDoProduto;
            this.precoDoProduto = precoDoProduto;
        }

        public override string ToString()
        {
            return codigoDoProduto + ", "
                + descricaoDoProduto + ", "
                + precoDoProduto;
        }
    }
}
