using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorColmeiaComplexo
{
    public partial class Form1 : Form
    {
        World world;
        private Random random = new Random();
        private DateTime start = DateTime.Now;
        private DateTime end;
        private int framesRun = 0;
        public Form1()
        {
            InitializeComponent();
            world = new World(new BeeMessage(SendMessage));

            timer1.Interval = 50;
            timer1.Tick += new EventHandler(RunFrame);
            timer1.Enabled = false;
            UpdateStats(new TimeSpan());
        }

        private void RunFrame(object sender, EventArgs e)
        {
            framesRun++;
            world.Go(random);
            end = DateTime.Now;
            TimeSpan framesDuration = end - start;
            start = end;
            UpdateStats(framesDuration);
        }

        private void UpdateStats(TimeSpan frameDuration)
        {
            Bees.Text = world.Bees.Count.ToString();
            Flowers.Text = world.Flowers.Count.ToString();
            HoneyInHive.Text = string.Format("{0:f3}",world.Hive.Honey);
            double nectar = 0;
            foreach (Flower flower in world.Flowers)
            {
                nectar += flower.Nectar;
            }
            NectarInFlowers.Text = string.Format("{0:f3}",nectar);
            FramesRun.Text = framesRun.ToString();
            double milliSeconds = frameDuration.TotalMilliseconds;
            if (milliSeconds != 0.0)
                FramesRate.Text = string.Format("{0:f0} ({1:f1}ms)", 1000 / milliSeconds, milliSeconds);
            else
                FramesRate.Text = "N/A";
        }

        private void StartSimulation_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                toolStrip1.Items[0].Text = "Resume simulation";
                timer1.Stop();
            }
            else
            {
                toolStrip1.Items[0].Text = "Pause Simulation";
                timer1.Start();
            }
                
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            framesRun = 0;
            world = new World(new BeeMessage(SendMessage));
            if (!timer1.Enabled)
                toolStrip1.Items[0].Text = "Start Simulation";
        }

        private void SendMessage(int ID, string Message)
        {
            statusStrip1.Items[0].Text = string.Format("Bee #{0}: {1}", ID, Message);
            var beeGroups =
                from bee in world.Bees
                group bee by bee.CurrentState into beeGroup
                orderby beeGroup.Key
                select beeGroup;
            listBox1.Items.Clear();
            foreach (var group in beeGroups)
            {
                string s;
                if (group.Count() == 1)
                    s = "";
                else
                    s = "s";
                listBox1.Items.Add(group.Key.ToString() + ": " + group.Count() + " bee" + s);
                if(group.Key == BeeState.Idle
                  && group.Count() == world.Bees.Count()
                  && framesRun > 0)
                {
                    listBox1.Items.Add("Simulação finalizada: todas abelhas estão inativas");
                    toolStrip1.Items[0].Text = "Simulação finalizada";
                    statusStrip1.Items[0].Text = "Simulação finalizada";
                    timer1.Enabled = false;
                }
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            World currentWorld = world;
            int currentFramesRun = framesRun;

            bool enable = timer1.Enabled;
            if (enable)
                timer1.Stop();

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Simulator File (*.bees)|*.bees";
            openDialog.CheckFileExists = true;
            openDialog.CheckPathExists = true;
            openDialog.Title = "Escolha um arquivo com a simulação à ser carregada";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream input = File.OpenRead(openDialog.FileName))
                    {
                        world = (World)bf.Deserialize(input);
                        framesRun = (int)bf.Deserialize(input);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to read the simulator file\r\n" + ex.Message,
                        "Bee Simulator Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    world = currentWorld;
                    framesRun = currentFramesRun;
                }
            }
            world.Hive.MessageSender = new BeeMessage(SendMessage);
            foreach (Bee bee in world.Bees)
                bee.MessageSender = new BeeMessage(SendMessage);
            if (enable)
                timer1.Start();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

            bool enable = timer1.Enabled;
            if(enable)
                timer1.Stop();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Simulator File (*.bees)|*.bees";
            saveDialog.CheckFileExists = true;
            saveDialog.Title = "Escolha um arquivo para salvar o simulador atual";
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream output = File.OpenWrite(saveDialog.FileName))
                    {
                        bf.Serialize(output, world);
                        bf.Serialize(output, framesRun);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save the simulator file\r\n" + ex.Message,"Bee Simulator Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if (enable)
                timer1.Start();
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}


