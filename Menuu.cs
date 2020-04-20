using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3ld
{
   public class Menuu
    {
        public static void meniu()
        {
            bool was = true;
            List<Studentas> studentai = new List<Studentas>();
            Console.WriteLine("Norite ivesti studentus ranka ar is failo? ranka/failas");
            var k1 = Console.ReadLine();
            string kas1 = k1.ToString();
            if (kas1 == "failas")
            {
                string line;
                try
                {
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
                catch (FileNotFoundException)

                {

                    Console.WriteLine("Failas tokiu pavadinimu neegzistuoja");

                }
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
        }
        public static void isvedimas(List<Studentas> sss)
        {
            sss.Sort(delegate (Studentas x, Studentas y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });

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
