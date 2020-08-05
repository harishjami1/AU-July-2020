using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class Program
    { 
        static void Main(string[] args)
        {
           string path = "D://Mydir";
            Directory.CreateDirectory(path);
            Console.WriteLine("Directoy Mydir is created");

            path = "D://Mydir//First.txt";
            using (StreamWriter sw = File.CreateText(path)) {
                Console.WriteLine("The file First.txt Created");
                sw.WriteLine("This is the first Line");
                sw.WriteLine("This is the Second Line");
                sw.WriteLine("This is the Third Line");
                sw.WriteLine("This is the Fourth Line");
                sw.WriteLine("This is the Fifth Line");
                Console.WriteLine("The text is written into the file  Successfully");
            }
            int count = 0;
            int k = 0;
            Stack<String> stack = new Stack<String>();
            string line;
            using (StreamReader sr = new StreamReader(path)) {
                while (( line = sr.ReadLine()) != null) {
                   
                    count++;
                    stack.Push(line);
                    k += line.Split().Length;
                }
            }
            Console.WriteLine("The number of words in the file First.txt are "+k);
                path = "D://Mydir//Second.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                Console.WriteLine("The second file Second.txt is created successfully");
                for (int i=0;i<count;i++)
                sw.WriteLine(stack.Pop());
                Console.WriteLine("Written to the 2nd file Second.txt in the reverse order");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
