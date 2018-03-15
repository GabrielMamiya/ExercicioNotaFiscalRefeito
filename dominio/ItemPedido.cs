using System;
using System.Collections.Generic;

namespace NotaFiscalRefazendoHard.dominio
{
    public class ItemPedido
    {

        public int quantidade { get; set; }
        public double porcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public ItemPedido(int quantidade, double porcentagemDesconto, Pedido pedido, Produto produto)
        {
            this.quantidade = quantidade;
            this.porcentagemDesconto = porcentagemDesconto;
            this.produto = produto;
            this.pedido = pedido;
        }

        public double subTotal(){
            double desconto = produto.precoDoProduto * (porcentagemDesconto / 100);
            return (produto.precoDoProduto - desconto) * quantidade;
        }

        public override string ToString()
        {
            return produto.codigoDoProduto + ", Preco: " + produto.precoDoProduto + ", Qte: " + quantidade + ", Desconto: " + porcentagemDesconto + "%, Subtotal: " + subTotal(); 
        }
    }
}
