using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            Console.WriteLine("WHERE SHOULD WE SHOOT! 1-10?");
            string Gun;
            Gun = Console.ReadLine();

            if (Gun == "7")
            {
                Console.WriteLine("Perfect Hit!");

            }
            else if (Gun == "6" || Gun == "8")
            {
                Console.WriteLine("Near Miss");


            }

            else
            {
                Console.WriteLine("Total Miss");
            }
            Console.ReadLine();
        }
    }
}
