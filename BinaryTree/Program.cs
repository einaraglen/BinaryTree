using System;

namespace BinaryTree {
    class Program {
        static void Main(string[] args) {
            BinaryTree tree = new BinaryTree();

            tree.AddNode(5);
            
            tree.AddNode(2);
            tree.AddNode(12);
           
            tree.AddNode(1);
            tree.AddNode(3);
            tree.AddNode(9);
            tree.AddNode(21);
           
            //tree.AddNode(19);
            tree.AddNode(25);


            //tree.PreorderTraverseTree(tree.Root);

            //tree.Remove(12);
            tree.Remove(21);


            //tree.PreorderTraverseTree(tree.Root);

            Console.ReadLine();
        }
    }
}
