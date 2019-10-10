using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.EF
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new xhuxhuEntities())
            {
                db.Contatos.Add(new Contato
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Contato do EF",
                    Idade = 10,
                    Pessoa = new Pessoa()
                    {
                        Id = 10,
                        Nome = "Ricardo"
                    }
                });

                

                db.SaveChanges();


                List<Contato> contatos = db.Contatos.ToList();

                var contatosRicardo = db.Contatos.Where(x => x.Nome == "ricardo")
                    .ToList();
            }
        }
    }
}
