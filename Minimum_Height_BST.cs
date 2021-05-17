//using System;
//using System.Collections.Generic;

//public class Program
//{
//    public static BST MinHeightBst(List<int> array)
//    {
//        // Write your code here.

//        return ConstructMinHeightBST(array, null, 0, array.Count - 1);
//    }

//    public static BST ConstructMinHeightBST(List<int> array, BST bst, int startIndx, int endIndx)
//    {
//        if (endIndx < startIndx)
//            return null;

//        int midIdx = (startIndx + endIndx) / 2;
//        int cvalue = array[midIdx];

//        if (bst == null)
//        {
//            bst = new BST(cvalue);
//        }
//        else
//        {
//            bst.insert(cvalue);
//        }

//        ConstructMinHeightBST(array, bst, startIndx, midIdx - 1);
//        ConstructMinHeightBST(array, bst, midIdx + 1, endIndx);

//        return bst;
//    }

//    public class BST
//    {
//        public int value;
//        public BST left;
//        public BST right;

//        public BST(int value)
//        {
//            this.value = value;
//            left = null;
//            right = null;
//        }

//        public void insert(int value)
//        {
//            if (value < this.value)
//            {
//                if (left == null)
//                {
//                    left = new BST(value);
//                }
//                else
//                {
//                    left.insert(value);
//                }
//            }
//            else
//            {
//                if (right == null)
//                {
//                    right = new BST(value);
//                }
//                else
//                {
//                    right.insert(value);
//                }
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        //Program.retval(10);
//        var array = new List<int> {
//            1, 2, 5, 7, 10, 13, 14, 15, 22, 28, 32, 36
//        };
//        var tree = Program.MinHeightBst(array);
//    }
//}
