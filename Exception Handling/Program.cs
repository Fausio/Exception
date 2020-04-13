using BLL;
using System;


namespace Exception_Handling
{
    /*
     Runtime error is called as an exception
     exception handling is an in-build mechanism in .Net core to detect and handle runtime erros 
     C# provides three keywords(try, cath, finally) to do exception handling 
     the trey encloses the statements that might throw an exception
     the catch handles an exception if one exists 
     the finally can be used for doid any clean up process.
      */
    class Program
    {
        static void Main(string[] args)
        {
            //int[] vs = new int[2];
            #region System.IndexOutOfRangeException / System.DivideByZeroException

            //try
            //{

            //    vs[0] = 2;
            //    vs[1] = 0;

            //    // it will through an exception here 
            //    int divider = vs[0] / vs[1];
            //    vs[2] = 9;


            //}
            //catch (IndexOutOfRangeException index)
            //{

            //    Console.WriteLine("Exception message is : {0}", index);
            //}
            //catch (DivideByZeroException  dev)
            //{
            //    vs[1] = 2;

            //    Console.WriteLine("Exception message is : {0}", dev);

            //}
            ////catch (Exception ex) // this class Exception is a base Exception class  (Runtime polymorphism)
            ////{ 
            ////    Console.WriteLine("Exception message is : {0}", ex); 
            ////}
            //finally { }
            #endregion

            try
            {
                var result = Calc.Divide(10, 0);
                Console.WriteLine("The result is {0}", result);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exceprion Message is : " + ex.Message);
            }
            finally
            {
                // We usually kill the process here (close conection,windows form etc)
            }




            Console.ReadKey();
        }
    }
}
