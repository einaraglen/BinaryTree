using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree {

    /*
     * Idea is that we create a tree with branches, every node can either have a
     * leftChild or a rightChild, every node has a key value. If child has lower key value 
     * then it becomes the leftChild of the parent, otherwise it is the rightChild.
    */

    class BinaryTree {

        private Node root;

        public void AddNode(int key) {
            Node newNode = new Node(key);

            //if root has not been set, set fisrt created node as root
            if (root == null) {
                root = newNode;
            }

            else {
                Node focusNode = root;
                Node parent;

                while (true) {
                    parent = focusNode;

                    //smaller key value than parent = left
                    if (key < focusNode.Key) {
                        focusNode = focusNode.LeftChild;

                        if(focusNode == null) {
                            parent.LeftChild = newNode;
                            break;
                        }

                    } 
                    
                    //higher key value than parent = right
                    else {
                        focusNode = focusNode.RightChild;

                        if (focusNode == null) {
                            parent.RightChild = newNode;
                            break;
                        }

                    }

                }

            }
        }

        public void Remove(int key) {
            root = RemoveRecursive(root, key);
        }

        private Node RemoveRecursive(Node root, int key) {
            if (root == null) {
                return root;
            }
            //find node and get us back out of recursion
            if (key < root.Key) {
                Console.Write("find " + key + " and ");
                root.LeftChild = RemoveRecursive(root.LeftChild, key);
            }
            else if (key > root.Key) {
                Console.Write("find " + key + " and ");
                root.RightChild = RemoveRecursive(root.RightChild, key);
            }
            //handle node
            else {
                //handle single childer or no childern
                if (root.LeftChild == null) {
                    Console.WriteLine("set to " + root.RightChild.Key);
                    return root.RightChild;
                }
                else if (root.RightChild == null) {
                    Console.WriteLine("set to " + root.LeftChild.Key);
                    return root.LeftChild;
                }

                //handle two childern
                int temp = root.Key;

                root.Key = MinKey(root.RightChild);
                Console.WriteLine("Replace " + temp + " with " + root.Key + " in sub of " + root.RightChild.Key);
                root.RightChild = RemoveRecursive(root.RightChild, root.Key);
            }
            //Console.WriteLine(root.Key);
            return root;
        }

        public int MinKey(Node focus) {
            int min = focus.Key;
            while (focus.LeftChild != null) {
                min = focus.LeftChild.Key;
                focus = focus.LeftChild;
            }

            return min;
        }

        //In Order Traversal of the tree will return the values of the tree
        //In increasing values
        public void InOrderTraverseTree(Node focusNode) {
            if (focusNode != null) {
                InOrderTraverseTree(focusNode.LeftChild);
                
                Console.WriteLine(focusNode.Key);

                InOrderTraverseTree(focusNode.RightChild);
            }
        }

        //Preorder Traversal will return all the nodes left and right of the left side of the tree
        //Then do the same on the right side of the tree from the focus node
        public void PreorderTraverseTree(Node focusNode) {
            if (focusNode != null) {
                Console.WriteLine(focusNode.Key);
                PreorderTraverseTree(focusNode.LeftChild);

                PreorderTraverseTree(focusNode.RightChild);
            }
        }

        public Node Get(int key) {
            Node focusNode = root;
            
            while (focusNode.Key != key) {

                if (key < focusNode.Key) {
                    focusNode = focusNode.LeftChild;
                }

                else {
                    focusNode = focusNode.RightChild;
                }

                if (focusNode == null) {
                    return null;
                }

            }
            
            return focusNode;
        }

        public Node Root {
            get { return this.root; }
            set { this.root = value; }
        }

    }
}
