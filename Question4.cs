using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assigment5
{
    class Question4
    {
        public class MyStack
        {
            public int Minimum;
            public Stack MyStk;

            public MyStack()
            {
                Minimum = int.MinValue; // initialize minimum
                MyStk = new Stack();
            }

            public bool Empty()
            {
                return MyStk.Count == 0;
            }
            public void Push(int n)
            {
                if (MyStk.Count == 0)
                {
                    MyStk.Push(n);
                    Minimum = n;
                }
                else
                {
                    if (n < Minimum)
                    {
                        MyStk.Push(2 * n - Minimum);
                        Minimum = n;
                    }
                    else
                    {
                        MyStk.Push(n);
                    }
                }
            }

            public int Peek()
            {
                return (int)MyStk.Peek();
            }

            public int Pop()
            {
                int top = (int)MyStk.Pop(), rval=Minimum;
                if (top < Minimum)//this means that top is the Minimum value
                {
                    Minimum = 2 * Minimum - top;
                    return rval;
                }
                return top;
            }

            public int GetMin()
            {
                return Minimum;
            }

        }
        //static public void Main(string [] args)
        //{
        //    MyStack ms = new MyStack();
        //    ms.Push(2);
        //    ms.Push(3);
        //    ms.Push(1);
        //    ms.Push(0);
        //    ms.Push(2);
        //    ms.Push(-1);


        //    Console.WriteLine("Minimum: {0}", ms.GetMin());
        //    while(!ms.Empty())
        //        Console.WriteLine("Top Element:{0}   Minimum:{1}", ms.Pop(), ms.GetMin());
        //}

    }
}
