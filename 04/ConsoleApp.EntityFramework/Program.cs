using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world - Entity Framework");

            Dictionary<Guid, string> registros = new Dictionary<Guid, string>()
            {
                [Guid.Parse("9DE506C0-A789-4FFD-B8AF-DB2F64888C56")] = "Elvis",
                [Guid.Parse("D29015DB-FA04-41A7-8CB7-68F0C86275C5")] = "Jonny Cash",
                [Guid.Parse("F5ACD77C-776F-4EC3-90FA-D6DFD3E71621")] = "Eric Clapton",
                [Guid.Parse("95339037-8403-421A-AC47-856516DD7229")] = "John Lennon",
                [Guid.Parse("52CBBCF8-9916-44D5-A4C2-5F06DAA4CF1B")] = "Mick Jagger",
                [Guid.Parse("2D426A4D-BDB6-43BF-AF7E-912887F5B073")] = "Shakira"
            };

            using (var db = new ConsoleApp.EntityFramework.db001Entities())
            {
                Console.WriteLine("Inserindo registros");
                foreach (var item in registros)
                {
                    db.Contato.Add(new Contato()
                    {
                        Id = item.Key.ToString(),
                        Nome = item.Value
                    });
                }

                db.SaveChanges();


                Console.WriteLine("Listando registros");
                var contatosDb = db.Contato.ToList();
                foreach (var item in contatosDb)
                {
                    Console.WriteLine($"Id {item.Id} Nome {item.Nome}");
                }


                Console.WriteLine("Removendo registros");
                db.Contato.RemoveRange(contatosDb);

                db.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
