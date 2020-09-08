using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Security;
using System.Text;

namespace Assigment5
{
    class Question1
    {
        public class MyStack //stack using arrays
        {
            public int top;
            public int[] items = new int[100]; //max 100 elements in the stack

            public MyStack()
            {
                top = -1;
            }

            public int Top()
            {
                if(top>=0)
                    return items[top];
                return -1;
            }
            public void Push(int a)
            {
                top++;
                if (top == 99)
                    Console.WriteLine("Stack full");
                else 
                    items[top]=a;                
            }

            public int Pop()
            {
                if (top == -1)
                {// empty stack
                    Console.WriteLine("Underflow error");
                    return -1;
                }
                int elem = items[top];
                top--;
                return elem;
            }
        
            public bool Empty()
            {
                return (top == -1) ? true : false;
            } 

        }

        // Next Greater Element
        static public void NGE_method1(int[] a)
        {
            int j = a.Length - 1;

            for(int i = 0; i < a.Length-1; i++)
            {
                for( j = i+1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        Console.WriteLine("{0} --> {1}", a[i], a[j]);
                        break;
                    }
                }
                if (j == a.Length)
                {
                    Console.WriteLine("{0} --> {1}", a[i], -1);
                }
            }
            //Last element dont have NGE
            Console.WriteLine("{0} --> {1}", a[^1],-1);
        }

        static public void NGE_method2(int[] a)
        {
            MyStack ms = new MyStack();
            int current, next;
            ms.Push(a[0]); //first element

            for (int i = 1; i < a.Length; i++)
            {
                next = a[i];

                if (!ms.Empty())
                {
                    current = ms.Pop();

                    while (current < next)
                    {
                        Console.WriteLine("{0} --> {1}", current, next);
                        if (ms.Empty())
                            break;
                        current = ms.Pop();
                    }
                    if (current > next)
                    {
                        ms.Push(current);
                    }
                }
                ms.Push(next);
            }
            while (!ms.Empty())
                Console.WriteLine("{0} --> {1}", ms.Pop(), -1);
        }

        //static void Main(string[] args)
        //{
        //    int[] a = { 4, 5, 2, 25, 11 };
        //    int[] b = { 3, 7, 6, 12 };
        //    int[] c = { 10, 9, 6, 4, 2, 1 };

        //    NGE_method1(a);
        //    Console.WriteLine("\n");
        //    NGE_method2(a);


            //MyStack ms=new MyStack();
            //Console.WriteLine("Stack empty: {0}", ms.Empty());
            //ms.Push(1);
            //ms.Push(2);
            //ms.Push(3);
            //Console.WriteLine("Stack empty: {0}", ms.Empty());
            //Console.WriteLine("Top: {0}",ms.Pop());
            //Console.WriteLine("Top: {0}", ms.Pop());
            //Console.WriteLine("Top: {0}", ms.Pop());
            //Console.WriteLine("Stack empty: {0}", ms.Empty());
       // }
    }
}
