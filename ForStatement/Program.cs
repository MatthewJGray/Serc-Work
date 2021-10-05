using System;

namespace ForStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String strArtist = "", strAlbum = "";
            int intPrice = 0;
            int intQuantity = 0;
            int i = 1;

            //Process
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("Enter Artist Name");
                strArtist = Console.ReadLine();

                Console.WriteLine("Enter Album Name");
                strAlbum = Console.ReadLine();

                Console.WriteLine("Enter Price");
                intPrice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Quantity");
                intQuantity = Convert.ToInt32(Console.ReadLine());

            }
            Console.ReadLine();
        }
    }
}
