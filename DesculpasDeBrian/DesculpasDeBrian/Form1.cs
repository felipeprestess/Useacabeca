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
using System.Runtime.Serialization;

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
                openFile.FileName = description.Text + ".excuse";
                DialogResult result = openFile.ShowDialog();
                if(result == DialogResult.OK)
                {
                    bool clearForm = false;
                    try
                    {
                        currentExcuse = new Excuse(openFile.FileName);
                        try
                        {
                            UpdateForm(false);
                        }
                    catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show(string.Format("The excuse file '{0}' is invalid", openFile.FileName),"Unable to open the excuse");
                            clearForm = true;
                        }
                       
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show(string.Format("An error occured while opening the excuse '{0}'\n {1}",openFile.FileName,ex.Message),"Unable to open the excuse",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        clearForm = true;
                    }
                    finally
                    {
                        if (clearForm)
                        {
                            description.Text = "";
                            results.Text = "";
                            lastUsed.Value = DateTime.Now;
                        }
                    }
                    
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
            string[] fileNames = Directory.GetFiles(selectedFolder, "*.excuse");
            if(fileNames.Length == 0)
            {
                MessageBox.Show("Please specify a folder with excuse files int it",
                    "No excuse files found");
            }
            else
            {
                try
                {
                    if (CheckChanged() == true)
                        currentExcuse = new Excuse(random, selectedFolder);
                }
                catch (SerializationException)
                {
                    currentExcuse = new Excuse();
                    currentExcuse.Description = "";
                    currentExcuse.Results = "";
                    currentExcuse.LastUsed = DateTime.Now;
                    MessageBox.Show(
                        "Your excuse file was invalid",
                        "Unable to open a random excuse");
                }
                finally
                {
                    UpdateForm(false);
                }
            }
        }
    }
}
