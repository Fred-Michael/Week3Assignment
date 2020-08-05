using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class queue<T>
    {
        List<T> result = new List<T>();        
        public bool isEmpty()
        {
            var checkContents = result.Count;
            return checkContents == 0 ? true : false;
        }
        public void enqueue(T value)
        {
            Console.WriteLine("item has been enqueued");
            result.Add(value);
        }
        public T dequeue()
        {
            if (result.Count == 0)
            {
                throw new IndexOutOfRangeException("There's no element in the Queue");
            }
            var x = result.ToArray();
            var temp = x[0];
            result.Remove(result[0]);

            return temp;
        }
        public void size()
        {
            Console.WriteLine(result.Count);
        }
        public void printItems()
        {
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}