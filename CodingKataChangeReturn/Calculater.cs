using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKataChangeReturn
{
    /// <summary>
    /// Class to calculate and write return values
    /// </summary>
    public static class Calculater
    {
        /// <summary>
        /// Calculate and write information to the console app
        /// </summary>
        /// <param name="outputString"> String for the output window</param>
        /// <param name="changeReturn">sum change</param>
        /// <param name="money"> money value</param>
        /// <returns>total that has been calculated</returns>
        public static decimal calcAndWriteReturn(string outputString, decimal changeReturn, decimal money)
        {
            var calculatedValue = Math.Floor(changeReturn / money);
            writeOutput(outputString, money, calculatedValue);
            return calculatedValue * money;
        }
        /// <summary>
        /// Write output information
        /// </summary>
        /// <param name="outputString">Text with placeholders</param>
        /// <param name="moneyTyp">Money value</param>
        /// <param name="val"> how much pieces</param>
        public static void writeOutput(string outputString, decimal moneyTyp, decimal val)
        {
            Console.WriteLine(String.Format(outputString, moneyTyp.ToString(), val.ToString()));
        }
    }
}
