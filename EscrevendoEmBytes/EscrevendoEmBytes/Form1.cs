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
            File.WriteAllText("Eureka.txt", "שלום", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes("Eureka.txt");

            foreach (byte b in eurekaBytes)
                Console.Write("{0:x2} ", b);
            Console.WriteLine();
        }
    }
}
