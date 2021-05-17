//using System;


//public class Program
//{
//    public int BinaryTreeDiameter(BinaryTree tree)
//    {
//        // Write your code here.
//        //return HelperToFindTreeDiameter(tree, 0);
//        return GetTreeInfo(tree).diameter;
//    }


//    public TreeInfo GetTreeInfo(BinaryTree tree)
//    {
//        if (tree == null)
//        {
//            return new TreeInfo(0, 0);
//        }

//        TreeInfo leftTreeInfo = GetTreeInfo(tree.left);
//        TreeInfo rightTreeInfo = GetTreeInfo(tree.right);


//        int longestPath = leftTreeInfo.height + rightTreeInfo.height;
//        int maxDiameter = Math.Max(leftTreeInfo.diameter, rightTreeInfo.diameter);

//        int currDiameter = Math.Max(longestPath, maxDiameter);
//        int currHeight = 1 + Math.Max(leftTreeInfo.height, rightTreeInfo.height);



//        return new TreeInfo(currDiameter, currHeight);
//    }

//    public class TreeInfo
//    {
//        public int diameter;
//        public int height;
//        public TreeInfo(int diameter, int height)
//        {
//            this.diameter = diameter;
//            this.height = height;
//        }
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

//    static void Main(string[] args)
//    {
//        var root = new Program.BinaryTree(1);
//        root.left = new Program.BinaryTree(3);
//        root.left.left = new Program.BinaryTree(7);
//        root.left.left.left = new Program.BinaryTree(8);
//        root.left.left.left.left = new Program.BinaryTree(9);
//        root.left.right = new Program.BinaryTree(4);
//        root.left.right.right = new Program.BinaryTree(5);
//        root.left.right.right.right = new Program.BinaryTree(6);
//        root.right = new Program.BinaryTree(2);

//        var actual = new Program().BinaryTreeDiameter(root);

//        //var root = new Program.BinaryTree(1);
//        //root.left = new Program.BinaryTree(2);
//        //root.left.left = new Program.BinaryTree(4);
//        //root.left.right = new Program.BinaryTree(5);
//        //root.right = new Program.BinaryTree(3);
//        //root.right.left = new Program.BinaryTree(6);
//        //root.right.right = new Program.BinaryTree(7);
//        //var actual = new Program().BinaryTreeDiameter(root);
//    }
//}

