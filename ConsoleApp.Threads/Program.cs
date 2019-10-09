using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world from Threads");

            Task tarefa = Task.Factory.StartNew(() => Console.WriteLine("Da minha tarefa"));

            Task<bool> tarefaBooleana = Task.FromResult(true);

            Console.ReadKey();
        }
    }
}
