using System;
using ClassLibrary.Helpers;

namespace task_6._6
{
    internal class Program
    {
        // Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?
        static void Main(string[] args)
        {


            string str = "war between Ukraine and Russia";
            l1:
            string fromUser=Monitor.ReadString("simvol daxil edin: ");

            char symbolfromuser=Convert.ToChar(fromUser);

            int Lstr = str.IndexOf($"{fromUser}");


            int Rstr = str.LastIndexOf($"{fromUser}");

            if (Lstr==Rstr)
            {
                Console.WriteLine("simvolun indeksi eynidir");
            }
            else
            {
                Console.WriteLine("indeks eyni deyil!");
                Console.WriteLine("-------------------");

                goto l1;
            }





        }
    }
}
