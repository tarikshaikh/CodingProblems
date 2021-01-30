using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingProblems
{
    public class MyStack
    {
        private int _top = -1;
        private int[] _items;
        
        public MyStack(int length)
        {
            _items = new int[length];
        }
        
        public void Push(int item)
        {
            if(_top == _items.Length - 1)
            {
                Console.WriteLine("Stack Overflow occured!");
                Console.ReadLine();
                return;
            }

            _top += 1;
            _items[_top] = item;
            Console.WriteLine(@"Item {0} pushed to stack!", item);
            Console.ReadLine();
            return;
        }

        public int Pop()
        {
            if(_top == -1)
            {
                Console.WriteLine("Stack Underflow occured!");
                Console.ReadLine();
                return -9999;
            }

            int item = _items[_top];
            _top -= 1;
            Console.WriteLine(@"Item {0} popped from stack!", item);
            Console.ReadLine();
            return item;
        }
    }
}