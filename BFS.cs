//using System;
//using System.Collections.Generic;

//public class Program
//{
//    // Do not edit the class below except
//    // for the BreadthFirstSearch method.
//    // Feel free to add new properties
//    // and methods to the class.
//    public class Node
//    {
//        public string name;
//        public List<Node> children = new List<Node>();

//        public Node(string name)
//        {
//            this.name = name;
//        }

//        public List<string> BreadthFirstSearch(List<string> array)
//        {
//            // Write your code here.
//            Program.Node graph = new Program.Node("A");
//            graph.AddChild("B").AddChild("C").AddChild("D");
//            graph.children[0].AddChild("E").AddChild("F");
//            graph.children[2].AddChild("G").AddChild("H");
//            graph.children[0].children[1].AddChild("I").AddChild("J");
//            graph.children[0].children[1].children[0].AddChild("M").AddChild("N");
//            graph.children[2].children[0].AddChild("K");

//            Queue<Node> que = new Queue<Node>();
//            que.Enqueue(this);

//            while (que.Count > 0)
//            {
//                Node current = que.Dequeue();
//                array.Add(current.name);

//                foreach (var val in current.children)
//                {
//                    que.Enqueue(val);
//                }
//            }
//            return array;
//        }

//        public Node AddChild(string name)
//        {
//            Node child = new Node(name);
//            children.Add(child);
//            return this;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Program.Node graph = new Program.Node("A");
//        graph.AddChild("B").AddChild("C").AddChild("D");
//        graph.children[0].AddChild("E").AddChild("F");
//        graph.children[2].AddChild("G").AddChild("H");
//        graph.children[0].children[1].AddChild("I").AddChild("J");
//        graph.children[2].children[0].AddChild("K");
//        string[] expected = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
//        List<string> inputArray = new List<string>();
//        graph.BreadthFirstSearch(inputArray);
//    }
//}




