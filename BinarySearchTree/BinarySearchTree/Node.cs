using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            data = value;
            right = null;
            left = null;
        }




        public void DisplayNode()
        {
            Console.Write(data);
        }
    }
}
