using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment5
{
    class Question5
    {
        public class MyLRUCache
        {
            private LinkedList<KeyValuePair<string, int>> list;
            private Dictionary<string, LinkedListNode<KeyValuePair<string, int>>> map;

            private int Capacity; //size

            public MyLRUCache(int Capacity)
            {
                this.Capacity = Capacity;
                list = new LinkedList<KeyValuePair<string, int>>();
                map = new Dictionary<string, LinkedListNode<KeyValuePair<string, int>>>();
            }

            public int Get(string key)// return the value 
            {
                if (!map.ContainsKey(key)) 
                    return -1;
                var node = map[key];
                list.Remove(node);
                map[key] = list.AddFirst(node.Value);
                return node.Value.Value;
            }

            public void Put(string key, int value)
            {
                if (map.ContainsKey(key))
                {
                    var node = map[key];
                    list.Remove(node);
                    map[key] = list.AddFirst(new KeyValuePair<string, int>(key, value));
                }
                else
                {
                    if (list.Count >= this.Capacity)
                    {
                        string k = list.Last.Value.Key;
                        Console.WriteLine("this pushes out key ={0} as LRU is full.",k);

                        map.Remove(k);
                        list.RemoveLast();
                    }
                    map[key] = list.AddFirst(new KeyValuePair<string, int>(key, value));
                }
            }
            //   static public void Main(string[] args)
            //{
            //    Console.WriteLine("Creating a LRU with capacity= 3");
            //    MyLRUCache mlru = new MyLRUCache(3);

            //    Console.WriteLine("Adding chocolate");
            //    mlru.Put("chocolate", 3);

            //    Console.WriteLine("Adding vanilla");
            //    mlru.Put("vanilla", 4);

            //    Console.WriteLine("Adding strawberry");
            //    mlru.Put("strawberry", 5);

            //   Console.WriteLine("Looking for key:chocolate in the LRU: {0}", mlru.Get("chocolate"));

            //    Console.WriteLine("Adding honey");
            //    mlru.Put("honey", 1);

            //    Console.WriteLine("Looking for key:chocolate in the LRU: {0}", mlru.Get("chocolate"));
            //    Console.WriteLine("Looking for key:honey in the LRU: {0}", mlru.Get("honey"));
            //}
        }
    }
}
