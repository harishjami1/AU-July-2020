using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exp{
    class student{
        static void Main()
        {
            var p=new[]{"Hareesh","Rishee","Eeswar","Himesh","Rohini"};
            var y=from s in p where s.ToLower().Contains("ee")  select s;
             foreach(var ans in y)
             Console.WriteLine(ans);

        }
    }
}