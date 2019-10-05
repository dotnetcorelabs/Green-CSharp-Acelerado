using Basico02;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            _06Indexers indexer = new _06Indexers();
            string nome1 = indexer[0];
            string nome2 = indexer[1];
            string nome3 = indexer[3];



            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Indexer2 indexer2 = new Indexer2();
            try
            {
                int idade1 = indexer2["nome1"];
                int idade2 = indexer2["nome2"];
                int idadeError = indexer2["lalalala"];
            }
            catch(ArgumentNullException argEx)
            {
                //tratar esse problema
            }
            catch (Exception e)
            {
                //tratar genericamente
            }
            
            Assert.Pass();
        }
    }
}