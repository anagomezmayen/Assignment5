using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assigment5
{
    class Question3
    {
        public class MyStack
        {
            Queue q1 = new Queue();

            public int Count
            {
                get { return q1.Count; }
            }

            public bool Empty()
            {
                return Count == 0;
            }

              public void Push(object obj)
            {

                q1.Enqueue(obj);
            }

            public object Pop()
            {
                if (q1 == null || q1.Count == 0)
                {
                    Console.WriteLine("Stack is empty");
                    return null;
                }
                Queue q2 = new Queue();
                //pass elements to q2

                while (q1.Count > 1)
                {
                    q2.Enqueue(q1.Dequeue());
                }
                object rVal = q1.Dequeue();
                q1 = q2;
                return rVal;
            }
        }
        //static void Main(string[] args)
        //{
        //    MyStack stack = new MyStack();
        //    stack.Push(1);
        //    stack.Push(2);
        //    stack.Push(3);
        //    stack.Push(4);
        //    stack.Push(5);
        //    stack.Push(6);
        //    stack.Push(7);
    
        //    Console.WriteLine("PRINT MY STACK");
        //    while (stack.Count > 0)
        //        Console.WriteLine("POP: {0}", stack.Pop());


        //}
    }
}
