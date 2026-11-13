using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarulengMunicipalityApplication
{
    public class ServiceRequestAVLTree
    {
        private class Node
        {
            public Issue Data;
            public Node Left;
            public Node Right;
            public int Height;

            public Node(Issue issue)
            {
                Data = issue;
                Height = 1;
            }
        }

        private Node root;

        // Get the height of a node
        private int GetHeight(Node node)
        {
            return node == null ? 0 : node.Height;
        }

        // Calculate balance factor
        private int GetBalance(Node node)
        {
            return node == null ? 0 :
                GetHeight(node.Left) - GetHeight(node.Right);
        }

        // Update node height
        private void UpdateHeight(Node node)
        {
            node.Height = 1 +
                System.Math.Max(
                    GetHeight(node.Left),
                    GetHeight(node.Right));
        }

        // Right rotation
        private Node RightRotate(Node y)
        {
            Node x = y.Left;
            Node temp = x.Right;

            x.Right = y;
            y.Left = temp;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        // Left rotation
        private Node LeftRotate(Node x)
        {
            Node y = x.Right;
            Node temp = y.Left;

            y.Left = x;
            x.Right = temp;

            UpdateHeight(x);
            UpdateHeight(y);

            return y;
        }

        // Insert a service request
        public void Insert(Issue issue)
        {
            if (issue == null)
                return;

            root = InsertNode(root, issue);
        }

        private Node InsertNode(Node node, Issue issue)
        {
            if (node == null)
                return new Node(issue);

            if (issue.Id < node.Data.Id)
                node.Left = InsertNode(node.Left, issue);

            else if (issue.Id > node.Data.Id)
                node.Right = InsertNode(node.Right, issue);

            else
                return node;

            UpdateHeight(node);

            int balance = GetBalance(node);

            // Left Left case
            if (balance > 1 &&
                issue.Id < node.Left.Data.Id)
                return RightRotate(node);

            // Right Right case
            if (balance < -1 &&
                issue.Id > node.Right.Data.Id)
                return LeftRotate(node);

            // Left Right case
            if (balance > 1 &&
                issue.Id > node.Left.Data.Id)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left case
            if (balance < -1 &&
                issue.Id < node.Right.Data.Id)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        // Search using request ID
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