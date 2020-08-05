using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public int Count { get; private set; }
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public LinkedList()
        {
            Head = new Node<T>();
            Tail = Head;
        }
        public int Add(T value)
        {
            Node<T> extraNode = new Node<T>();
            extraNode.Value = value;
            Tail.Next = extraNode;
            Tail = extraNode;
            Console.WriteLine("item has been added to the LinkedList");
            return Count++;
        }
        public void print()
        {
            var check = Head;
            while (check.Next != null)
            {
                check = check.Next;
                Console.WriteLine(check.Value);
            }
            //Console.WriteLine("NULL");
        }
        public void Remove()
        {
            //not yet implemented
        }
        public bool Check(T value)
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
                if (current.Value.Equals(value)) return true;
            }
            return false;
        }
        public T Search(T value) //return type should be T. not yet implemented
        {
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
                if (current.Value.Equals(value)) return value;
            }
            throw new InvalidDataException("element not found");            
        }
        public int size()
        {
            return Count;
        }
        public void Insert()
        {
            //not yet implemented
        }
        public int Index(T value)
        {
            var increment = 0;
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
                               
                if (current.Value.Equals(value)) goto end;
                increment++;
            }
            end:   
            return increment >= Count ? -1 : increment;
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}