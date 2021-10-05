using System;

namespace RecordsDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            String strArtistName = "", strAlbumName = "";
            Double dblPrice = 0;
            int intQuantity = 0;
            int i = 1;
            //Do while Loop
            do
            {
                Console.WriteLine("Please enter the name of the recording artist.");
                strArtistName = Console.ReadLine();

                Console.WriteLine("Please enter the name of the album.");
                strAlbumName = Console.ReadLine();

                Console.WriteLine("Please enter the price.");
                dblPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the quantity.");
                intQuantity = Convert.ToInt32(Console.ReadLine());
                i++;// itteration counter
            }
            while (i <=4);
            {
                
                    }
        }
    }
}
