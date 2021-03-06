﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GerenciamentoDeAbelha
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar colletor", "Honney manufacturing"});
            workers[1] = new Worker(new string[] { "Egg Care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar colletor", "Honney manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }

        private void proxTurno_Click(object sender, EventArgs e)
        {
            relatorio.Text = queen.WorkTheNextShift();
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if(queen.AssignWork(workerBeeJob.Text, (int)turnos.Value) == false)
                MessageBox.Show("No workers are available to do the job '" + workerBeeJob.Text + "'", "The Queen says...");
            else
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " + turnos.Value + " shifts", "The Queen says..."); 
        }
    }
}
