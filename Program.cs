using System;
using System.Globalization;
using System.Collections.Generic;
using NotaFiscalRefazendoHard.dominio;

namespace NotaFiscalRefazendoHard
{
    class MainClass
    {

        public static List<Produto> listaDeProdutos = new List<Produto>();
        public static List<Pedido> listaDePedidos = new List<Pedido>();

        public static void Main(string[] args)
        {

            listaDeProdutos.Add(new Produto(1001, "Cadeira Simples", 500.00));
            listaDeProdutos.Add(new Produto(1002, "Cadeira Alcochoada", 900.00));
            listaDeProdutos.Add(new Produto(1003, "Sofa de Tres Lugares", 2000.00));
            listaDeProdutos.Add(new Produto(1004, "Mesa Retangular", 1500.00));
            listaDeProdutos.Add(new Produto(1005, "Mesa Retangular Grande", 2000.00));

            int opcao;

            opcao = 0;

            while(opcao != 5){

                Tela.exibirMenu();
                Console.Write("Escolha uma das opcoes: ");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1){
                    try{
                        Console.WriteLine();
                        Console.WriteLine("LISTAGEM DE PRODUTOS: ");
                        Tela.exibirProdutos();
                        Console.WriteLine();
                    } 
                    catch (Exception e){
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 2) {
                    try{
                        Console.WriteLine();
                        Tela.cadastrarProduto();
                    }
                    catch( Exception e){
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 3) {
                    try{
                        Console.WriteLine();
                        Tela.cadastrarPedido();
                    }
                    catch(Exception e){
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                } else if (opcao == 4) {
                    try{
                        Console.WriteLine();
                        Tela.mostrarPedidos();
                    } catch (Exception e){
                        Console.WriteLine("Erro inesperado " + e.Message);
                    }
                } else if (opcao == 5) {
                    Console.WriteLine("Obrigado por usar nosso programa!");
                }



            }
        }
    }
}
