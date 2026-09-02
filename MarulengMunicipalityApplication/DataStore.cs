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

     
        public static Queue<int> ProcessingQueue = new Queue<int>();

  
        public static Dictionary<int, Issue> IssueDictionary = new Dictionary<int, Issue>();


        private static int _nextId = 1;

    
        public static void AddIssue(Issue issue)
        {
            issue.Id = _nextId++;
            Issues.Add(issue);
            ProcessingQueue.Enqueue(issue.Id);
            IssueDictionary[issue.Id] = issue;
        }

    
        public static Issue GetIssueById(int id)
        {
            return IssueDictionary.ContainsKey(id) ? IssueDictionary[id] : null;
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
                issue.Status = newStatus;
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