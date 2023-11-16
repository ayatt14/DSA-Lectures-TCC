using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        static int count = 0;

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data + "\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
            count++;
            Node MyNode = new Node(val);
            if (First == null) { First = MyNode; Last = MyNode; return; }
            Last.Next = MyNode; Last = MyNode;
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First == null) { return; }

            Node curr = First;
            if (curr.Data == key)
            {
                First = curr.Next;
            }

            while (curr.Next != null)
            {
                if (curr.Next.Data == key)
                {
                    curr.Next = curr.Next.Next;
                }
                curr = curr.Next;
            }
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            Node FirstItem = other_list.First;

            while (FirstItem != null)
            {
                Last.Next = FirstItem;
                Last = FirstItem;

                FirstItem = FirstItem.Next;
            }
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            if (count == 1) return;
            Node prev = null;
            Node curr = First;
            Node next;

            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            First = prev;


        }
    }
}