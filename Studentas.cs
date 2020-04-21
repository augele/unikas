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
        public override string ToString()
        {
            return String.Format("{0, -20}{1, -20}{2, -10}\n", Name, Pavarde, Vidurkis);
        }
        
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
        public void RandomGeneratorius(int kiekis)

        {

            using (System.IO.StreamWriter file =

            new System.IO.StreamWriter($"sugeneruotas{kiekis}.txt"))

            

            {
                file.WriteLine("Vardas      Pavardė     ND1 ND2 ND3 ND4 ND5 Egzaminas");
                for (int i = 0; i < kiekis; i++)

                {

                    string temp = null;

                    temp += "vardas" + i + " ";

                    temp += "pavarde" + i + " ";

                    temp += Studentas.GetRandomNumber(1,10) + " ";

                    temp += Studentas.GetRandomNumber(1, 10) + " ";

                    temp += Studentas.GetRandomNumber(1, 10) + " ";

                    temp += Studentas.GetRandomNumber(1, 10) + " ";

                    temp += Studentas.GetRandomNumber(1, 10) + " ";

                    temp += Studentas.GetRandomNumber(1, 10) + " ";

                    
                   // Console.WriteLine(temp);

                    file.WriteLine(temp);

                }



            }

        }
    }
}

