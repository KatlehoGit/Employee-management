/*2017115029
Katleho Moalosi
Assignment 1
CSIS2614*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Ch12Ex3
{
    [Serializable]
    class CEmployee
    {
        
        public string ID { get; set; }
        public string Surname {get;set;}
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        static protected double TAX;

        public virtual decimal NetSalary(decimal mGross, double tax, double commission)
        {
            return 0;
        }

        public void Save(string _sFilename)
        {
            FileStream save = new FileStream("Employees.ser", FileMode.Create);
            IFormatter Format = new BinaryFormatter();
            Format.Serialize(save, this);
            save.Close();

        }

        //public CEmployee Read(string sFile)
        //{
        //    //FileStream file = new FileStream(sFile, FileMode.Open);
        //    //IFormatter formatter = new BinaryFormatter();
        //    //CEmployee save = (CEmployee)formatter.Deserialize(file);
        //    //file.Close();
        //    //return save;

            
            
        //}

    }
}
