using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assigment5
{
    class Question2
    {
        public class MyQueue
        {
            Stack s1 = new Stack(); //main stack
            Stack s2 = new Stack();

            public int Count
            {
                get {return s1.Count; }
            }

            public void EnQueue(object obj)
            {
                s1.Push(obj);
            }

            public object DeQueue()
            {
                if (s1 == null || s1.Count == 0)
                    return null;

                // Pass to aux stack
                while (s1.Count > 0)
                    s2.Push(s1.Pop());

                object rVal = s2.Pop();

                // Send back to stack
                while (s2.Count > 0)
                    s1.Push(s2.Pop());

                return rVal;
            }
        }
        public class MyQueue2
        {
            Stack s1 = new Stack(); //main stack
            Stack s2 = new Stack();
            bool reversed = false;

            public int Count
            {
                get { return s1.Count+s2.Count;
                }
            }
            private void ReverseStack(int v)
            {
                if (v == 0)
                { //all values go to s2
                    while (s1.Count > 0)
                        s2.Push(s1.Pop());
                }
                else
                { //sent back to stack 1
                    while (s2.Count > 0)
                        s1.Push(s2.Pop());
                }
            }

            public void EnQueue(object obj)
            {
                if (reversed)
                    ReverseStack(1);
                s1.Push(obj);
            }

            public object DeQueue()
            {
                if (!reversed)
                    ReverseStack(0);
                if (s2 == null || s2.Count == 0)
                {
                    Console.WriteLine("Queue is empty");
                    return null;
                }
                return s2.Pop();
            }
        }
        //static void Main(string[] args)
        //{
        //    MyQueue queue = new MyQueue();
        //    queue.EnQueue(1);
        //    queue.EnQueue(2);
        //    queue.EnQueue(3);
        //    queue.EnQueue(4);
        //    queue.EnQueue(5);
        //    queue.EnQueue(6);
        //    queue.EnQueue(7);

        //    Console.WriteLine("PRINT MY QUEUE");
        //    while (queue.Count > 0)
        //        Console.WriteLine("POP: {0}", queue.DeQueue());

        //    MyQueue2 queue2 = new MyQueue2();
        //    queue2.EnQueue(11);
        //    queue2.EnQueue(12);
        //    queue2.EnQueue(13);
        //    queue2.EnQueue(14);
        //    queue2.EnQueue(15);
        //    queue2.EnQueue(16);
        //    queue2.EnQueue(17);
           
        //    Console.WriteLine("PRINT MY QUEUE");
        //    while (queue2.Count > 0)
        //      Console.WriteLine("POP: {0}", queue2.DeQueue());
        //}

    }
}
