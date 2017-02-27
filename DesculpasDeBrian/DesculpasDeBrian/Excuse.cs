using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesculpasDeBrian
{
    [Serializable]
    class Excuse
    {
        
        public Excuse()
        {
            ExcusePath = "";
        }
        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }
        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder,".excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }
        
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            Excuse tempExcuse;
            BinaryFormatter ft = new BinaryFormatter();
            using (Stream input = File.OpenRead(excusePath))
            {
                tempExcuse = (Excuse)ft.Deserialize(input);
            }
            Description = tempExcuse.Description;
            Results = tempExcuse.Results;
            LastUsed = tempExcuse.LastUsed;
        }

        public void Save(string fileName)
        {
            //using (StreamWriter swriter = new StreamWriter(fileName))
            //{
            //    swriter.WriteLine(Description);
            //    swriter.WriteLine(Results);
            //    swriter.WriteLine(LastUsed);
            //}

            using (Stream fileOutput = File.OpenWrite(fileName))
            {
                BinaryFormatter ft = new BinaryFormatter();
                ft.Serialize(fileOutput, this);
            }
        }
    }
}
