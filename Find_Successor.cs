//using System;


//public class Program
//{
//    // This is an input class. Do not edit.
//    public class BinaryTree
//    {
//        public int value;
//        public BinaryTree left = null;
//        public BinaryTree right = null;
//        public BinaryTree parent = null;

//        public BinaryTree(int value)
//        {
//            this.value = value;
//        }
//    }

//    public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
//    {
//        // Write your code here.
//        if (node.left != null)
//        {
//            return successorValue_on_Left(node);
//        }
//        return successorValue_On_Right(node);
//    }

//    public BinaryTree successorValue_On_Right(BinaryTree node)
//    {
//        BinaryTree currNode = node;

//        while (currNode.parent != null && currNode.parent.right == currNode)
//        {
//            currNode = currNode.parent;
//        }
//        return currNode;
//    }

//    public BinaryTree successorValue_on_Left(BinaryTree node)
//    {
//        BinaryTree currentNode = node;
//        while (currentNode.left != null)
//        {
//            currentNode = currentNode.left;
//        }
//        return currentNode;
//    }



//    static void Main(string[] args)
//    {
//        Program.BinaryTree root = new Program.BinaryTree(1);
//        root.left = new Program.BinaryTree(2);
//        root.left.parent = root;
//        root.right = new Program.BinaryTree(3);
//        root.right.parent = root;
//        root.left.left = new Program.BinaryTree(4);
//        root.left.left.parent = root.left;
//        root.left.right = new Program.BinaryTree(5);
//        root.left.right.parent = root.left;
//        root.left.left.left = new Program.BinaryTree(6);
//        root.left.left.left.parent = root.left.left;
//        Program.BinaryTree node = root.left.right;
//        Program.BinaryTree expected = root;
//        Program.BinaryTree actual = new Program().FindSuccessor(root, node);
//    }
//}

