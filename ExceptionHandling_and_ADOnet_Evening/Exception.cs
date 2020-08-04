using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace program{
    class Exception{
        private static readonly log4net.ILog logger =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(String [] args){
           logger.Info("This is a information message");
          string path ="C:\\Users\\santosh\\Desktop\\new.txt";
            try{ 
                string k=File.ReadAlltext(path);
                Console.WriteLine(k);
            }
            catch(FileNotFounfException e){
                Console.WriteLine("File in the path is not found");
                logger.Error(e.StackTrace);
            }
            catch(DirectoryNotFoundException){
                Console.WriteLine("Some Directory in the path is not found");
                logger.Error(e.StackTrace);
            }
            catch(Exception e){
                 Console.WriteLine("Unknown error occured");
                 logger.fatal(e.StackTrace);
            }
            finally{
                Console.WriteLine("Finally block executed");
                logger.Info("Finally Block Executed");
            }
        }
    }
}