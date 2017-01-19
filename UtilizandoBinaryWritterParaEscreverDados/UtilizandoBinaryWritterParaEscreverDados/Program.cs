using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UtilizandoBinaryWritterParaEscreverDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 48769414;
            string stringValue = "Hello!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695F;
            char charValue = 'E';

            using (FileStream output = File.Create("binarydata.dat"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(intValue);
                writer.Write(stringValue);
                writer.Write(byteArray);
                writer.Write(floatValue);
                writer.Write(charValue);
            }

            byte[] dataWritten = File.ReadAllBytes("binarydata.dat");

            foreach (byte b in dataWritten)
                Console.Write("{0:x2} ", b);
            Console.WriteLine(" - {0} bytes", dataWritten.Length);
            Console.ReadKey();

        }
    }
}
