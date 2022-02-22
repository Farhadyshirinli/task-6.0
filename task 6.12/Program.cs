using System;

namespace task_6._12
{
    internal class Program
    {
        // Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et.
        static void Main(string[] args)
        {
            string word = "long live Azerbaijan";

            string l1 = word.Substring(0, 1);
            string l2 = word.Substring(word.Length - 1, 1);
            int a1=word.IndexOf($"{l1}");
            int a2=word.LastIndexOf(l2);
            word = word.Remove(a1+1, a2-1);
            Console.WriteLine(word);

        }
    }
}
