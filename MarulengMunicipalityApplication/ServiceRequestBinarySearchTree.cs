using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MarulengMunicipalityApplication
{
    public class ServiceRequestBinarySearchTree
    {
        // Represents a node in the tree
        private class Node
        {
            public Issue Data;
            public Node Left;
            public Node Right;

            public Node(Issue issue)
            {
                Data = issue;
            }
        }

        private Node root;

        // Insert a service request
        public void Insert(Issue issue)
        {
            if (issue == null)
                return;

            root = InsertNode(root, issue);
        }

        private Node InsertNode(Node current, Issue issue)
        {
            if (current == null)
                return new Node(issue);

            if (issue.Id < current.Data.Id)
                current.Left = InsertNode(current.Left, issue);

            else if (issue.Id > current.Data.Id)
                current.Right = InsertNode(current.Right, issue);

            return current;
        }

        // Search for a request using its ID
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

        // Retrieve requests in ascending ID order
        public List<Issue> GetInOrder()
        {
            List<Issue> results = new List<Issue>();

            InOrderTraversal(root, results);

            return results;
        }

        private void InOrderTraversal(
            Node current, List<Issue> results)
        {
            if (current == null)
                return;

            InOrderTraversal(current.Left, results);

            results.Add(current.Data);

            InOrderTraversal(current.Right, results);
        }
    }
}
