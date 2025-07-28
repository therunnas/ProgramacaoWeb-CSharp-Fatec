using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramacaoWeb_CSharp_Fatec.Heranca
{
    // colocamos dessa forma ( Bike : Veiculo ) pois a classe Bike herda da classe veículo seus atributos e métodos
    public class Bike : Veiculo
    {
        public int velocidadeMaximoEmKmh;
    }
}