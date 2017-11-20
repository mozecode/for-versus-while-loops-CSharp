using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            count = 1;
            while (count<=4)

            { Console.WriteLine("INFS 2600");
                count = count + 1;
            }

            Console.WriteLine(); //intentionally blank
            int number;
            number = 25;

            while (number >=25 && number<=35)
            {
                Console.Write("{0} ", number);
                number = number + 1;
            }

            Console.WriteLine(); //intentionally blank
            Console.WriteLine(); //intentionally blank

            int n;
            
            for (n=25; n>=25 && n<=35; n = n+1)
            {
                Console.Write("{0} ", n);

            }

            Console.WriteLine(); //intentionally blank
            Console.WriteLine(); //intentionally blank






            Console.ReadKey();

        }

        
        
            
        }
    }

