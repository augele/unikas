
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
            var ats = new StringBuilder();
            Studentas random = new Studentas();
            random.RandomGeneratorius(100000);

            List<Studentas> studentail = new List<Studentas>();
            List<Studentas> studentail1 = new List<Studentas>();

            try
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader($"sugeneruotas100000.txt");
                string line;
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
                    studentail.Add(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                    studentail1.Add(new Studentas() { Name = values[0], Pavarde = values[1], Vidurkis = temp });
                }
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("Failas tokiu pavadinimu neegzistuoja");

            }

           
            listas(studentail1);
            listass(studentail1);
            listas2(studentail1);
            linkedlistas(studentail);
            linkedlistaslast(studentail1);
            linkedlistasDel(studentail);
            Que(studentail);
            QueDel(studentail1);
            

           

            void listas2(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new List<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.Add(sss[i]);
                }
             
                List<Studentas> vargsiukai = new List<Studentas>();
                for(int i =0; i < dydis; i++)
                {
                    if(stack[i].Vidurkis < 5)
                    {
                        vargsiukai.Add(stack[i]);
                    }
                }
                stack.RemoveAll(studentas => studentas.Vidurkis < 5);
                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;
                laikas.Reset();
                stack.Clear();

                ats.Append(" 2 strategija List sukuriant vargsiukus ir paliekant pagrindiniame konteineryje tik kietekus uztruko " + uztruko.ToString()+"\n");
            }


            void listas(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new List<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.Add(sss[i]);
                }
                List<Studentas> kietekai = new List<Studentas>();
                List<Studentas> vargsiukai = new List<Studentas>();
                vargsiukai = stack;
                stack.RemoveAll(studentas => studentas.Vidurkis < 5);
                kietekai = stack;
                vargsiukai.RemoveAll(studentas => studentas.Vidurkis >= 5);
                stack.Clear();
                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;
                laikas.Reset();
                
               ats.Append(" 1 strategija List naudojant remove all metoda uztruko " + uztruko.ToString() + "\n");
            }
            void listass(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new List<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.Add(sss[i]);
                } 
               

                List<Studentas> kietekai = new List<Studentas>();
                List<Studentas> vargsiukai = new List<Studentas>();
                var size = stack.Count();
                for(int i=0; i< size; i++)
                {
                    if (stack[i].Vidurkis < 5)
                        vargsiukai.Add(stack[i]);
                    else
                        kietekai.Add(stack[i]);
                }
                stack.Clear();
                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;
                laikas.Reset();
                
                ats.Append(" 1 strategija List naudojant cikla for uztruko " + uztruko.ToString()+"\n");
            }
            void linkedlistas(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new LinkedList<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.AddFirst(sss[i]);
                }

                LinkedList<Studentas> linkedvarg = new LinkedList<Studentas>();
                LinkedList<Studentas> linkedkiet = new LinkedList<Studentas>();
                foreach (Studentas aaa in stack)
                {
                    if (aaa.Vidurkis < 5)
                    {
                        linkedvarg.AddFirst(aaa);

                    }
                    else { linkedkiet.AddFirst(aaa); }
                }
                stack.Clear();
                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;
                
                ats.Append(" 1 strategija Linked list pridedant i prieki uztruko " + uztruko.ToString() + "\n");
            }
            void linkedlistaslast(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new LinkedList<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.AddFirst(sss[i]);
                }
                LinkedList<Studentas> linkedvarg = new LinkedList<Studentas>();
                LinkedList<Studentas> linkedkiet = new LinkedList<Studentas>();
                foreach (Studentas aaa in stack)
                {
                    if (aaa.Vidurkis < 5)
                    {
                        linkedvarg.AddLast(aaa);

                    }
                    else { linkedkiet.AddLast(aaa); }
                }
                stack.Clear();
                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;
                

                ats.Append(" 1 strategija Linked list pridedant i gala uztruko " + uztruko.ToString() + "\n");
            }
            void linkedlistasDel(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new LinkedList<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.AddFirst(sss[i]);
                }
                LinkedList<Studentas> varg = new LinkedList<Studentas>();
                LinkedList<Studentas> kiet = new LinkedList<Studentas>();
                for (int i = 0; i < dydis; i++)

                {

                    var itemas = stack.First();

                    if (itemas.Vidurkis < 5)

                    {

                        varg.AddFirst(itemas);

                    }

                    else

                    {

                       kiet.AddFirst(itemas);

                    }

                    stack.RemoveFirst();

                }

                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;

                stack.Clear();
                ats.Append(" 1 strategija Linkedlist for ciklu popinant is steko itemus uztruko " + uztruko.ToString() + "\n");
            }
            void Que(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new Queue<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.Enqueue(sss[i]);
                }

                Queue<Studentas> vargseliai = new Queue<Studentas>();
                Queue<Studentas> kietekai = new Queue<Studentas>();
                foreach (Studentas aaa in stack)
                {
                    if (aaa.Vidurkis < 5)
                        vargseliai.Enqueue(aaa);

                    else
                        kietekai.Enqueue(aaa);
                }
                stack.Clear();
                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;
                
                ats.Append(" 1 strategija  Queue naudojant enqueue uztruko " + uztruko.ToString() + "\n");
            }
            void QueDel(List<Studentas> sss)
            {
                Stopwatch laikas = new Stopwatch();
                laikas.Start();
                var stack = new Queue<Studentas>();
                var dydis = sss.Count();
                for (int i = 0; i < dydis; i++)
                {
                    stack.Enqueue(sss[i]);
                }

                Queue<Studentas> vargseliai = new Queue<Studentas>();
                Queue<Studentas> kietekai = new Queue<Studentas>();
                
              for(int i = 0; i < dydis; i++)
                    {
                    var itemas = stack.Dequeue();
                    if (itemas.Vidurkis < 5)
                    {
                        vargseliai.Enqueue(itemas);

                    }
                    else kietekai.Enqueue(itemas);
                    }

                stack.Clear();
                laikas.Stop();
                double uztruko = laikas.Elapsed.TotalSeconds * 1000;

                ats.Append(" 1 strategija  Queue naudojant dequeue uztruko " + uztruko.ToString() + "\n");
            }


            try
            {
                using (System.IO.StreamWriter rez = new System.IO.StreamWriter($"rezultatai.txt")) 
                rez.WriteLine(ats.ToString());
                Console.Write(ats.ToString());
            }
            catch (FileNotFoundException)

            {

                Console.WriteLine("Failas tokiu pavadinimu neegzistuoja");

            }
            Console.ReadKey();
        }
    }
}