using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exp{
class vowelcount{
    static void Main()
    {
        var p=new[]{'a','e','i','o','u'};
        Console.WriteLine("Enter a string to count no. of vowels");
        var str=Console.ReadLine().ToLower();
        var v_count=str.Count(item =>p.Contains(item));
        Console.WriteLine("The total no. of vowels in the entered string are {0}",v_count);
    }
}


}