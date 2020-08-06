using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public void AddHead(T value)
        {
            var extraNode = new Node<T>(value);
            //check if there's a head/not available in the LinkedList
            //if there is one, then set the that current head's previous pointer to the newly addedNode
            if (Head != null)
            {
                Head.Previous = extraNode;
            }
            //set the former head to now be the new tail. that way, the newly added becomes the Head,
            //while the just displaced head will become the tail.
            Head = Tail;

            if (Tail == null)
            {
                Tail = Head;
            }

            Count++;
        }
        public void AddTail(T value)
        {
            //If tail/head is null, it means that the head is null; meaning that there's nothing in the list to begin with.
            //Thus, we call the addhead method on the value to add it to the head.
            if (Tail == null)
            {
                AddHead(value);
            }
            else
            {
                //instantiate a new node
                var extraNode = new Node<T>(value);
                //set the current Tail's next (on the second addition of an item to the linkedlist,
                //there's only one head[tail] in the list) to the new node. for subsequent ones, the last item
                //in the linkedList is the tail.
                Tail.Next = extraNode;
                Tail = extraNode;
                Count++;
            }
        }
        public void print()
        {
            var check = Head;
            while (check.Next != null)
            {
                check = check.Next;
                Console.WriteLine(check.Value);
            }
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
        public Node<T> Search(T value)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value)) return current;
                current = current.Next;
            }
            return null;           
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
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //one more method to be implemented

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}