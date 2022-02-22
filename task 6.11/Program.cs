using System;

namespace task_6._11
{
   //  Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun {b} simvollarinin qabagina {a} simvolunu yaz.
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text = "karabakh is azerbaijan";

            string a = "h";
            string b = "j";

           

                int word = Text.IndexOf($"{a}");
                string wordA = Text.Substring(word, 1);


                int word2 = Text.IndexOf($"{b}");
                string wordB = Text.Substring(word2, 1);


                string newtext = Text.Insert(word, wordB);
                string newtext2 = Text.Insert(word2, wordA);

                Console.WriteLine(newtext);
                Console.WriteLine(newtext2);


            

        }
        }
    }

