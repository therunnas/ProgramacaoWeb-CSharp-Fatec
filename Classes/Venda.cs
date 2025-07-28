using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Classes
{
    public class Venda
    {
        // ======================
        // Atributos
        // ======================
        private int IdVenda;
        private DateTime DataVenda;
        private List<Produto> ListaProdutos;

        // ======================
        // Construtor
        // ======================
        public Venda(int idVenda, DateTime dataVenda, List<Produto> listaProdutos)
        {
            IdVenda = idVenda;
            DataVenda = dataVenda;
            ListaProdutos = listaProdutos;
        }

        public void getDadosVenda()
        {
            Console.WriteLine("\nID da venda: " + IdVenda);
            Console.WriteLine("Data da venda: " + DataVenda.ToString("dd/MM/yyyy"));
            Console.WriteLine("Lista de Produtos: " );

            foreach (var item in ListaProdutos)
            {
                Console.WriteLine("- Produto: " + item.ExibeDados());
            }
        }
    }
}