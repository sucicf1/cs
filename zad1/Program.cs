using System;
using System.Collections.Generic;
using System.Linq;

namespace zad1
{
    class Node
    {
        public int Data { get; set; }
        public Node Parent { get; set; }
        List<Node> Childs = new List<Node>();

        public Node(int data, Node parent)
        {
            Data = data;
            Parent = parent;
        }

        public Node(string[] args)
        {
            var lookup = new Dictionary<int, Node>();

            for (int i = 0; i < args.Length; ++i)
            {
                Node parentNode;
                Node node;

                if (!lookup.TryGetValue(i, out node))
                {
                    node = new Node(i, null);
                    lookup.Add(i, node);
                }
                if (Int32.Parse(args[i]) == -1)
                {
                    parentNode = null;
                    Data = node.Data;
                    Childs = node.Childs;
                }
                else if (!lookup.TryGetValue(Int32.Parse(args[i]), out parentNode))
                {
                    parentNode = new Node(Int32.Parse(args[i]), null);
                    lookup.Add(Int32.Parse(args[i]), parentNode);
                }
                node.Parent = parentNode;
                if (parentNode != null)
                    parentNode.AddChild(node);
            }
        }

        public void AddChild(Node child)
        {
            Childs.Add(child);
        }

        public int GetNumberLeafs()
        {
            int numberLeafs = 0;
            if (Childs == null || Childs.Count() == 0) return 1;
            else
            {
                foreach (Node child in Childs)
                {
                    numberLeafs += child.GetNumberLeafs();
                }
                return numberLeafs;
            }
        }

        public int GetHeight()
        {
            if (Childs == null || Childs.Count == 0) return 0;
            else
            {
                int height = 0;
                foreach (Node child in Childs)
                {
                    int childHeight;
                    childHeight = child.GetHeight();
                    if (childHeight > height) height = childHeight;
                }
                return height + 1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(args);
            Console.WriteLine(tree.GetHeight());
            Console.WriteLine(tree.GetNumberLeafs());
        }
    }
}
