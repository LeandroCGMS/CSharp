using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero mamifero = new Mamifero();
            Humano homem = new Humano();
            Gato bichano = new Gato();

            homem.Falar();
            homem.Mamar();
            homem.Respirar();

            bichano.Arranhar();
            bichano.Mamar();
            bichano.Respirar();

            Mamifero animal = new Mamifero();
            animal.Mamar();
            animal.Respirar();
            homem.Lutar();
            Console.WriteLine();
            bichano.Lutar();
        }
    }

    class Mamifero
    {
        public virtual void Lutar()
        {
            Console.WriteLine("Mamíferos lutam entre si.");
        }

        public void Respirar()
        {
            Console.WriteLine("Eu respiro.");
        }

        public void Mamar()
        {
            Console.WriteLine("Eu mamo.");
        }
    }

    class Humano : Mamifero
    {
        public override void Lutar()
        {
            Console.WriteLine("Eu luto com armas.");
        }

        public void Falar()
        {
            Console.WriteLine("Eu falo.");
        }
    }

    class Gato : Mamifero
    {
        public void Arranhar()
        {
            Console.WriteLine("Eu arranho.");
        }
    }
}
