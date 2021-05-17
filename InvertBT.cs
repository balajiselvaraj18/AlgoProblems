//using System;
//using System.Collections.Generic;
//using System.Data;

//public class Program
//{
//    public static void InvertBinaryTree(BinaryTree tree)
//    {
//        // Write your code here.
//    }

//    public class BinaryTree
//    {
//        public int value;
//        public BinaryTree left;
//        public BinaryTree right;

//        public BinaryTree(int value)
//        {
//            this.value = value;
//        }
//    }
//}
////private bool compareBT(Program.BinaryTree tree1, InvertedBinaryTree tree2)
////{
////    if (tree1 == null && tree2 == null)
////    {
////        return true;
////    }
////    if (tree1 != null && tree2 != null)
////    {
////        return tree1.value == tree2.value &&
////               compareBT(tree1.left, tree2.left) && compareBT(tree1.right,
////                 tree2.right);
////    }
////    return false;
////}

//class InvertedBinaryTree
//{
//    public int value;
//    public InvertedBinaryTree left;
//    public InvertedBinaryTree right;

//    public InvertedBinaryTree(int value)
//    {
//        this.value = value;
//    }

//    public void insert(int[] values, int i)
//    {
//        if (i >= values.Length)
//        {
//            return;
//        }
//        List<InvertedBinaryTree> queue = new List<InvertedBinaryTree>();
//        queue.Add(this);
//        var index = 0;
//        while (index < queue.Count)
//        {
//            InvertedBinaryTree current = queue[index];
//            index += 1;
//            if (current.right == null)
//            {
//                current.right = new InvertedBinaryTree(values[i]);
//                break;
//            }
//            queue.Add(current.right);
//            if (current.left == null)
//            {
//                current.left = new InvertedBinaryTree(values[i]);
//                break;
//            }
//            queue.Add(current.left);
//        }
//        insert(values, i + 1);
//    }
//}

//public class TestBinaryTree : Program.BinaryTree
//{
//    public TestBinaryTree(int value) : base(value)
//    {
//    }

//    public void insert(int[] values, int i)
//    {
//        if (i >= values.Length)
//        {
//            return;
//        }
//        List<Program.BinaryTree> queue = new List<Program.BinaryTree>();
//        queue.Add(this);
//        var index = 0;
//        while (index < queue.Count)
//        {
//            Program.BinaryTree current = queue[index];
//            index += 1;
//            if (current.left == null)
//            {
//                current.left = new Program.BinaryTree(values[i]);
//                break;
//            }
//            queue.Add(current.left);
//            if (current.right == null)
//            {
//                current.right = new Program.BinaryTree(values[i]);
//                break;
//            }
//            queue.Add(current.right);
//        }
//        insert(values, i + 1);
//    }
//}

