using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Classes
{
    public class Endereco
    {
        // ======================
        // Atributos
        // ======================
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cep;
        private string Cidade;
        private string Estado;

        // ======================
        // Construtor
        // ======================
        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        public string EnderecoCompleto()
        {
            return "Rua: "+ Rua + " \t Número: " + Numero + " \t Bairro: " + Bairro + "\t Cidade: " + Cidade + "\t CEP: " + Cep + "\t Estado: " + Estado;
        }

        public string EnderecoCurto()
        {
            return "Rua: " + Rua + " \t Número: " + Numero;
        }

        // ======================
        // Métodos Get
        // ======================
        public string getRua()
        {
            return Rua;
        }

        public string getNumero()
        {
            return Numero;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public string getCep()
        {
            return Cep;
        }

        public string getCidade()
        {
            return Cidade;
        }

        public string getEstado()
        {
            return Estado;
        }

        // ======================
        // Métodos Set
        // ======================
        public void setRua(string rua)
        {
            Rua = rua;
        }

        public void setNumero(string numero)
        {
            Numero = numero;
        }

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public void setCep(string cep)
        {
            Cep = cep;
        }

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void setEstado(string estado)
        {
            Estado = estado;
        }
    }
}