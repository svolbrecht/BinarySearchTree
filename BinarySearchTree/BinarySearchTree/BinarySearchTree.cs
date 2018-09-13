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

                            if (currentNode.left == null)
                            {
                                currentNode.left = new Node(value);
                            }
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

                            if (currentNode.right == null)
                            {
                                currentNode.right = new Node(value);
                            }
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
                        if (searchValue == currentNode.left.data)
                        {
                            Console.WriteLine(currentNode.left.data);
                        }

                        else
                        {
                            currentNode = currentNode.left;
                        }

                    }
                    else
                    {
                        if (searchValue == currentNode.right.data)
                        {
                            Console.WriteLine(currentNode.right.data);
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            }
        }
    }
}
