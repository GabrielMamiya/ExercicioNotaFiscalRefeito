using System;
using System.Globalization;
using NotaFiscalRefazendoHard.dominio;

namespace NotaFiscalRefazendoHard
{
    public class Tela
    {
        
        public static void exibirMenu(){
            Console.WriteLine("1 - Listar os Produtos");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Cadastrar Pedido");
            Console.WriteLine("4 - Mostrar Dados de um Pedido");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
        }

        public static void exibirProdutos(){
            for (int i = 0; i < MainClass.listaDeProdutos.Count; i++){
                Console.WriteLine(MainClass.listaDeProdutos[i]);
            }
        }

        public static void cadastrarProduto(){
            Console.WriteLine("Digite os dados do produto: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descricao: ");
            string descricao = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(codigo, descricao, preco);
            MainClass.listaDeProdutos.Add(p);
            Console.Clear();
        }

        public static void cadastrarPedido(){
            Console.WriteLine("Digite os dados do Pedido: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido p = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quantos itens tem o pedido? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++){
                Console.WriteLine("Digite os dados do " + (i + 1) + " item: ");
                Console.Write("Produto (Codigo) : ");
                int codProduto = int.Parse(Console.ReadLine());
                int pos = MainClass.listaDeProdutos.FindIndex(x => x.codigoDoProduto == codProduto);
                if(pos == -1){
                    Console.WriteLine("O codigo do produto nao foi encontrado!");
                } 
                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de Desconto: ");
                int porcentagemDeDesconto = int.Parse(Console.ReadLine());

                ItemPedido ip = new ItemPedido(qte, porcentagemDeDesconto, p, MainClass.listaDeProdutos[pos]);

                p.itensDoPedido.Add(ip);
            }

            MainClass.listaDePedidos.Add(p);

        }

        public static void mostrarPedidos(){
            Console.Write("Digite o codigo do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());

            int pos = MainClass.listaDePedidos.FindIndex(x => x.codigo == codPedido);

            if(pos == -1){
                Console.WriteLine("Codigo do pedido nao encontrado!");
            }

            Console.Write(MainClass.listaDePedidos[pos]);
        }

    }
}
