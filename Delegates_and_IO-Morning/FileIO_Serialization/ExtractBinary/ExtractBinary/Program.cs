using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExtractBinary
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the path to a text file ");
            string path = Console.ReadLine();

            Boolean flag = true;
            while (flag)
            {
                path = Console.ReadLine();
                if (!File.Exists(path))
                {
                    Console.WriteLine("Not found File at " + path);
                    Console.WriteLine("Enter correct path");
                }
                else
                    flag = false;
            }
          

      
            FileStream file = File.OpenRead(path);
                byte[] data = new byte[file.Length];
                file.Read(data, 0, (int)file.Length);
                file.Close();

                StreamWriter newFile = new StreamWriter(path + ".new.txt");
                for (int i = 0; i < data.Length; i++)
                {
                    if (((Convert.ToInt32(data[i]) >= 32) &&
                    (Convert.ToInt32(data[i]) <= 127)) ||
                    (Convert.ToInt32(data[i]) == 10) ||
                    (Convert.ToInt32(data[i]) == 13))
                    {
                        newFile.Write(Convert.ToChar(data[i]));
                    }
                }

                newFile.Close();
            
           Console.ReadKey();
        } 
    }
}
