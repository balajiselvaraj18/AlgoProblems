//using System;
//using System.Collections.Generic;

//public class Program
//{
//    // This is the class of the input root. Do not edit it.
//    public class BinaryTree
//    {
//        public int value;
//        public BinaryTree left;
//        public BinaryTree right;

//        public BinaryTree(int value)
//        {
//            this.value = value;
//            this.left = null;
//            this.right = null;
//        }
//    }

//    public static List<int> BranchSums(BinaryTree root)
//    {
//        // Write your code here.
//        List<int> calulate_sums = new List<int>();
//        CalculateSums(root, 0, calulate_sums);
//        return calulate_sums;
//    }

//    public static void CalculateSums(BinaryTree tree, int sumvalue, List<int> lst)
//    {
//        if (tree == null) return;

//        int curr_sumvalue = sumvalue + tree.value;

//        if(tree.left == null && tree.right == null)
//        {
//            lst.Add(curr_sumvalue);
//            return;
//        }

//        CalculateSums(tree.left, curr_sumvalue, lst);
//        CalculateSums(tree.right, curr_sumvalue, lst);
        
//    }

//}
