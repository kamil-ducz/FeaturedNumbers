//Make a function that receives a value and outputs the smallest higher number than
//the given value and this number belongs to a set of positive integer that have the
//following properties
//-their digit occur only once
//-is odd
//-is multiple of three
//for example:
//(12) -> (15)
//(99) -> (105)
//(9999999999999999999) -> too big


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            string value = Console.ReadLine();
            if(int.TryParse(value, out int result))
            {
                try
                {
                    int finalValue = MathHelper.GetNextFeaturedNumber(int.Parse(value));
                    Console.WriteLine(finalValue);
                }
                catch
                {
                    throw new Exception();
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
    }
}
