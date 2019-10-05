
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using Xunit;

namespace Data.Tests
{
    public class Tests
    {
        [Fact]
        public void XmlSerializerTest()
        {
            Veiculo veiculoSerialize = Veiculo.Default;

            Type tipoVeiculo = typeof(Veiculo);

            XmlSerializer serializer = new XmlSerializer(typeof(Veiculo));

            using (Stream stream = File.OpenWrite("c:\\temp\\xmlserializerTest.xml"))
            {
                serializer.Serialize(stream, veiculoSerialize);
            }


            Assert.True(File.Exists("c:\\temp\\xmlserializerTest.xml"));
        }

        [Fact]
        public void XmlDeserializerTest()
        {
            Veiculo veiculoSerialize = null;

            XmlSerializer serializer = new XmlSerializer(typeof(Veiculo));
            using (var stream = File.OpenRead("c:\\temp\\xmlserializerTest.xml"))
            {
                object deserializedObject = serializer.Deserialize(stream);
                veiculoSerialize = deserializedObject as Veiculo;
            }

            Assert.NotNull(veiculoSerialize);
            Assert.Equal(Veiculo.Default, veiculoSerialize);
        }

        [Fact]
        public void BinarySerializerTest()
        {
            Veiculo veiculoSerialize = Veiculo.Default;

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (var stream = File.OpenWrite("c:\\temp\\binarySerializerTest.bin"))
            {
                binaryFormatter.Serialize(stream, veiculoSerialize);
            }

            Assert.True(File.Exists("c:\\temp\\binarySerializerTest.bin"));
        }

        [Fact]
        public void BinaryDeserializerTest()
        {
            Veiculo veiculoSerialize = null;

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (var stream = File.OpenRead("c:\\temp\\binarySerializerTest.bin"))
            {
                object deserializedObject = binaryFormatter.Deserialize(stream);
                veiculoSerialize = deserializedObject as Veiculo;
            }

            Assert.NotNull(veiculoSerialize);
            Assert.Equal(Veiculo.Default, veiculoSerialize);
        }

        [Fact]
        public void JsonSerializerTest()
        {
            Veiculo veiculoSerialize = Veiculo.Default;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Veiculo));
            using (var stream = File.OpenWrite("c:\\temp\\jsonSerializer.json"))
            {
                jsonSerializer.WriteObject(stream, veiculoSerialize);
            }

            Assert.True(File.Exists("c:\\temp\\jsonSerializer.json"));
        }

        [Fact]
        public void JsonDeserializerTest()
        {
            Veiculo veiculoSerialize = null;

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Veiculo));
            using (var stream = File.OpenRead("c:\\temp\\jsonSerializer.json"))
            {
                object deserializedObject = jsonSerializer.ReadObject(stream);
                veiculoSerialize = deserializedObject as Veiculo;
            }

            Assert.NotNull(veiculoSerialize);
            Assert.Equal(Veiculo.Default, veiculoSerialize);
        }

        [Fact]
        public void JsonNewtonSerializerTest()
        {
            Veiculo veiculoSerialize = Veiculo.Default;

            using (FileStream stream = File.OpenWrite("c:\\temp\\jsonNewtonSerializer.json"))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine(JsonConvert.SerializeObject(veiculoSerialize));
            }

            Assert.True(File.Exists("c:\\temp\\jsonNewtonSerializer.json"));
        }

        [Fact]
        public void JsonNewtonDeserializerTest()
        {
            Veiculo veiculoSerialize = null;

            using (var stream = File.OpenRead("c:\\temp\\jsonNewtonSerializer.json"))
            using (StreamReader reader = new StreamReader(stream))
            {
                veiculoSerialize = JsonConvert.DeserializeObject<Veiculo>(reader.ReadToEnd());
            }

            Assert.NotNull(veiculoSerialize);
            Assert.Equal(Veiculo.Default, veiculoSerialize);
        }


        [Fact]
        public void BinaryRawTest()
        {
            using (var stream = File.OpenRead("c:\\temp\\pic.bmp"))
            using (StreamReader reader = new StreamReader(stream))
            {
                int index = 0;
                int count = 0;
                int chunckSize = 64;

                char[] buffer = new char[chunckSize];
                while (reader.Peek() > 0)
                {
                    reader.ReadBlock(buffer, index, count);
                }
            }
        }
    }
}