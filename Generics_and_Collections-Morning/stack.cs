using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericStack{
    class stack{
        static void Main()
        {
            Stack<string> new_stack= new Stack<string>();
            new_stack.Push("First");
            new_stack.Push("Second");
            new_stack.Push("Third");
            new_stack.Push("Fourth");
            Console.WriteLine("Initially the stack is as below");

             foreach(var k in new_stack)//Displaying the stack
           Console.WriteLine(k);

           Console.WriteLine("Now we will peek the top element");
           Console.WriteLine(new_stack.Peek());//Peeking the top element

           Console.WriteLine("After peeking it still remains the same");

            foreach(var k in new_stack)//Displaying after peek
           Console.WriteLine(k);

           Console.WriteLine("Now we will pop the top element which is");//popping the top element
            Console.WriteLine(new_stack.Pop());

            Console.WriteLine("The remaining elements in the stack are");//Displaying after popping
        foreach(var k in new_stack)
           Console.WriteLine(k);

        }
    }
}