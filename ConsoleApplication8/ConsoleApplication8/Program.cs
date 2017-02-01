using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static string converter( int input, int baase)
        {
            int temp = 0;
            double temp_output = 0;
            string output = "";
            while(input>0)
            {
                temp = input % baase;
                input = input / baase;
                temp_output += baase;
                //output += temp;
                Console.WriteLine(temp);
                
            }
            Console.WriteLine(temp_output);
            return output;
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(converter(b, a));
            Console.ReadLine();
        }
        
    }
}
