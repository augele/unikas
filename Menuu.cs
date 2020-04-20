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
                new System.IO.StreamReader(@"C:\Users\AIstutis\source\repos\3ld\3ld\bin\Debug\netcoreapp3.1\sugeneruotas1000.txt");

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
                        temp = (double)System.Math.Round(temp, 2);
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

            Console.WriteLine("Vardas              Pavarde             Galutinis(Vid.) ");
            Console.WriteLine("--------------------------------------------------");
            foreach (Studentas aPart in sss)
            {
                Console.WriteLine(aPart);
            }
            Console.WriteLine("--------------------------------------------------");
        }
        public static void surusiavimas(String pavadinimas)
        {
            List<Studentas> vargsiukai = new List<Studentas>();
            List<Studentas> kietekai = new List<Studentas>();
            System.IO.StreamWriter varg = new System.IO.StreamWriter($"vargsiukai.txt");
            System.IO.StreamWriter kiet = new System.IO.StreamWriter($"kietekai.txt");
                string line;
            try
            {
                System.IO.StreamReader file =
            new System.IO.StreamReader(pavadinimas);

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
                    temp = (double)System.Math.Round(temp, 2);
                    if (temp >= 5)
                    {
                        kietekai.Add(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                    }
                    if (temp < 5)
                    {
                        vargsiukai.Add(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                    }
                }
                
            }
            catch (FileNotFoundException)

            {

                Console.WriteLine("Failas tokiu pavadinimu neegzistuoja");

            }
            isvedimasfailas(kietekai, kiet);
           isvedimasfailas(vargsiukai, varg);
        }
        public static void isvedimasfailasQ(Queue<Studentas> sss, System.IO.StreamWriter file)
        {
            file.WriteLine("Vardas              Pavarde             Galutinis(Vid.) ");
            file.WriteLine("--------------------------------------------------");
            foreach (Studentas aPart in sss)
            {
                file.WriteLine(aPart);
            }
            file.WriteLine("--------------------------------------------------");
        }
        public static void isvedimasfailasL(LinkedList<Studentas> sss, System.IO.StreamWriter file)
        {
            file.WriteLine("Vardas              Pavarde             Galutinis(Vid.) ");
            file.WriteLine("--------------------------------------------------");
            foreach (Studentas aPart in sss)
            {
                file.WriteLine(aPart);
            }
            file.WriteLine("--------------------------------------------------");
        }
        public static void isvedimasfailas(List<Studentas> sss, System.IO.StreamWriter file)
        {
            file.WriteLine("Vardas              Pavarde             Galutinis(Vid.) ");
            file.WriteLine("--------------------------------------------------");
            foreach (Studentas aPart in sss)
            {
                file.WriteLine(aPart);
            }
            file.WriteLine("--------------------------------------------------");
        }
        public static void surusiavimas1(String pavadinimas)
        {
            LinkedList<Studentas> vargsiukai = new LinkedList<Studentas>();
            LinkedList<Studentas> kietekai = new LinkedList<Studentas>();
            System.IO.StreamWriter varg = new System.IO.StreamWriter($"vargsiukaiL.txt");
            System.IO.StreamWriter kiet = new System.IO.StreamWriter($"kietekaiL.txt");
            string line;
            try
            {
                System.IO.StreamReader file =
            new System.IO.StreamReader(pavadinimas);

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
                    temp = (double)System.Math.Round(temp, 2);
                    if (temp >= 5)
                    {
                        kietekai.AddLast(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });

                    }
                    if (temp < 5)
                    {
                        vargsiukai.AddLast(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });

                    }
                }
            }
            catch (FileNotFoundException)

            {

                Console.WriteLine("Failas tokiu pavadinimu neegzistuoja");

            }
           isvedimasfailasL(kietekai, kiet);
            isvedimasfailasL(vargsiukai, varg);
        }
        public static void surusiavimas2(String pavadinimas)
        {
           Queue<Studentas> vargsiukai = new Queue<Studentas>();
            Queue<Studentas> kietekai = new Queue<Studentas>();
            System.IO.StreamWriter varg = new System.IO.StreamWriter($"vargsiukaiQ.txt");
            System.IO.StreamWriter kiet = new System.IO.StreamWriter($"kietekaiQ.txt");
            string line;
            try
            {
                System.IO.StreamReader file =
            new System.IO.StreamReader(pavadinimas);

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
                    temp = (double)System.Math.Round(temp, 2);
                    if (temp >= 5)
                    {
                        kietekai.Enqueue(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                        //kietekai.Add(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                    }
                    if (temp < 5)
                    {
                        vargsiukai.Enqueue(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                        // vargsiukai.Add(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                    }
                }

            }
            catch (FileNotFoundException)

            {

                Console.WriteLine("Failas tokiu pavadinimu neegzistuoja");

            }
            isvedimasfailasQ(kietekai, kiet);
            isvedimasfailasQ(vargsiukai, varg);
        }
    }
}
