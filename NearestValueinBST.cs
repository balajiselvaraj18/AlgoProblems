//using System;

//public class Program
//{
//    public static int FindClosestValueInBst(BST tree, int target)
//    {
//        // Write your code here.
//        return FindClosestValueInBst(tree, target, tree.value);
//    }

//    public static int FindClosestValueInBst(BST tree, int target, int nearest_value_To_Target)
//    {
//        // Write your code here.

//        if (Math.Abs(target - nearest_value_To_Target) > Math.Abs(target - tree.value))
//        {
//            nearest_value_To_Target = tree.value;
//        }

//        if (target < nearest_value_To_Target && tree.left != null)
//        {

//            return FindClosestValueInBst(tree.left, target, tree.value);
//        }
//        else if (target < nearest_value_To_Target && tree.left != null)
//        {

//            return FindClosestValueInBst(tree.right, target, tree.value);
//        }
//        else
//        {
//            return nearest_value_To_Target;
//        }
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
//}
