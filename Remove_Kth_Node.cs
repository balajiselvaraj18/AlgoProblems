//using System;

//public class Program
//{
//    public static void RemoveKthNodeFromEnd(LinkedList head, int k)
//    {
//        // Write your code here.
//        LinkedList First = head;
//        LinkedList Second = head;
//        int cntr = 1;

//        while (cntr <= k)
//        {
//            Second = Second.Next;
//            cntr++;
//        }

//        if (Second == null)
//        {
//            head.Value = head.Next.Value;
//            head.Next = head.Next.Next;
//            return;
//        }

//        while (Second.Next != null)
//        {
//            Second = Second.Next;
//            First = First.Next;
//        }

//        First.Next = First.Next.Next;
//    }

//    public class LinkedList
//    {
//        public int Value;
//        public LinkedList Next = null;

//        public LinkedList(int value)
//        {
//            this.Value = value;
//        }
//    }
//}
