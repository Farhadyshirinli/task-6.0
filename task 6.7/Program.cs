using System;

namespace task_6._7
{
    // Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi?
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "land of fire";

            char a = 'l';
            char b = 'o';
            char c = 'f';

            int w1 = text.IndexOf($"{a}");
            int w2 = text.IndexOf($"{b}");
            int w3 = text.IndexOf($"{c}");

            // text=text.Substring(0,text.Length);

            //     Console.WriteLine(w1);


            //while (true)
            //{
            //    if ((a<b)&&(b<c))
            //    {
            //        Console.WriteLine("sert odenilir");
            //    }

            //}

            for (int i = 0; i < text.Length; i++)
            {
                if ((w1<w2)&&(w2<w3))
                {
                    Console.WriteLine("sert odenilir");
                    break;
                }
                else
                {
                    Console.WriteLine("sert odenilmir");
                    break;


                }



            }

        }
    }
}
