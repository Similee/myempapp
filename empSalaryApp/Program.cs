using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empSalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            
            while (y < 3)
            {
                Console.WriteLine("Please type in hourly rate");
                int hourlyrate = Convert.ToInt32(Console.ReadLine());
              
                   if (hourlyrate <= 40)
                    {
                        Console.WriteLine(hourlyrate * 10);
                    }
                    else
                    {
                        Console.WriteLine((400) + ((hourlyrate - 40) * 15));
                    }

             

                y++;
            }
            Console.ReadLine();
        }

    }
}
