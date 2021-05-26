//using System;

//public class Program
//{
//    public static LinkedList FindLoop(LinkedList head)
//    {
//        // Write your code here.
//        LinkedList First = head.next;
//        LinkedList Second = head.next.next;

//        while (First != Second)
//        {
//            First = First.next;
//            Second = Second.next.next;
//        }

//        First = head;
//        while (First != Second)
//        {
//            First = First.next;
//            Second = Second.next;
//        }

//        return First;
//    }

//    public class LinkedList
//    {
//        public int value;
//        public LinkedList next = null;

//        public LinkedList(int value)
//        {
//            this.value = value;
//        }
//    }
//}
