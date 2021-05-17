//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IntPractProb
//{
//    class MaxHeightandIDiameter
//    {
//        public class BinaryTree
//        {
//            public int value;
//            public BinaryTree left;
//            public BinaryTree right;

//            public BinaryTree(int val)
//            {
//                this.value = val;
//            }
//        }

//        public int BinarytreeDepth(BinaryTree tree)
//        {
//            return GetDepthOfBST(tree).diameter;
//        }

//        public BTDepthDiamter GetDepthOfBST(BinaryTree tree) {


//            BTDepthDiamter leftTree = GetDepthOfBST(tree.left);
//            BTDepthDiamter rigtTree = GetDepthOfBST(tree.right);

//            int SizeOf_BSTdepth = leftTree.depth + rigtTree.depth;
//            int SizeodDiam = Math.Max(leftTree.diameter, rigtTree.diameter);

//            int Diam = Math.Max(SizeOf_BSTdepth, SizeodDiam);
//            int Depth = 1 + Math.Max(leftTree.depth , rigtTree.depth);

//            return new BTDepthDiamter(Diam, Depth);

            

//        }

//        public class BTDepthDiamter
//        {
//            public int diameter;
//            public int depth;

//           public BTDepthDiamter(int dia, int dep)
//            {
//                this.diameter = dia;
//                this.depth = dep;
//            }

//        }


//    }




//}
