using System;

namespace task_6._9
{
    internal class Program
    {
        // Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
        static void Main(string[] args)
        {
            string[] chars = new string[0];
                       
           string word = "karabakh is azerbaijan";

            chars[word.Length] = word;

            Console.WriteLine(chars);
            //string Word2 = Word.Substring(0,3);

            //int index1=Word.IndexOf(Word2);

            //Console.WriteLine(index1);


        }
    }
}
