using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Heranca
{
    // colocamos dessa forma ( Carro : Veiculo ) pois a classe Bike herda da classe veículo seus atributos e métodos
    public class Carro : Veiculo
    {
        public bool cintoSeguranca;
        public bool arCondicionado;
        public string marcaRadio;
        public string fabricante;

        public string ExibirMarca()
        {
            return "O fabricante deste veiculo é: " + fabricante;
        }

        public string ExibeDados()
        {
            return "Cinto de segurança: " + cintoSeguranca + " \t Ar condicionado: " + arCondicionado + " \t Marca do rádio: " + marcaRadio + " \t Fabricante: " + fabricante;
        }
    }
}