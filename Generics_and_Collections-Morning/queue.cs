using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericQueue{
    class queue{
        static void Main()
        {
            Queue<string> new_queue= new Queue<string>();
            new_queue.Enqueue("First");
            new_queue.Enqueue("Second");
            new_queue.Enqueue("Third");
            new_queue.Enqueue("Fourth");
             new_queue.Enqueue("Fifth");
             Console.WriteLine("Firstly the elements in the queue are");
             foreach(var k in  new_queue)//Displaying the initial queue
             Console.WriteLine(k);
                Console.WriteLine("Now we will peek the top elemment");

             Console.WriteLine(new_queue.Peek());//Peeking the queue
                 Console.WriteLine("After peeking see that the queue remains same");

             foreach(var k in  new_queue)//Displaying after peeking
             Console.WriteLine(k);
                Console.WriteLine("Now we will dequeue the top element which is");

             Console.WriteLine(new_queue.Dequeue());//Dequuing the queue
                Console.WriteLine("After dequeuing the queue will be as below");

             foreach(var k in  new_queue)//Displaying after dequeuing
             Console.WriteLine(k);
             
        }
        }
        }
