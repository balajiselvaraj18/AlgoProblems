//using System.Collections.Generic;
//using System;


//public class Program
//{
//    // This is an input class. Do not edit.
//    public class LinkedList
//    {
//        public int value;
//        public LinkedList next;

//        public LinkedList(int value)
//        {
//            this.value = value;
//            this.next = null;
//        }
//    }

//    public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
//    {
//        // Write your code here.
//        try
//        {
//            LinkedList currentNode = linkedList;
//            while (currentNode != null)
//            {
//                LinkedList NextNode = currentNode.next;
//                while (NextNode != null && NextNode.value == currentNode.value)
//                {
//                    NextNode = NextNode.next;
//                }

//                currentNode.next = NextNode;
//                currentNode = NextNode;
//            }
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//        return linkedList;
//    }

//    public static void Main()
//    {
//        Program.LinkedList addMany(Program.LinkedList ll, List<int> values)
//        {
//            Program.LinkedList current = ll;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            foreach (var value in values)
//            {
//                current.next = new Program.LinkedList(value);
//                current = current.next;
//            }
//            return ll;
//        }


//        Program.LinkedList input = new Program.LinkedList(1);
//        addMany(input, new List<int> {
//            1, 3, 4, 4, 4, 5, 6, 6
//        });
//        List<int> expectedNodes = new List<int> {
//            1, 3, 4, 5, 6
//        };
//        Program.LinkedList output = new Program().RemoveDuplicatesFromLinkedList(input);

//    }
//}


