using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Basico
{
    public class _09GerenciandoExceptions
    {
        public void Erro()
        {
            try
            {
                //executar algo
            }
            catch (Exception ex)
            {
                //tratar exception

                //subir exception
                throw;
            }
        }

        
        //exemplo de escrita de arquivo
        public void EscreverLog(string textoLog)
        {
            try
            {
                File.WriteAllText("c:\\temp\\log.txt", textoLog);
            }
            catch(DirectoryNotFoundException directoryNotFound)
            {
                //tratar em caso de nao encontrar arquivo
                //por exemplo, criar o arquivo

                Directory.CreateDirectory("c:\\temp");
                File.WriteAllText("c:\\temp\\log.txt", textoLog);
            }
        }
    }
}
