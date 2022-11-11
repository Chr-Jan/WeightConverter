using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistens
{
    public class DataHandler
    {

        private string dataFileName; 

        public string DataFileName   
        {
            get { return dataFileName; }   
        }

        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }
        public void SavePerson(Person person)
        {
            using (StreamWriter writer = new StreamWriter(DataFileName))
            {
                writer.Write(person.MakeTitle());
                writer.Close();
            }

        return;
        }
    }
} 
