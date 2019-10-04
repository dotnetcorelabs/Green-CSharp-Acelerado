using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                File.WriteAllText("c:\\temp\\log.txt", "Texto super legal");
            }
            catch (ArgumentNullException argNullEx)
            {
                throw argNullEx;
            }
            catch (ArgumentException argEx)
            {
                //escrever algum log
                Trace.WriteLine("deu error " + argEx.Message);
                throw;
            }
            catch (FileNotFoundException fileNotFoundException)
            {
                throw new Exception("Nao encontrei arquivo");
            }
            catch (Exception ex)
            {
                Exception e = ex;
                StringBuilder sbError = new StringBuilder();
                while (e != null)
                {
                    sbError.AppendLine(e.Message);
                    e = e.InnerException;
                }
                Trace.WriteLine("Error sper " + sbError.ToString());
            }
        }


        //exemplo de escrita de arquivo
        public void EscreverLog(string textoLog)
        {
            try
            {
                File.WriteAllText("c:\\temp\\log.txt", textoLog);
            }
            catch (ArgumentException argumentException)
            {
                //tratar argument null exception
                argumentException.Message
            }
            catch (DirectoryNotFoundException directoryNotFound)
            {
                //tratar em caso de nao encontrar arquivo
                //por exemplo, criar o arquivo

                Directory.CreateDirectory("c:\\temp");
                File.WriteAllText("c:\\temp\\log.txt", textoLog);
            }
            catch (Exception ex)
            {
                //outros tipos de exception
            }
            finally
            {

            }
        }
    }
}
