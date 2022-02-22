using System;

namespace task_6._5
{
    // Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir?

    internal class Program
    {
        static void Main(string[] args)
        {
     
            char a1 = 'f';
            char a2 = 'b';
            char a3 = 'a';


       
            string str = "azerbaijan";
            
          
           

            for (int i = 0; i < str.Length; i++)
            {



                if (a1 == str[i])
                {
                    Console.WriteLine("Verilen simvol ilk siradadir");

                    break;
                }
                else if (a2 == str[i])
                {

                    Console.WriteLine("Verilen simvol ikinci siradadir");

                    break;

                }
                else if (a3 == str[i])
                {
                    Console.WriteLine("Verilen simvol ucuncu siradadir");
                    break;
                }

            }


        }
    }
}
