//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IntPractProb
//{
//    class SortedArraytoBalancedBST
//    {
//        public class BST
//        {
//            int val;
//            BST left;
//            BST right;

//            public BST(int value)
//            {
//                this.val = value;
//                left = null;
//                right = null;
//            }

//            public void insert(int valtoIns)
//            {
//                if (valtoIns < this.val)
//                {
//                    if (left == null)
//                    {
//                        left = new BST(valtoIns);
//                    }
//                    else
//                    {
//                        left.insert(valtoIns);
//                    }
//                }
//                else
//                {
//                    if (right == null)
//                    {
//                        right = new BST(valtoIns);
//                    }
//                    else
//                    {
//                        right.insert(valtoIns);
//                    }
//                }
//            }
//        }

//        public static BST BalancesBST(List<int> arr)
//        {
//            return ComputeBalBST(arr, null, 0, arr.Count);
//        }

//        public static BST ComputeBalBST(List<int> arr, BST bst, int startIndx, int endIndx)
//        {
//            if (startIndx < endIndx)
//                return null;

//            int midIndx = (startIndx+endIndx) / 2;
//            int midVal = arr[midIndx];

//            if(bst == null)
//            {
//                bst = new BST(midVal);
//            }
//            else
//            {
//                bst.insert(midVal);
//            }

//            ComputeBalBST(arr, bst, startIndx, midIndx - 1);
//            ComputeBalBST(arr, bst, midIndx + 1, endIndx);

//            return bst;

//        }

//        static void Main(string[] args)
//        {
//            int[] sortedArr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
//        }
//    }

    
//}
