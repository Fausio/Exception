using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public class Calc
    {

        public static double Divide(int numerator, int denominator)
        {
			try
			{
				if (denominator != 0)
				{
					return numerator / denominator;
				}
				else
				{
					return 0;
				}
				
			}
			catch (Exception DivideException)
			{
				throw DivideException;
			}
        }
    }
}
