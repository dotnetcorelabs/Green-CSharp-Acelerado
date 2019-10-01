using System;

namespace ConsoleApp.Automovel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");

            Carro c = new Carro();
            Console.WriteLine($"Carro Velocidade Atual {c.GetVelocidadeAtual()}");
            Console.WriteLine($"Carro Acelerando 10");
            c.Acelerar(10);
            Console.WriteLine($"Carro Velocidade Atual {c.GetVelocidadeAtual()}");


            Motocicleta m = new Motocicleta();
            Console.WriteLine($"Motocicleta Velocidade Atual {m.GetVelocidadeAtual()}");
            Console.WriteLine($"Motocicleta Acelerando 10");
            m.Acelerar(10);
            Console.WriteLine($"Motocicleta Velocidade Atual {m.GetVelocidadeAtual()}");

            //Automovel auto = new Carro();
            Console.WriteLine("Digite qualquer tecla para terminar");
            Console.ReadKey();
        }
    }
}
