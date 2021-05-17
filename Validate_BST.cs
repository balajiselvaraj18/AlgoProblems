//using System;

//public class Program
//{
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
//    public static bool ValidateBst(BST tree)
//    {
//        // Write your code here.
//        return helperToValidateBST(tree, Int32.MinValue, Int32.MaxValue);
//    }

//    public static bool helperToValidateBST(BST tree, int minVal, int maxVal)
//    {
//        if (tree.value < minVal || tree.value >= maxVal)
//        {
//            return false;
//        }
//        if (tree.left != null && helperToValidateBST(tree.left, minVal, tree.value) == false)
//        {
//            return false;
//        }
//        if (tree.right != null && helperToValidateBST(tree.right, tree.value, maxVal) == false)
//        {
//            return false;
//        }
//        return true;
//    }



//    static void Main(string[] args)
//    {
//        var root = new Program.BST(10);
//        root.left = new Program.BST(5);
//        root.left.left = new Program.BST(2);
//        root.left.left.left = new Program.BST(1);
//        root.left.right = new Program.BST(5);
//        root.right = new Program.BST(15);
//        root.right.left = new Program.BST(13);
//        root.right.left.right = new Program.BST(14);
//        root.right.right = new Program.BST(22);

//        ValidateBst(root);
//    }

//}
