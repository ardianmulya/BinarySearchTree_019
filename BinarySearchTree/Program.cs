using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public string info;
        public Node lchild;
        public Node rchild;

        public Node(string i, Node l, Node r)
        {
            info = i;
            lchild = l;
            rchild = r;

        }
    }
    class BinaryTree
    {
        public Node root;
        
        public BinaryTree()
        {
            root = null;
        }

        public void insert (string element)
        {
            Node tmp, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if (currentnode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    root = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if ( string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
                else
                {
                    parent.rchild = tmp;
                }
            }
        }
        public void find(string element,ref Node parent,ref Node currentnode)
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
