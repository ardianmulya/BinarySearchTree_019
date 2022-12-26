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
        public Node ROOT;
        
        public BinaryTree()
        {
            ROOT = null;
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
            currentnode = ROOT;
            parent = null;
            while((currentnode != null) && (currentnode.info != element))
            {
                parent= currentnode;
                if (string.Compare(element,currentnode.info)<0)
                    currentnode = currentnode.lchild;
                else
                    currentnode = currentnode.rchild;
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is Empty");
                return ;
            }
            if (ptr != null)
            {
                inorder(ptr.lchild);
                Console.WriteLine(ptr.info + " ");
                inorder(ptr.rchild);
            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is Empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                inorder(ptr.lchild);
                inorder(ptr.rchild);
            }
        }
        public void postorder(Node ptr)
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
