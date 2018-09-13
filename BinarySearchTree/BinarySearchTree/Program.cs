using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.AddNode(50);
            bst.AddNode(100);
            bst.AddNode(40);
            bst.AddNode(45);
            bst.AddNode(60);
            bst.AddNode(10);
            bst.AddNode(30);
            bst.AddNode(15);

            bst.SearchBST();
        }
    }
}
