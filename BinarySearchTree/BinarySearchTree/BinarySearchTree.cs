using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void AddNode(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }

            else
            {
                Node currentNode = root;

                while (currentNode.data != value)
                {
                    if (value < currentNode.data)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = new Node(value);
                            currentNode = currentNode.left;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = new Node(value);
                            currentNode = currentNode.right;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            }
        }

        public void SearchBST()
        {
            Console.WriteLine("Enter the value you would like to find");
            int searchValue = int.Parse(Console.ReadLine());

            if (searchValue == root.data)
            {
                Console.WriteLine(root.data);
            }
            else
            {
                Node currentNode = root;

                while (currentNode.data != searchValue)
                {
                    if (searchValue < currentNode.data)
                    {
                        currentNode = currentNode.left;

                        if (currentNode == null)
                        {
                            Console.WriteLine("value not found");
                            break;
                        }
                        else if (searchValue == currentNode.data && currentNode != null)
                        {
                            Console.WriteLine(currentNode.data);
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;

                        if (currentNode == null)
                        {
                            Console.WriteLine("value not found");
                            break;
                        }
                        else if (searchValue == currentNode.data)
                        {
                            Console.WriteLine(currentNode.data);
                        }
                  
                    }
                }
            }
        }
    }
}
