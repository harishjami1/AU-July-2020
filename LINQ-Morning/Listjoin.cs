using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exp{
    class Listjoin{
        static void Main()
        {
            IList<string> l1=new List<string>(){"Harish","suresh","ramesh","satish"};
            IList<string> l2=new List<string>(){"Harish","Rajesh","ramesh"};
            var com=l1.Join(l2,k1=>k1,k2=>k2,(k1,k2)=>k1);
            foreach(var val in com)
            Console.WriteLine(val);
        }
    }
    }