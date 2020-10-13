using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree {
    /*
     * The node class is the the information storage class in the BinaryTree program
     * It stores a name and a key for each node, it also contains up to 2 children. 
     * These are called leftChild and rightChild, left is always lower than parent node
     * and right is always higher.
    */ 
    class Node {

        private int key;
        private int height;
        private string name;
        private Node leftChild;
        private Node rightChild;

        public Node(int key) {
            this.key = key;
            this.height = 0;
            this.name = "";
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Height {
            get { return this.height; }
            set { this.height = value; }
        }

        public int Key {
            get { return this.key; }
            set { this.key = value; }
        }

        public Node LeftChild {
            get { return this.leftChild; }
            set { this.leftChild = value; }
        }

        public Node RightChild {
            get { return this.rightChild; }
            set { this.rightChild = value; }
        }
    }
}
