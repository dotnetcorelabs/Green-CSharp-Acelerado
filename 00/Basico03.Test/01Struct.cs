using System;
using Xunit;

namespace Basico03.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var programa = new ProgramaLocalizacao();
            programa.AdicionarPonto(100, 200);

            Assert.Equal(3, programa.Coordenadas.Count);
        }

        struct MyStruct
        {
            public int Contents;
        }

        class MyClass
        {
            public int Contents = 0;
        }

        [Fact]
        public void Test2()
        {
            MyStruct struct1 = new MyStruct();
            MyStruct struct2 = struct1;
            struct2.Contents = 100;
            MyClass class1 = new MyClass();
            MyClass class2 = class1;
            class2.Contents = 100;


            Console.WriteLine("Value types: {0}, {1}", struct1.Contents, struct2.Contents);
            Console.WriteLine("Reference types: {0}, {1}", class1.Contents, class2.Contents);

            Assert.NotEqual(struct1.Contents, struct2.Contents);
            Assert.Equal(class1.Contents, class2.Contents);

        }
    }
}
