using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Stack_Queue
    {
        public Stack_Queue()
        {

        }

        public void Call()
        {
            // FIFO - First In First Out
            Console.WriteLine($"queue:");
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while(queue.Count > 0)
            {
                var value = queue.Dequeue();
                Console.Write($"{value}");
            }

            Console.WriteLine(Environment.NewLine);
            // FILO - First in Last out
            Console.WriteLine($"stack:");
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while(stack.Count > 0)
            {
                var value = stack.Pop();
                Console.Write($"{value}");
            }
        }
    }
}
