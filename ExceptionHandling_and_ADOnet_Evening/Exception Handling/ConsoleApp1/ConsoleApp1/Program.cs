using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
    {
        class Program
        {
            private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            static void Main(String[] args)
            {
                logger.Info("This is a information message");
                string path = "C:\\Users\\santosh\\Desktop\\new.txt";
                try
                {
                    string k = File.ReadAllText(path);
                Console.WriteLine(k);
                }
                catch (FileNotFoundException e)
                {
                Console.WriteLine("File in the path is not found");
                logger.Error(e.StackTrace);
                }
                catch (DirectoryNotFoundException e)
                {
                Console.WriteLine("Some Directory in the path is not found");
                logger.Error(e.StackTrace);
                }
                catch (System.Exception e)
                {
                Console.WriteLine("Unknown error occured");
                logger.Fatal(e.StackTrace);
                }
                finally
                {
                Console.WriteLine("Finally block executed");
                logger.Info("Finally Block Executed");
                }
            Console.ReadKey();
            }
        }
    }

