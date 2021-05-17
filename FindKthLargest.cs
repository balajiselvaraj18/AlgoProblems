//using System;
//using System.Collections.Generic;
//using System.Data;


//public class Program
//{
//    // This is an input class. Do not edit.
//    public class BST
//    {
//        public int value;
//        public BST left = null;
//        public BST right = null;

//        public BST(int value)
//        {
//            this.value = value;
//        }
//    }
//    public int FindKthLargestValueInBst(BST tree, int k)
//    {
//        // Write your code here.
//        List<int> listKthVal = new List<int>();
//        helperToFindKtElem(tree, listKthVal);
//        return listKthVal[listKthVal.Count - k];
        
//    }

//    public void helperToFindKtElem(BST tree, List<int> lstKthValue)
//    {
//        if (tree == null)
//            return;

//        helperToFindKtElem(tree.right, lstKthValue);
//        lstKthValue.Add(tree.value);
//        helperToFindKtElem(tree.left, lstKthValue);
//    }

//    static void Main(string[] args)
//    {
//        Program.BST root = new Program.BST(15);
//        root.left = new Program.BST(5);
//        root.left.left = new Program.BST(2);
//        root.left.left.left = new Program.BST(1);
//        root.left.left.right = new Program.BST(3);
//        root.left.right = new Program.BST(5);
//        root.right = new Program.BST(20);
//        root.right.left = new Program.BST(17);
//        root.right.right = new Program.BST(22);
//        int k = 3;
//        var actual = new Program().FindKthLargestValueInBst(root, k);
//    }
//}

