using System;
using System.Collections.Generic;

namespace CodingKataChangeReturn
{
    class Program
    {
        /// <summary>
        /// Change Return
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            validateParamters(args);
          
            List<decimal> euroValues = new List<decimal>() { 100, 50, 20, 10 };
            List<decimal> centValues = new List<decimal>() { 50, 20, 10, 5, 2, 1 };

            decimal changeReturn = 0;
            changeReturn = Convert.ToDecimal(args[1]) - Convert.ToDecimal(args[0]);
            Console.WriteLine(String.Format("Total cost: {0}", args[0]));
            Console.WriteLine(String.Format("Total paid: {0}", args[1]));
            foreach (decimal euroVal in euroValues)
            {
                changeReturn -= Calculater.calcAndWriteReturn("{0}-Euro-Scheine:{1}", changeReturn, euroVal);
            }
            changeReturn *= 100;

            foreach (decimal centVal in centValues)
            {
                changeReturn -= Calculater.calcAndWriteReturn("{0}-Cent-Münze:{1}", changeReturn, centVal);
            }

             Console.ReadLine();
        }
        /// <summary>
        /// Validate args
        /// </summary>
        /// <param name="args">string array</param>
        static void validateParamters(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter parameter values.");
                Console.Read();
                Environment.Exit(0);
            }
            if (Convert.ToDecimal(args[0]) > Convert.ToDecimal(args[1]))
            {
                Console.WriteLine("Please enter valid parameter values.");
                Console.Read();
                Environment.Exit(0);
            }

        }

    }
}
