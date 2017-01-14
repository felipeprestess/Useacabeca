using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesculpasDeBrian
{
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
            string[] fileNames = Directory.GetFiles(folder,".txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }
        
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public void OpenFile(string excusePath)
        {
            ExcusePath = excusePath;
            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter swriter = new StreamWriter(fileName))
            {
                swriter.WriteLine(Description);
                swriter.WriteLine(Results);
                swriter.WriteLine(LastUsed);
            }
        }
    }
}
