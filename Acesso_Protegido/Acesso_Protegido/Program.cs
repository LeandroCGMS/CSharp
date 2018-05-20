using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso_Protegido
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovel meuCarro = new Automovel();
            meuCarro.DadosAutomovel();
            meuCarro.MostraChassis();
            Console.WriteLine(meuCarro.portas.ToString());

            Veiculo veiculo = new Veiculo();
        }
    }

    class Veiculo
    {
        // Campo protegido
        protected string _placa;

        // Campo privado
        private String _chassis;

        // Campo Público
        public int portas;

        // Método construtor
        public Veiculo()
        {
            this._placa = "AAA-0000";
            this._chassis = "00000000000000000";
            this.portas = 4;
        }
        public void MostraChassis()
        {
            // O chassis só é acessível de dentro da própria classe
            Console.WriteLine("O chassis é {0}", this._chassis);
        }
    }

    // Classe Derivada
    class Automovel : Veiculo
    {
        public void DadosAutomovel()
        {
            Console.WriteLine("A placa do auto é {0}", this._placa); 
        }
    }
}
