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

//    public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
//    {
//        // Write your code here.
//        LinkedList FinalLL = null;
        
//        int carry = 0;

//        while (linkedListOne != null || linkedListTwo != null)
//        {
//            int Sum = 0;
//            if (linkedListOne != null)
//            {
//                Sum +=  linkedListOne.value;
//                linkedListOne = linkedListOne.next;
//            }

//            if (linkedListTwo != null)
//            {
//                Sum = Sum + linkedListTwo.value;
//                linkedListTwo = linkedListTwo.next;
//            }

//            Sum = Sum + carry;
//            if (Sum > 10)
//            {
//                Sum = Sum / 10;
//                carry = Sum % 10;
//            }


//            if (FinalLL == null)
//            {
//                FinalLL.value =  Sum;
//            }
            

//        }

//        return null;
//    }

//    static void Main(String[] args)
//    {
//        Program.LinkedList ll1 = addMany(new Program.LinkedList(2), new int[] { 4, 7, 1 });
//        Program.LinkedList ll2 = addMany(new Program.LinkedList(9), new int[] { 4, 5 });

//        Program pr = new Program();
//        pr.SumOfLinkedLists(ll1, ll2);

//        Program.LinkedList addMany(Program.LinkedList linkedList, int[] values)
//        {
//            var current = linkedList;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            foreach (var value in values)
//            {
//                current.next = new Program.LinkedList(value);
//                current = current.next;
//            }
//            return linkedList;
//        }
//    }
//}

