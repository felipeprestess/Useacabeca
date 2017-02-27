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

namespace DesculpasDeBrian
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        private string selectedFolder = "";
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
       
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                    FileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
                
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog.SelectedPath;
                btnOpen.Enabled = true;
                btnRandom.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(description.Text) || string.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog.InitialDirectory = selectedFolder;
            saveFileDialog.Filter = "Excuse Files (*.excuse)|*.excuse|All files (*.*)|*.*";
            saveFileDialog.FileName = description.Text + ".excuse";
            DialogResult res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
                
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFile.InitialDirectory = selectedFolder;
                openFile.Filter = "Excuse Files (*.excuse)|*.excuse|All files (*.*)|*.*";
                openFile.FileName = description.Text + ".txt";
                DialogResult result = openFile.ShowDialog();
                if(result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFile.FileName);
                    UpdateForm(false);
                }
            }

        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse  has not saved. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;       
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = description.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }
    }
}
