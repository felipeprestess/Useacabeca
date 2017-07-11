using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;



namespace ProgramaDeBanco
{
    [DataContract(Name = "Guy", Namespace = "http://headfirstlabs.com")]
    class SerializableGuy
    {
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public int Age { get; private set; }
        [DataMember]
        public int Cash { get; private set; }
        [DataMember]
        private int secretNumberOne = new Random().Next();
        private int secretNumberTwo = new Random().Next();

        public SerializableGuy(string name, int age, int cash)
        {
            Name = name;
            Age = age;
            Cash = cash;
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} years old and has {2} bucks [{3},{4}]"
                ,Name, Age, Cash,secretNumberOne,secretNumberTwo);
            
        }
    }
}
