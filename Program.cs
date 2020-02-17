using System;

namespace battle_ship_in_the_oo_way_stare_bosmany
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocean myOcean = new Ocean(10, "gracz1");
            myOcean.CreateShip(3, 5, "Carrier", true);

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write(myOcean.GetSquareStatus(i ,j));

                }
                Console.WriteLine();
            }

        }
    }
}
