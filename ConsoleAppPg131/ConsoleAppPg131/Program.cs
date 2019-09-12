using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPg131
{
    class Program
    {
        static void Main(string[] args)
        {
            var officeFurniturePcs = new List<string>() { "desk", "chair", "couch", "bookcase", "table"};

            var perRoomNumComputers = new List<int>() { 18, 2, 1, 4, 1, 1, 3, 1, 2};
            perRoomNumComputers = perRoomNumComputers.OrderBy(n => n).ToList();

            foreach (string officeFurniturePc in officeFurniturePcs)
            {
                Console.WriteLine(officeFurniturePc);
            }
            foreach (int perRoomNumComputer in perRoomNumComputers)
            {
                Console.WriteLine(perRoomNumComputer);
            }
            Console.ReadLine();
        }
    }
}
