using System;
using System.Collections.Generic;

namespace BranchExample
{
    class Branch
    {
        List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }

        // Function to add branch
        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }

        //Function to print the branches
        public void Print(int depth = 0)
        {
            Console.WriteLine(new string('-', depth) + " " + "Branch");
            foreach (var branch in branches)
            {
                branch.Print(depth + 1);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a root branch, Depth 1
            Branch root = new Branch();

            // Depth 2
            Branch child1 = new Branch();
            Branch child2 = new Branch();
            root.AddBranch(child1);
            root.AddBranch(child2);

            // Depth 3
            Branch grandChild1 = new Branch();
            Branch grandChild2 = new Branch();
            Branch grandChild3 = new Branch();
            Branch grandChild4 = new Branch();
            child1.AddBranch(grandChild1);
            child2.AddBranch(grandChild2);
            child2.AddBranch(grandChild3);
            child2.AddBranch(grandChild4);

            // Depth 4
            Branch greatGrandChild1 = new Branch();
            Branch greatGrandChild2 = new Branch();
            Branch greatGrandChild3 = new Branch();
            grandChild2.AddBranch(greatGrandChild1);
            grandChild3.AddBranch(greatGrandChild2);
            grandChild3.AddBranch(greatGrandChild3);

            // Depth 5
            Branch greatGreatGrandChild1 = new Branch();
            greatGrandChild2.AddBranch(greatGreatGrandChild1);


            root.Print();
        }
    }
}