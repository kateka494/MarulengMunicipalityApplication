
using System.Collections.Generic;

namespace MarulengMunicipalityApplication
{
    public class ServiceRequestRedBlackTree
    {
        private enum Colour
        {
            Red,
            Black
        }

        private class Node
        {
            public Issue Data;
            public Node Left;
            public Node Right;
            public Node Parent;
            public Colour NodeColour;

            public Node(Issue issue)
            {
                Data = issue;
                NodeColour = Colour.Red;
            }
        }

        private Node root;

        // Insert a service request
        public void Insert(Issue issue)
        {
            if (issue == null)
                return;

            Node newNode = new Node(issue);
            Node parent = null;
            Node current = root;

            while (current != null)
            {
                parent = current;

                if (issue.Id < current.Data.Id)
                    current = current.Left;
                else if (issue.Id > current.Data.Id)
                    current = current.Right;
                else
                    return;
            }

            newNode.Parent = parent;

            if (parent == null)
                root = newNode;
            else if (issue.Id < parent.Data.Id)
                parent.Left = newNode;
            else
                parent.Right = newNode;

            FixInsert(newNode);
        }

        private void FixInsert(Node node)
        {
            while (node != root &&
                   node.Parent.NodeColour == Colour.Red)
            {
                Node parent = node.Parent;
                Node grandparent = parent.Parent;

                if (parent == grandparent.Left)
                {
                    Node uncle = grandparent.Right;

                    if (uncle != null &&
                        uncle.NodeColour == Colour.Red)
                    {
                        parent.NodeColour = Colour.Black;
                        uncle.NodeColour = Colour.Black;
                        grandparent.NodeColour = Colour.Red;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Right)
                        {
                            node = parent;
                            LeftRotate(node);
                            parent = node.Parent;
                            grandparent = parent.Parent;
                        }

                        parent.NodeColour = Colour.Black;
                        grandparent.NodeColour = Colour.Red;
                        RightRotate(grandparent);
                    }
                }
                else
                {
                    Node uncle = grandparent.Left;

                    if (uncle != null &&
                        uncle.NodeColour == Colour.Red)
                    {
                        parent.NodeColour = Colour.Black;
                        uncle.NodeColour = Colour.Black;
                        grandparent.NodeColour = Colour.Red;
                        node = grandparent;
                    }
                    else
                    {
                        if (node == parent.Left)
                        {
                            node = parent;
                            RightRotate(node);
                            parent = node.Parent;
                            grandparent = parent.Parent;
                        }

                        parent.NodeColour = Colour.Black;
                        grandparent.NodeColour = Colour.Red;
                        LeftRotate(grandparent);
                    }
                }
            }

            root.NodeColour = Colour.Black;
        }

        private void LeftRotate(Node node)
        {
            Node pivot = node.Right;

            node.Right = pivot.Left;

            if (pivot.Left != null)
                pivot.Left.Parent = node;

            pivot.Parent = node.Parent;

            if (node.Parent == null)
                root = pivot;
            else if (node == node.Parent.Left)
                node.Parent.Left = pivot;
            else
                node.Parent.Right = pivot;

            pivot.Left = node;
            node.Parent = pivot;
        }

        private void RightRotate(Node node)
        {
            Node pivot = node.Left;

            node.Left = pivot.Right;

            if (pivot.Right != null)
                pivot.Right.Parent = node;

            pivot.Parent = node.Parent;

            if (node.Parent == null)
                root = pivot;
            else if (node == node.Parent.Right)
                node.Parent.Right = pivot;
            else
                node.Parent.Left = pivot;

            pivot.Right = node;
            node.Parent = pivot;
        }

        // Search for a request by ID
        public Issue Search(int id)
        {
            Node current = root;

            while (current != null)
            {
                if (id == current.Data.Id)
                    return current.Data;

                if (id < current.Data.Id)
                    current = current.Left;
                else
                    current = current.Right;
            }

            return null;
        }

        // Return requests in ascending ID order
        public List<Issue> GetInOrder()
        {
            List<Issue> results = new List<Issue>();
            InOrderTraversal(root, results);
            return results;
        }

        private void InOrderTraversal(
            Node node, List<Issue> results)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left, results);
            results.Add(node.Data);
            InOrderTraversal(node.Right, results);
        }
    }
}
