using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Esta classe vai servir de base para a class Bike e Carro, pois ambos são veiculos e tem características em 
// comum, por isso, estas classes citadas herdam os atributos e métodos dessa classe, a classe pai

namespace ProgramacaoWeb_CSharp_Fatec.Heranca
{
    public class Veiculo
    {
        // ======================
        // Atributos
        // ======================
        public int numeroAssentos;
        public int numeroPortas;
        public bool temMotor;

        public string ExibirDados()
        {
            if(temMotor == true)
            {
                return "Tem motor (TRUE), tem " + numeroAssentos + " assentos e " + numeroPortas + " portas";
            }
            else
            {
                return "NÃO tem motor, o  número de assentos é: " + numeroAssentos + " e o Número de portas: " + numeroPortas;
            }
        }
    }
}