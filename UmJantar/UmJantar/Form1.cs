using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmJantar
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
                                 opcaoSaudavel.Checked, opcaoChique.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);

            DisplayBirthdayPartyCost();
        }

        public void DisplayDinnerPartyCost()
        {
            dinnerParty.CalculateCostOfDecorations(opcaoChique.Checked);
            decimal cost = dinnerParty.CalculateCost(opcaoSaudavel.Checked);
            costLabel.Text = cost.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(opcaoChique.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {   
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.CalculateCostOfDecorations(opcaoChique.Checked);
            dinnerParty.CalculateCost(opcaoChique.Checked);
            DisplayDinnerPartyCost();
        }

        private void opcaoChique_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(opcaoChique.Checked);
            
            DisplayDinnerPartyCost();
        }

        private void opcaoSaudavel_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(opcaoSaudavel.Checked);
            DisplayDinnerPartyCost();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            cakeWriting.Text = birthdayParty.CakeWriting;
            decimal cost = birthdayParty.CalculateCost();
            birthdayCost.Text = cost.ToString("c");
        }
    }
}
