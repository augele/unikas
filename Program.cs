
using System;

using System.Collections.Generic;

using System.Diagnostics;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace _3ld
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Studentas random = new Studentas();
            //random.RandomGeneratorius(1000);
            // random.RandomGeneratorius(10000);
            //random.RandomGeneratorius(100000);
            //  random.RandomGeneratorius(1000000);
            //random.RandomGeneratorius(10000000);
            Queuerusiavimas();

            linkedlistrusiavimas();

            listrusiavimas();
            
            


            void listrusiavimas()
            {
                Stopwatch laikas = new Stopwatch();

                laikas.Start();

                _3ld.Menuu.surusiavimas(@"C:\Users\AIstutis\source\repos\3ld\3ld\bin\Debug\netcoreapp3.1\sugeneruotas100000.txt");
                laikas.Stop();

                double uztruko = laikas.Elapsed.TotalSeconds;

                Console.WriteLine(" List  uztruko " + uztruko.ToString());
            }
            void linkedlistrusiavimas()
            {
                Stopwatch laikas = new Stopwatch();

                laikas.Start();

                _3ld.Menuu.surusiavimas1(@"C:\Users\AIstutis\source\repos\3ld\3ld\bin\Debug\netcoreapp3.1\sugeneruotas100000.txt");
                laikas.Stop();

                double uztruko = laikas.Elapsed.TotalSeconds;

                Console.WriteLine(" Linked List  uztruko " + uztruko.ToString());
            }
            void Queuerusiavimas()
            {
                Stopwatch laikas = new Stopwatch();

                laikas.Start();

                _3ld.Menuu.surusiavimas2(@"C:\Users\AIstutis\source\repos\3ld\3ld\bin\Debug\netcoreapp3.1\sugeneruotas100000.txt");
                laikas.Stop();

                double uztruko = laikas.Elapsed.TotalSeconds;

                Console.WriteLine(" Queue uztruko " + uztruko.ToString());
            }
        }
    }
}