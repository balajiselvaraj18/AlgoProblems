//using System;
//using System.Collections.Generic;
//// Feel free to add new properties and methods to the class.
//public class Program1
//{


//    public class DoublyLinkedList
//    {
//        public Node Head;
//        public Node Tail;

//        public void SetHead(Node node)
//        {
//            // Write your code here.

//            if (Head == null)
//            {
//                Head = node;
//                Tail = node;
//                return;
//            }

//            InsertBefore(Head, node);
//        }

//        public void SetTail(Node node)
//        {
//            // Write your code here.

//            if (Tail == null)
//            {
//                SetHead(node);
//                return;
//            }

//            InsertAfter(Tail, node);
//        }

//        public void InsertBefore(Node node, Node nodeToInsert)
//        {
//            // Write your code here.

//            if (nodeToInsert == Head || nodeToInsert == Tail) return;
//            Remove(nodeToInsert);

//            nodeToInsert.Prev = node.Prev;
//            nodeToInsert.Next = node;

//            if (node.Prev == null)
//            {
//                Head = nodeToInsert;
//            }
//            else
//            {
//                node.Prev.Next = nodeToInsert;
//            }
//            node.Prev = nodeToInsert;

//        }

//        public void InsertAfter(Node node, Node nodeToInsert)
//        {
//            // Write your code here.

//            if (nodeToInsert == Head || nodeToInsert == Tail) return;

//            Remove(nodeToInsert);

//            nodeToInsert.Prev = node;
//            nodeToInsert.Next = node.Next;

//            if (node.Next == null)
//            {
//                Tail = nodeToInsert;
//            }
//            else
//            {
//                node.Next.Prev = nodeToInsert;
//            }

//            node.Next = nodeToInsert;
//        }

//        public void InsertAtPosition(int position, Node nodeToInsert)
//        {
//            // Write your code here.

//            if (position == 1)
//            {
//                SetHead(nodeToInsert);
//                return;
//            }

//            Node node = Head;
//            int currPost = 1;
//            while (node != null && currPost++ != position)
//            {
//                node = node.Next;
//            }
//            if (node != null)
//            {
//                InsertBefore(node, nodeToInsert);
//            }
//            else
//            {
//                SetTail(nodeToInsert);
//            }
//        }

//        public void RemoveNodesWithValue(int value)
//        {
//            // Write your code here.
//            Node node = Head;
//            while (node != null)
//            {
//                if (node.Value == value)
//                {
//                    Remove(node);
//                }
//                else
//                {
//                    node = node.Next;
//                }
//            }
//        }

//        public void Remove(Node node)
//        {
//            if (node.Next == Head)
//            {
//                Head = Head.Next;
//            }

//            if (node.Next == Tail)
//            {
//                Tail = Tail.Next;
//            }

//            RemoveBindings(node);

//            // Write your code here.
//        }

//        private void RemoveBindings(Node node)
//        {
//            if (node.Prev != null) node.Prev.Next = node.Prev;
//            if (node.Next != null) node.Next.Prev = node.Next;
//            node.Prev = null;
//            node.Next = null;
//        }

//        public bool ContainsNodeWithValue(int value)
//        {
//            // Write your code here.

//            Node node = Head;
//            while (node != null && node.Value != value)
//            {
//                node = node.Next;
//            }

//            return node != null;
//        }
//    }

//    // Do not edit the class below.
//    public class Node
//    {
//        public int Value;
//        public Node Prev;
//        public Node Next;

//        public Node(int value)
//        {
//            this.Value = value;
//        }
//    }



//}
