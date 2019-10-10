using System;
using System.Diagnostics;

namespace ConsoleApp.ExecutePS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = "systeminfo",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };


            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string line = proc.StandardOutput.ReadLine();

                Console.WriteLine(line);
                // do something with line
            }

            Console.WriteLine();
            Console.WriteLine("Fim do processo");
            Console.ReadKey();
        }
    }
}
