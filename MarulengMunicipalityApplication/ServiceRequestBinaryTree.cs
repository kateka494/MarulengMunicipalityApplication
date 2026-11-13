using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarulengMunicipalityApplication
{
    public class ServiceRequestBinaryTree
    {
        private class Node
        {
            public Issue Data;
            public Node Left;
            public Node Right;

            public Node(Issue issue)
            {
                Data = issue;
                Left = null;
                Right = null;
            }
        }

        private Node root;

        public ServiceRequestBinaryTree()
        {
            root = null;
        }

        // Inserts requests level by level
        public void Insert(Issue issue)
        {
            if (issue == null)
                return;

            Node newNode = new Node(issue);

            if (root == null)
            {
                root = newNode;
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();

                if (current.Left == null)
                {
                    current.Left = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right == null)
                {
                    current.Right = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        // Searches the tree using level-order traversal
        public Issue Search(int id)
        {
            if (root == null)
                return null;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();

                if (current.Data.Id == id)
                    return current.Data;

                if (current.Left != null)
                    queue.Enqueue(current.Left);

                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }

            return null;
        }

        // Returns requests in level-order
        public List<Issue> GetLevelOrder()
        {
            List<Issue> results = new List<Issue>();

            if (root == null)
                return results;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                results.Add(current.Data);

                if (current.Left != null)
                    queue.Enqueue(current.Left);

                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }

            return results;
        }
    }
}
