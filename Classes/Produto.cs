using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Classes
{
    public class Produto
    {
        // ======================
        // Atributos
        // ======================
        private int Id;
        private decimal Valor;
        private string Descricao;

        // ======================
        // Construtor
        // ======================
        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }

        public string ExibeDados()
        {
            return "ID: " + Id + " \t\t Descrição: " + Descricao + " \t\t Valor: " + Valor;
        }

        // ======================
        // Métodos Get
        // ======================
        public string getDescricao()
        {
            return Descricao;
        }

        public decimal getValor()
        {
            return Valor;
        }

        public int getId()
        {
            return Id;
        }

        // ======================
        // Métodos Set
        // ======================
        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }

        public void setId(int id)
        {
            Id = id;
        }
    }
}