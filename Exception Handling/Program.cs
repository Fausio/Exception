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

            try
            {
                int[] vs = new int[2];
                vs[0] = 2;
                vs[1] = 8;
                // it will through an exception here 
                vs[2] = 9;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception message is : {0}", ex);
            }


            Console.ReadKey();
        }
    }
}
