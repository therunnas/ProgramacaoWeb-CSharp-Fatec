using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Classes
{
    public class Cliente
    {
        // ======================
        // Atributos
        // ======================
        private int Id;
        public string Nome;
        public string Telefone;

        // Note que aqui definimos que o tipo de dado que irá para esse atributo será do tipo Endereco (class Endereco.cs)
        private Endereco Endereco;

        // ======================
        // Construtor
        // ======================
        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        // ======================
        // Métodos Get
        // ======================

        // É valido notar aqui que o tipo de dado que esta função irá retornar é do tipo Endereco
        // Pois estamos usando a classe Endereco para isso
        // Com isso, ao retornamos esse tipo de dado podemos usar os métodos que a classe Endereco tem também
        public Endereco getEndereco()
        {
            return Endereco;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public string ExibeDadosClientes()
        {
            return "\nID: " + Id + "\n Nome: " + Nome + "\n Telefone: " + Telefone + "\n Endereço: ";
        }

        // ======================
        // Métodos Set
        // ======================
        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}