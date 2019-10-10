using System;
using System.Reflection;

namespace ConsoleApp.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! from reflection");

            Type tContato = typeof(Contato);

            Console.WriteLine($"Type Info - Comecando");
            Console.WriteLine($"Type Info - {tContato.Name}");
            Console.WriteLine($"Type Info - {tContato.Assembly.FullName}");
            Console.WriteLine($"Type Info - {tContato.BaseType?.Name}");
            Console.WriteLine($"Type Info - Fim");

            Console.WriteLine();

            var attributes = tContato.CustomAttributes;
            foreach (var item in attributes)
            {
                Console.WriteLine($"Type Info - Attributes {item.AttributeType.Name}");
            }

            Console.WriteLine();

            var publicProperties = tContato.GetProperties();
            foreach (var item in publicProperties)
            {
                Console.WriteLine($"Type Info - Public Property Name {item.Name} Type {item.PropertyType.Name}");
            }

            //tContato.GetMethods()
            //tContato.GetCustomAttributes()

            Console.WriteLine();

            Contato c = new Contato();
            c.Id = Guid.NewGuid();
            c.Nome = "Nome teste";
            c.Telefone = "11 929292929";

            publicProperties = tContato.GetProperties();
            foreach (var item in publicProperties)
            {
                Console.WriteLine($"Name {item.Name} " +
                    $"Type {item.PropertyType.Name} " +
                    $"Value {tContato.GetProperty(item.Name).GetValue(c)}");
            }

            tContato.GetProperty("Telefone").SetValue(c, "29299292");

            Console.WriteLine($"Telefone {c.Telefone}");

            Console.ReadKey();


            //carregar assembly em runtime
            Assembly assemly = Assembly.LoadFile("c:\\plugins\\mercadopago.dll");

            //pega tipos disponiveis no assembly
            Type[] types = assemly.GetTypes();

            //foreach nos types
            foreach (Type tItem in types)
            {
                //verifica se pertence a interface IPagamento
                if (tItem.IsAssignableFrom(typeof(IPagamento)))
                {
                    //pega construtores
                    var constrcutors = tItem.GetConstructors();

                    //ativa a instancia (cria novo objecto)
                    IPagamento paReflection = Activator.CreateInstance(tItem) as IPagamento;

                    //chama metodo
                    paReflection.Pagar("123", 12.4m);
                }
            }
        }
    }
}
