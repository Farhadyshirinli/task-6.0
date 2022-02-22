using System;

namespace task_6._8
{

    internal class Program
    {

       
        static void Main(string[] args)
        {
           string   nextword= Class1.FindString("yashaazerbaycan", 'y');

            //  Console.WriteLine(nextword);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nextword);
            }
        }
    }
}
