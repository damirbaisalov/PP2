using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace task1
{
    [Serializable]
    public class Complex
    {
        public int rl;
        public int im;

        public Complex()
        {

        }
        public Complex(int rl, int im)
        {
            this.rl = rl;
            this.im = im;
        }
        public override string ToString()
        {
            return rl + " + " + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(3, 6);
            Console.WriteLine("Экземпляр создан");

            XmlSerializer formatter = new XmlSerializer(typeof(Complex));
            using (FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, complex);
                Console.WriteLine("Объект создан");
            }
            using (FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate))
            {
                Complex newComplex = (Complex)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine("Действительная часть: {0} --- Мнимая часть: {1}i", newComplex.rl, newComplex.im);
            }

            Console.WriteLine(complex);
            Console.ReadKey();
        }
    }
}
