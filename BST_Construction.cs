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

//        public BST Insert(int value)
//        {
//            // Write your code here.
//            // Do not edit the return statement of this method.
//            BST node = this;
//            while (true)
//            {
//                if (value < node.value)
//                {
//                    if (node.left == null)
//                    {
//                        BST ValueForNode = new BST(value);
//                        node.left = ValueForNode;
//                        break;
//                    }
//                    else
//                    {
//                        node = node.left;
//                    }
//                }
//                else
//                {
//                    if (node.right == null)
//                    {
//                        BST ValueForNode = new BST(value);
//                        node.right = ValueForNode;
//                        break;
//                    }
//                    else
//                    {
//                        node = node.right;
//                    }
//                }
//            }
//            return this;
//        }

//        public bool Contains(int value)
//        {
//            // Write your code here.
//            BST node = this;
//            while (node != null)
//            {
//                if (value < node.value)
//                {
//                    if (node.value == value)
//                    {
//                        return true;
//                    }
//                    else
//                    {
//                        node = node.left;
//                    }

//                }
//                else if (value > node.value)
//                {
//                    if (node.value == value)
//                    {
//                        return true;

//                    }
//                    else
//                    {
//                        node = node.right;
//                    }
//                }
//                else if (value == node.value)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        public BST Remove(int value)
//        {
//            // Write your code here.
//            // Do not edit the return statement of this method.

//            Remove(value, null);

//            return this;
//        }

//        public void Remove(int value, BST parentNode)
//        {
//            BST currentNode = this;
//            while (currentNode != null)
//            {
//                if (value < currentNode.value)
//                {
//                    parentNode = currentNode;
//                    currentNode = currentNode.left;
//                }
//                else if (value > currentNode.value)
//                {
//                    parentNode = currentNode;
//                    currentNode = currentNode.right;
//                }
//                else
//                {
//                    if (currentNode.left != null && currentNode.right != null)
//                    {
//                        currentNode.value = currentNode.right.getMinValue();
//                        currentNode.right.Remove(currentNode.value, currentNode);
//                    }
//                    else if (parentNode == null)
//                    {
//                        if (currentNode.left != null)
//                        {
//                            currentNode.value = currentNode.left.value;
//                            currentNode.right = currentNode.left.right;
//                            currentNode.left = currentNode.left.left;
//                        }
//                        else if (currentNode.right != null)
//                        {
//                            currentNode.value = currentNode.right.value;
//                            currentNode.right = currentNode.right.right;
//                            currentNode.left = currentNode.right.left;
//                        }
//                        else { }
//                    }
//                    else if (parentNode.left == currentNode)
//                    {
//                        parentNode.left = currentNode.left != null ? currentNode.left : currentNode.right;
//                    }
//                    else if (parentNode.right == currentNode)
//                    {
//                        parentNode.right = currentNode.right != null ? currentNode.left : currentNode.right;
//                    }
//                    break;
//                }
//            }
//        }

//        public int getMinValue()
//        {
//            if (left == null)
//            {
//                return value;
//            }
//            else
//            {
//                return left.getMinValue();
//            }
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
//        root.right.left = new Program.BST(13);
//        root.right.left.right = new Program.BST(14);
//        root.right.right = new Program.BST(22);



//        root.Insert(2);
//        root.Insert(3);
//        root.Insert(4);

//        root.Remove(1);
//    }
//}
