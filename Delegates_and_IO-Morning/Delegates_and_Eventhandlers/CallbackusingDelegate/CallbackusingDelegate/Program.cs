using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallbackusingDelegate
{
    public delegate void CallbackafterTaskcomplete(string finalResult);
    public class CallBack
    {
        public void NewTask(CallbackafterTaskcomplete taskCompletedCallBack)
        {
            Console.WriteLine("New task Started");
            if (taskCompletedCallBack != null)
                taskCompletedCallBack("Task Completed");
        }
    }
    public class CallBackTest
    {
        public void Test()
        {
            CallbackafterTaskcomplete callback = TestCallBack;
            CallBack testCallBack = new CallBack();
            testCallBack.NewTask(callback);
        }
        public void TestCallBack(string result)
        {
            Console.WriteLine(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            CallBackTest callBackTest = new CallBackTest();
            callBackTest.Test();
            Console.ReadKey();

        }
    }
}