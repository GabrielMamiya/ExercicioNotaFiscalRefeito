using System;
using System.Collections.Generic;

namespace NotaFiscalRefazendoHard.dominio
{
    public class Pedido
    {

        public int codigo { get; set; }
        public DateTime data { get; set; }
        public List<ItemPedido> itensDoPedido { get; set; }

        public Pedido(int codigo, int dia, int mes, int ano)
        {
            this.codigo = codigo;
            data = new DateTime(ano, mes, dia);
            itensDoPedido = new List<ItemPedido>();
        }

        public double valorTotal(){
            double soma = 0.0;

            for (int i = 0; i < itensDoPedido.Count; i++){
                soma += itensDoPedido[i].subTotal();
            }

            return soma;
        }

        public override string ToString()
        {
            String s = "Pedido: " + codigo
                + "Data: " + data.Day + "/" + data.Month + "/" + data.Year + "\n"
                                 + "Itens: " + "\n";

            for (var i = 0; i < itensDoPedido.Count; i++){
                s += itensDoPedido[i] + "\n";
            }

            s += "Total do pedido: " + valorTotal();

            return s;

        }
    }
}
