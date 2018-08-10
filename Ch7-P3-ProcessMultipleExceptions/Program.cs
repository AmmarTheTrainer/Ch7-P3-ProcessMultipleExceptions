using System;
using System.Collections.Generic;
using System.IO;
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

            //Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            //Car myCar = new Car("New Cultus AGS", 90);
            //try
            //{
            //    // Trip Arg out of range exception.
            //    myCar.Accelerate(-10);
            //}
            ////catch (Exception e)
            ////{
            ////    // Process all other exceptions?
            ////    Console.WriteLine(e.Message);
            ////}
            //catch (CarIsDeadException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    // Process all other exceptions?
            //    Console.WriteLine(e.Message);
            //}


            #region General catch Statements

            //Car myCar = new Car("Rusty", 90);
            //try
            //{
            //    myCar.Accelerate(90);
            //}
            //catch
            //{
            //    Console.WriteLine("Something bad happened...");
            //}

            #endregion

            #region Rethrowing Exceptions

            //Car myCar = new Car("Rusty", 90);

            //try
            //{
            //    // Speed up car logic...
            //    myCar.Accelerate(90);
            //}
            //catch (CarIsDeadException e)
            //{
            //    // Do any partial processing of this error and pass the buck.
            //    throw;
            //}

            #endregion

            #region Inner Exception

            //Car myCar = new Car("Rusty", 90);

            //try
            //{
            //    // Speed up car logic...
            //    myCar.Accelerate(90);
            //}
            //catch (CarIsDeadException e)
            //{
            //    try
            //    {
            //        FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
            //        //...
            //    }
            //    catch (Exception e2)
            //    {
            //        // Throw an exception that records the new exception,
            //        // as well as the message of the first exception.
            //        throw new CarIsDeadException(e.Message, e2);
            //        //throw new CarIsDeadException(e.Message, e2);
            //    }
            //}

            #endregion

            #region The finally block

            //Car myCar = new Car("New Culuts AGS", 90);
            //myCar.CrankTunes(true);
            //try
            //{
            //    // Speed up car logic.
            //}
            //catch (CarIsDeadException e)
            //{
            //    // Process CarIsDeadException.
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    // Process ArgumentOutOfRangeException.
            //}
            //catch (Exception e)
            //{
            //    // Process any other Exception.
            //}
            //finally
            //{
            //    // This will always occur. Exception or not.
            //    myCar.CrankTunes(false);
            //}

            #endregion

            #region Exception filters


            //Car myCar = new Car("New Culuts AGS", 90);
            //myCar.CrankTunes(true);
            //try
            //{
            //    myCar.Accelerate(40);
            //    // Speed up car logic.
            //}
            //catch (CarIsDeadException e) when (e.ErrorTimeStamp.DayOfWeek != DayOfWeek.Sunday)
            //{
            //    // This new line will only print if the when clause evaluates to true.
            //    Console.WriteLine("Catching car is dead!");
            //    Console.WriteLine(e.Message);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    // Process ArgumentOutOfRangeException.
            //}

            #endregion

            #region Debugging Unhandled Exceptions Using Visual Studio

            Car myCar = new Car("Rusty", 90);
            myCar.Accelerate(2000);

            #endregion

            Console.ReadLine();
        }
    }
}
