using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ld
{
    public class Studentas
    {
        public string Name { get; set; }
        public string Pavarde { get; set; }
        public double Vidurkis { get; set; }
        //public double Mediana { get; set; }
        public override string ToString()
        {
            return String.Format("{0, -20}{1, -20}{2, -10}\n", Name, Pavarde, Vidurkis);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            bool was = true;
            List<Studentas> studentai = new List<Studentas>();
            Console.WriteLine("Norite ivesti studentus ranka ar is failo? ranka/failas");
            var k1 = Console.ReadLine();
            string kas1 = k1.ToString();
            if( kas1 == "failas")
            {
                string line;
                System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\AIstutis\Desktop\kursiokai.txt");
                file.ReadLine();
                while ((line = file.ReadLine()) != null)
                {
                    string[] values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    int egzas = values.Count() - 1;
                    double temp = 0;
                    int temp1 = 0;
                    for (int i = 2; i < values.Count() - 1; i++)
                    {
                        temp = temp + int.Parse(values[i]);
                        temp1 = temp1 + 1;
                    }
                    temp = temp / temp1 * 0.3 + int.Parse(values[egzas]) * 0.7;
                    studentai.Add(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });

                }
                isvedimas(studentai);
            }

            if (kas1 == "ranka")
            {
                while (was)
                {
                    Console.WriteLine("Norite ivesti studenta ir jo balus? (yes/no)");
                    var k = Console.ReadLine();
                    string kas = k.ToString();
                    if (kas == "yes")
                    {
                        Console.WriteLine("iveskite duomenis eilute skirdami viska tarpu, paskutinis jusu ivestas balas yra egzaminas");

                        var info = Console.ReadLine();
                        double temp = 0;
                        int temp1 = 0;
                        List<string> arr = info.Split(' ').ToList();
                        int egzas = arr.Count() - 1;

                        for (int i = 2; i < arr.Count() - 1; i++)
                        {
                            temp = temp + int.Parse(arr[i]);
                            temp1 = temp1 + 1;
                        }
                        temp = temp / temp1 * 0.3 + int.Parse(arr[egzas]) * 0.7;
                        studentai.Add(new Studentas() { Name = arr[0], Pavarde = arr[1], Vidurkis = temp });
                    }

                    if (kas == "no")
                    {
                        isvedimas(studentai);
                        was = false;
                    }
                }
            }
            void isvedimas(List<Studentas> sss)
            {
                Console.WriteLine("Vardas              Pavarde             Vidurkis  ");
                Console.WriteLine("--------------------------------------------------");
                foreach (Studentas aPart in sss)
                {
                    Console.WriteLine(aPart);
                }
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}