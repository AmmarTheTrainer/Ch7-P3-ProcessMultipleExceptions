using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_P3_ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Processing Multiple Exceptions... ");

            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("New Cultus AGS", 90);
            try
            {
                // Trip Arg out of range exception.
                myCar.Accelerate(-10);
            }
            //catch (Exception e)
            //{
            //    // Process all other exceptions?
            //    Console.WriteLine(e.Message);
            //}
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (Exception e)
            //{
            //    // Process all other exceptions?
            //    Console.WriteLine(e.Message);
            //}

            Console.ReadLine();
        }
    }
}
