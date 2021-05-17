//using System;


//public class Program
//{
//    // This is an input class. Do not edit.
//    public class BinaryTree
//    {
//        public int value;
//        public BinaryTree left = null;
//        public BinaryTree right = null;

//        public BinaryTree(int value)
//        {
//            this.value = value;
//        }
//    }

//    public bool HeightBalancedBinaryTree(BinaryTree tree)
//    {
//        // Write your code here.
//        return Helper_FindHeiBalBT(tree).isBalanced;
//    }

//    public HelperClsForHeightBalBT Helper_FindHeiBalBT(BinaryTree tree)
//    {
         
//        if (tree == null)
//        {
//            return new HelperClsForHeightBalBT(true, -1);
//        }

//        HelperClsForHeightBalBT leftTreepart = Helper_FindHeiBalBT(tree.left);
//        HelperClsForHeightBalBT RightTreePart = Helper_FindHeiBalBT(tree.right);


//        bool isBalancedBT = leftTreepart.isBalanced && RightTreePart.isBalanced && Math.Abs(leftTreepart.height - RightTreePart.height) <= 1;
        
//        int height = Math.Max(leftTreepart.height, RightTreePart.height) + 1;

//        return new HelperClsForHeightBalBT(isBalancedBT, height);
//    }

//    public class HelperClsForHeightBalBT
//    {
//        public bool isBalanced;
//        public int height;
//        public HelperClsForHeightBalBT(bool isBalanced, int height)
//        {
//            this.isBalanced = isBalanced;
//            this.height = height;
//        }
//    }
//    static void Main(string[] args)
//    {
//        Program.BinaryTree root = new Program.BinaryTree(1);
//        root = new Program.BinaryTree(1);
//        root.left = new Program.BinaryTree(2);
//        root.right = new Program.BinaryTree(3);
//        root.left.left = new Program.BinaryTree(4);
//        root.left.right = new Program.BinaryTree(5);
//        root.right.right = new Program.BinaryTree(6);
//        root.left.right.left = new Program.BinaryTree(7);
//        root.left.right.right = new Program.BinaryTree(8);
//        bool expected = true;
//        var actual = new Program().HeightBalancedBinaryTree(root);
//    }
//}
