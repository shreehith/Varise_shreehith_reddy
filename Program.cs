using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace c__video
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Trailingzeroes(int num)
            {
                int factorial=1;
                for (int i = 1;i<=num;i++)
                {
                    factorial = factorial * i;
                }
                
                int count=0 ;
                
                
                while ((factorial%10)==0)
                {
                    
                    if((factorial%10)==0)
                    {
                        count++;
                    }
                    factorial =factorial / 10;
                }
                return count;
            }

            int n;
            Console.WriteLine("enter the number");
            n=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("the number of trailing zeroes are "+Trailingzeroes(n));

            int x, y,wins;
            Console.WriteLine("enter the points to qualify ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of matches ");
            y=Convert.ToInt32(Console.ReadLine());
            if (y<(x/2))
            {
                Console.WriteLine("it is impossible to qualify ");
            }
            else
            {
                wins = x / 2;
                Console.WriteLine("the minimum number of wins is " + wins);
            }

            Console.ReadLine();


            
        }
    }
}
