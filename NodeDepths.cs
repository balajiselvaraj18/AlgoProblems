//using System;

//public class Program
//{
//    public static int NodeDepths(BinaryTree root)
//    {
//        // Write your code here.
//        NodeCalc(root, 0);
//        return -1;
//    }

//    public static int NodeCalc(BinaryTree root, int depth)
//    {
//        if (root == null) return 0;

//        return depth + NodeCalc(root.left, depth + 1) + depth + NodeCalc(root.right, depth + 1);
//    }

//    public class BinaryTree
//    {
//        public int value;
//        public BinaryTree left;
//        public BinaryTree right;

//        public BinaryTree(int value)
//        {
//            this.value = value;
//            left = null;
//            right = null;
//        }
//    }
//}
