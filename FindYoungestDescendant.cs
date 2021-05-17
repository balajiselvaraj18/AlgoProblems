//using System;

//public class Program
//{
//    public static AncestralTree GetYoungestCommonAncestor(
//        AncestralTree topAncestor,
//        AncestralTree descendantOne,
//        AncestralTree descendantTwo
//        )
//    {
//        // Write your code here.

//        int depthOne = GetDepthOftheNode(descendantOne, topAncestor);
//        int depthTwo = GetDepthOftheNode(descendantTwo, topAncestor);

//        if (depthOne > depthTwo)
//        {
//            return reverseTrack(descendantOne, descendantTwo, depthOne - depthTwo);
//        }
//        else
//        {
//            return reverseTrack(descendantTwo, descendantOne, depthOne - depthTwo);
//        }

//        return topAncestor;
//    }

//    public static AncestralTree reverseTrack(AncestralTree lowerAncesteralNode, AncestralTree higherAncestoralNode, int diff)
//    {
//        while(diff > 0)
//        {
//            diff--;
//            lowerAncesteralNode = lowerAncesteralNode.ancestor;
//        }

//        while (lowerAncesteralNode != higherAncestoralNode)
//        {
//            lowerAncesteralNode = lowerAncesteralNode.ancestor;
//            higherAncestoralNode = higherAncestoralNode.ancestor;
//        }

//        return lowerAncesteralNode;
//    }

//    public static int GetDepthOftheNode(AncestralTree descendent, AncestralTree topAncestor)
//    {
//        int depth = 0;
//        while (descendent != topAncestor)
//        {
//            depth++;
//            descendent = descendent.ancestor;
//        }

//        return depth;
//    }

//    public class AncestralTree
//    {
//        public char name;
//        public AncestralTree ancestor;

//        public AncestralTree(char name)
//        {
//            this.name = name;
//            this.ancestor = null;
//        }

//        // This method is for testing only.
//        public void AddAsAncestor(AncestralTree[] descendants)
//        {
//            foreach (AncestralTree descendant in descendants)
//            {
//                descendant.ancestor = this;
//            }
//        }
//    }
//}
