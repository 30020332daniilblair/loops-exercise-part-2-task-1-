using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_part_2_task_1
{
    class Program
    {
        static void Main(string[] args)
            //My Name Is Dan And Im The Mastermind Behind This Program
        {
            Console.WriteLine("This Is The While Loop ");

            int start = 76;
            int finish = 46;
            while (start >= finish)
            {

                if (start % 2 != 0)
                    Console.WriteLine(start);
                start--;


            }
            Console.ReadLine();
        }
    }
}
