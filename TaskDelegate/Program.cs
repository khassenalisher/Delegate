using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op = new Operation();
            op.RegDelegateMes(new Operation.DelegateMes(Show_Message));
            op.Sum(10, 20);
            Console.ReadLine();
        }
  
        private static void Show_Message(String message)
        {

            Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine(message);
            
        }

    }
}
