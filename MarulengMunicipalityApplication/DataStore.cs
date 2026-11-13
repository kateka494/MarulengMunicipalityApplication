using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarulengMunicipalityApplication
{
    public static class DataStore
    {
      
        public static List<Issue> Issues = new List<Issue>();

        public static ServiceRequestBinarySearchTree IssueSearchTree =
            new ServiceRequestBinarySearchTree();

        // AVL Tree for balanced service request searching
        public static ServiceRequestAVLTree IssueAVLTree =
            new ServiceRequestAVLTree();

        public static ServiceRequestRedBlackTree IssueRedBlackTree =
    new ServiceRequestRedBlackTree();

        public static ServiceRequestBinaryTree IssueBinaryTree =
    new ServiceRequestBinaryTree();

        public static ServiceRequestPriorityQueue IssuePriorityQueue =
    new ServiceRequestPriorityQueue();

        public static MunicipalServiceGraph ServiceGraph =
    new MunicipalServiceGraph();

        public static List<string> Notifications = new List<string>();


        public static Queue<int> ProcessingQueue = new Queue<int>();

  
        public static Dictionary<int, Issue> IssueDictionary = new Dictionary<int, Issue>();


        private static int _nextId = 1;


        public static void AddIssue(Issue issue)
        {
            if (issue == null)
                return;

            
            issue.Id = _nextId++;

            // Store the request in the existing collections
            Issues.Add(issue);
            ProcessingQueue.Enqueue(issue.Id);
            IssueDictionary[issue.Id] = issue;

            // Insert the request into the Binary Search Tree
            IssueSearchTree.Insert(issue);
            // Insert the request into the AVL Tree
            IssueAVLTree.Insert(issue);

            IssueRedBlackTree.Insert(issue);

            IssueBinaryTree.Insert(issue);

            IssuePriorityQueue.Enqueue(issue);
        }

        public static void InitialiseServiceGraph()
        {
            ServiceGraph = new MunicipalServiceGraph();

            ServiceGraph.AddEdge("Maruleng", "Hoedspruit", 10);
            ServiceGraph.AddEdge("Hoedspruit", "Mica", 15);
            ServiceGraph.AddEdge("Mica", "Ofcolaco", 20);
            ServiceGraph.AddEdge("Maruleng", "Ofcolaco", 25);
            ServiceGraph.AddEdge("Hoedspruit", "Burgersfort", 30);
        }


        // Retrieve a service request using the Binary Search Tree
        public static Issue GetIssueById(int id)
        {
            return IssueSearchTree.Search(id);
        }

        // Search for a service request using the Binary Search Tree
        public static Issue SearchIssueTree(int id)
        {
            return IssueSearchTree.Search(id);
        }

        public static Issue SearchIssueRedBlack(int id)
        {
            return IssueRedBlackTree.Search(id);
        }

        // Search for a service request using the AVL Tree
        public static Issue SearchIssueAVL(int id)
        {
            return IssueAVLTree.Search(id);
        }

        public static Issue SearchIssueBinaryTree(int id)
        {
            return IssueBinaryTree.Search(id);
        }

        public static Issue GetHighestPriorityIssue()
        {
            return IssuePriorityQueue.Peek();
        }
        public static List<Issue> GetPendingIssues()
        {
            return Issues.FindAll(i => i.Status == "Pending");
        }

        public static List<Issue> GetIssuesByCategory(string category)
        {
            return Issues.FindAll(i => i.Category == category);
        }


        public static void UpdateStatus(int id, string newStatus)
        {
            Issue issue = GetIssueById(id);

            if (issue != null)
            {
                // Update the request status
                issue.Status = newStatus;

                
                string historyEntry = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
                    + " - Status changed to: " + newStatus;

                issue.StatusHistory.Add(historyEntry);

                // Create a notification for the requester
                string notification = "Request #" + issue.Id
                    + " status updated to: " + newStatus
                    + " (" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ")";

                Notifications.Add(notification);
            }
        }


        public static int GetTotalCount()
        {
            return Issues.Count;
        }

      
        public static string GetReportSummary()
        {
            int pending = Issues.FindAll(i => i.Status == "Pending").Count;
            int inProgress = Issues.FindAll(i => i.Status == "In Progress").Count;
            int resolved = Issues.FindAll(i => i.Status == "Resolved").Count;

            return $"Total: {Issues.Count} | Pending: {pending} | In Progress: {inProgress} | Resolved: {resolved}";
        }

   
        public static Issue GetNextIssueToProcess()
        {
            if (ProcessingQueue.Count == 0)
                return null;

            int id = ProcessingQueue.Dequeue();
            return GetIssueById(id);
        }
    }
}