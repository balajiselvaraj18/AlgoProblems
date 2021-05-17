//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static List<int> InOrderTraverse(BST tree, List<int> array)
//    {
//        // Write your code here.
//        if (tree.left != null)
//        {
//            InOrderTraverse(tree.left, array);
//        }
//        array.Add(tree.value);

//        if (tree.right != null)
//        {
//            InOrderTraverse(tree.right, array);
//        }
//        return array;
//    }

//    public static List<int> PreOrderTraverse(BST tree, List<int> array)
//    {
//        // Write your code here.
//        array.Add(tree.value);
//        if (tree.left != null)
//        {
//            PreOrderTraverse(tree.left, array);
//        }
//        if (tree.right != null)
//        {
//            PreOrderTraverse(tree.right, array);
//        }
//        return array;
//    }

//    public static List<int> PostOrderTraverse(BST tree, List<int> array)
//    {
//        // Write your code here.

//        if (tree.left != null)
//        {
//            PostOrderTraverse(tree.left, array);
//        }
//        if (tree.right != null)
//        {
//            PostOrderTraverse(tree.right, array);
//        }
//        array.Add(tree.value);
//        return array;
//    }

//    public class BST
//    {
//        public int value;
//        public BST left;
//        public BST right;

//        public BST(int value)
//        {
//            this.value = value;
//        }
//    }

//    static void Main(string[] args)
//    {
//        var root = new Program.BST(10);
//        root.left = new Program.BST(5);
//        root.left.left = new Program.BST(2);
//        root.left.left.left = new Program.BST(1);
//        root.left.right = new Program.BST(5);
//        root.right = new Program.BST(15);
//        root.right.right = new Program.BST(22);

//        List<int> arr = new List<int>();

//        Program.InOrderTraverse(root, arr);
//    }
//}
