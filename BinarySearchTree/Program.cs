﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        class Node
        {
            public string info;
            public Node lchild;
            public Node rchild;

            public Node (string i, Node l, Node r)
            {
                info = i;
                lchild = l;
                rchild = r;

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
