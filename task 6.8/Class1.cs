using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6._8
{
    internal class Class1
    {

        public static string FindString(string word, char worda)
        {
            

           

            int counter = 1;

            int newWord = word.IndexOf($"{worda}");

            counter = counter + newWord;


            string wordb = word.Substring(counter, 1);

            

            return wordb;

        }


    }
}
