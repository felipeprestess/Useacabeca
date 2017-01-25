using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EscrevendoEmBytes
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Escrevendo em bytes
            File.WriteAllText("Eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("Eureka.txt");

            foreach (byte b in eurekaBytes)
                Console.Write("{0} ", b);
            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Escrevendo em hexadecimal
            File.WriteAllText("Eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("Eureka.txt");

            foreach (byte b in eurekaBytes)
                Console.Write("{0:x2} ", b);
            Console.WriteLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Escrevendo em hebraico
            File.WriteAllText("Eureka.txt", "שלום", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes("Eureka.txt");

            foreach (byte b in eurekaBytes)
                Console.Write("{0:x2} ", b);
            Console.WriteLine();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FileStream input = File.OpenRead("Eureka.txt"))
            using (BinaryReader reader = new BinaryReader(input))
            {
                int intRead = reader.ReadInt32();
                string stringRead = reader.ReadString();
                byte[] byteArrayRead = reader.ReadBytes(4);
                float floatRead = reader.ReadSingle();
                char charRead = reader.ReadChar();

                Console.Write("int: {0} string: {1} bytes: ", intRead, stringRead);
                foreach (byte b in byteArrayRead)
                    Console.Write("{0}",b);
                Console.Write("float: {0} char: {1} ", floatRead, charRead);
            }
            Console.ReadKey();
        }
    }
}
