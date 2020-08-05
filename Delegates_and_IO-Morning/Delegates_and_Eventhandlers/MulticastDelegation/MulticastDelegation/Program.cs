using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegation
{
    public delegate void join(string s, string t);
    class Program
    {
        string property;
        static void Main(string[] args)
        {
      
            Program pro = new Program();
            join joinDel = new join(pro.func1);
            joinDel += pro.func2;
            Console.WriteLine("Enter the string 1:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the string 2");
            string t = Console.ReadLine();
            joinDel.Invoke(s, t);
            Console.WriteLine("\nFinal String :" + pro.property);
            Console.ReadKey();
        }
        public void func1(String s, String t)
        {

            this.property += s.Length > t.Length ? s : t;
        }
        public void func2(String s, String t)
        {
            this.property += s.Length > t.Length ? s : t;

        }
        
    }
}
