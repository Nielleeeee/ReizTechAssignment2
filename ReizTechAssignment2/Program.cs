using System;
using System.Collections.Generic;

namespace ReizTechAssignment2
{
    internal class Branch
    {
        static void Main(string[] args)
        {
            // Create the root node
            Node root = new Node("Root");

            // Add some child nodes
            Node child1 = new Node("Child 1");
            root.AddChild(child1);
            Node child2 = new Node("Child 2");
            root.AddChild(child2);
            Node child3 = new Node("Child 3");
            root.AddChild(child3);

            // Add some child nodes to child1
            Node grandchild1 = new Node("Grandchild 1");
            child1.AddChild(grandchild1);
            Node grandchild2 = new Node("Grandchild 2");
            child1.AddChild(grandchild2);

            // Traverse the tree
            root.Traverse();
        }
    }
    class Node
    {
        public string Name { get; set; }
        public List<Node> Children { get; set; }

        public Node(string name)
        {
            Name = name;
            Children = new List<Node>();
        }

        public void AddChild(Node child)
        {
            Children.Add(child);
        }

        public void Traverse()
        {
            Console.WriteLine(Name);
            foreach (Node child in Children)
            {
                child.Traverse();
            }
        }
    }
}