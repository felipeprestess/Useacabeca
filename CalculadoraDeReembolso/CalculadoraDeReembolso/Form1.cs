using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeReembolso
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contagemInicia.Value < contagemTermina.Value)
            {
                startingMileage = (int)contagemInicia.Value;
                endingMileage = (int)contagemTermina.Value;
                milesTraveled = endingMileage -= startingMileage;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("A quilometragem inicial deve ser menor que a contagem final","Impossível Calcular");
            }
        }
    }
}
