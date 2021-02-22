using System;
using System.Collections.Generic;

namespace Assignment_2__Tree_
{
    class Program
    {
        public class Node
        {
            public int label;
            public List<Node> children;
        }

        static Node createNewNode(int label)
        {
            Node newNode = new Node();
            newNode.label = label;
            newNode.children = new List<Node>();

            return newNode;
        }

        static int depthofTree(Node currentNode)
        {
            if (currentNode == null)
            {
                return 0;
            }

            int maxDepth = 0;
            foreach (Node i in currentNode.children)
                maxDepth = Math.Max(maxDepth, depthofTree(i));

            return maxDepth + 1;
        }

        static void Main(string[] args)
        {
            Node root = createNewNode(1);
            root.children.Add(createNewNode(2));
            root.children.Add(createNewNode(3));

            root.children[0].children.Add(createNewNode(4));

            root.children[1].children.Add(createNewNode(5));
            root.children[1].children.Add(createNewNode(6));
            root.children[1].children.Add(createNewNode(7));

            root.children[1].children[0].children.Add(createNewNode(8));

            root.children[1].children[1].children.Add(createNewNode(9));
            root.children[1].children[1].children.Add(createNewNode(10));

            root.children[1].children[1].children[0].children.Add(createNewNode(11));

            Console.WriteLine("Depth of the tree is:" + depthofTree(root));
        }
    }
}
