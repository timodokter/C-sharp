using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    internal class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;

        private static void Main(string[] args)
        {
            logger.Trace("the program started ");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CraztMathProblem();
            ReadTextFiles();
            Console.ReadLine();
        }

        private static void ReadTextFiles()
        {
            try
            {
                using (var sr = new StreamReader(@"D:\documenten\test.txt"))
                {
                    var contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
                logger.Error("the directory was not found." + ex.Message);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file.");
                logger.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("unknown error occured " + ex.Message);
            }
            finally
            {
                Console.WriteLine("the finally statement Runs all the time");
            }
        }

        public static int CraztMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--) income = income = income / i;

            return income;
        }
    }
}