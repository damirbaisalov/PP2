using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    [Serializable]
   public class Mark
    {
        public string yrok;
        public int pt;
        public string letter;
        public Mark()
        {

        }

        public Mark(int pt,string yrok)
        {
            this.yrok = yrok; 
            this.pt = pt;   
        }
        public void GetLetter()
        {
            if (pt > 95) letter = "A"; else letter = "-A";
        }
            
        
        public override string ToString()
        {
            return pt + " = " + letter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Mark mark1 = new Mark(86, "PP2");
            Mark mark2 = new Mark(100, "Calculus");
            Mark mark3 = new Mark(70, "Probability and Statistics");

            mark1.GetLetter();
            mark2.GetLetter();
            mark3.GetLetter();

            List<Mark> marklist = new List<Mark>();
            marklist.Add(mark1);
            marklist.Add(mark2);
            marklist.Add(mark3);
            for (int i = 0; i < marklist.Count; i++)
            {
                Console.WriteLine(marklist[i]);
            }
            //FileStream fs = new FileStream("mark.xml", FileMode.Truncate, FileAccess.ReadWrite);
            //XmlSerializer xs = new XmlSerializer(typeof(Mark));
            XmlSerializer formatter = new XmlSerializer(typeof(Mark));
            using (FileStream fs = new FileStream("mark.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, marklist);

                Console.WriteLine("Объект сериализован");
            }
            Console.ReadKey();
        }
    }
}
