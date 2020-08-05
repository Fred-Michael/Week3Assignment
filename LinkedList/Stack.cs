using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class stack<T>
    {
        List<T> result = new List<T>();
        public void push(T value)
        {
            Console.WriteLine("item has been pushed to the Stack");
            result.Add(value);
        }
        public bool isEmpty()
        {
            var check = result.Count;
            return check == 0 ? true : false;
        }
        public T pop()
        {
            if (result.Count == 0) throw new IndexOutOfRangeException("There's no element in the stack");

            var x = result.ToArray();
            var temp = x[x.Length - 1];
            result.Remove(result[result.Count - 1]);
            
            return temp;
        }
        public T peek()
        {
            if (result.Count < 1) throw new IndexOutOfRangeException("There's no element in the stack");

            return result[result.Count - 1];
        }
        public void size()
        {
            Console.WriteLine(result.Count);
        }
        public void printItems()
        {
            for (int k = (result.Count - 1); k >= 0; k--)
            {
                Console.WriteLine(result[k]);
            }
        }
    }
}