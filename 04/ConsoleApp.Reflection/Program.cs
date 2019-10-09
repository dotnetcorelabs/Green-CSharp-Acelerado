using System;
using System.Reflection;

namespace ConsoleApp.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! from reflection");

            Contato c = new Contato();

            c.Id = Guid.NewGuid();
            c.Nome = "Nome teste";
            c.Telefone = "11 929292929";

            Type tContato = typeof(Contato);

            Console.WriteLine($"Type Info - Comecando");
            Console.WriteLine($"Type Info - {tContato.Name}");
            Console.WriteLine($"Type Info - {tContato.Assembly.FullName}");
            Console.WriteLine($"Type Info - {tContato.BaseType?.Name}");
            Console.WriteLine($"Type Info - Fim");

            var attributes = tContato.CustomAttributes;
            foreach (var item in attributes)
            {
                Console.WriteLine($"Type Info - Attributes {item.AttributeType.Name}");
            }

            var publicProperties = tContato.GetProperties();
            foreach (var item in publicProperties)
            {
                Console.WriteLine($"Type Info - Public Property Name {item.Name} Value {tContato.GetProperty(item.Name).GetValue(c)}");
            }

            var p = tContato.GetProperty("Nome");
            p.SetValue(c, "Nome do Reflection");

            Console.WriteLine($"Set Reflection - Property Nome --> {c.Nome}");

            Console.ReadKey();
        }
    }
}
