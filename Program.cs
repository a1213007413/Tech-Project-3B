using System;

namespace Tech_Project_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] n = new int[25];
               
                 Console.WriteLine("There are 25 elements should be populated in the array.");
                   Console.WriteLine("___________________________________________________");
                Console.WriteLine("");
                

                for ( int i = 0; i < 25; i++)
                {
                    n[i] = i + 1;
                
                }
                foreach (int j in n) 
                {
                    int i = j;
                    Console.WriteLine("Element value = {0}", i, j);
                }
                Console.WriteLine("");
                Console.WriteLine("___________________________________________________");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
                 
            }
            catch
            {
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            

        }
    }
}
