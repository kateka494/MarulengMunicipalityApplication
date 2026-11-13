using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarulengMunicipalityApplication
{
    public class ServiceRequestPriorityQueue
    {
        private List<Issue> heap;

        public ServiceRequestPriorityQueue()
        {
            heap = new List<Issue>();
        }

        // Converts priority names into numeric values
        private int GetPriorityValue(Issue issue)
        {
            if (issue.Priority == null)
                return 1;

            string priority = issue.Priority.ToLower();

            if (priority == "high")
                return 3;

            if (priority == "medium")
                return 2;

            return 1;
        }

        // Adds a request to the heap
        public void Enqueue(Issue issue)
        {
            if (issue == null)
                return;

            heap.Add(issue);
            HeapifyUp(heap.Count - 1);
        }

        // Moves a newly added request into the correct position
        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;

                if (GetPriorityValue(heap[index]) <=
                    GetPriorityValue(heap[parent]))
                    break;

                Swap(index, parent);
                index = parent;
            }
        }

        // Returns the highest-priority request without removing it
        public Issue Peek()
        {
            if (heap.Count == 0)
                return null;

            return heap[0];
        }

        // Removes and returns the highest-priority request
        public Issue Dequeue()
        {
            if (heap.Count == 0)
                return null;

            Issue highestPriority = heap[0];

            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            if (heap.Count > 0)
                HeapifyDown(0);

            return highestPriority;
        }

        // Restores the heap after removing an item
        private void HeapifyDown(int index)
        {
            int largest = index;

            while (true)
            {
                int left = (2 * index) + 1;
                int right = (2 * index) + 2;

                if (left < heap.Count &&
                    GetPriorityValue(heap[left]) >
                    GetPriorityValue(heap[largest]))
                {
                    largest = left;
                }

                if (right < heap.Count &&
                    GetPriorityValue(heap[right]) >
                    GetPriorityValue(heap[largest]))
                {
                    largest = right;
                }

                if (largest == index)
                    break;

                Swap(index, largest);
                index = largest;
            }
        }

        private void Swap(int first, int second)
        {
            Issue temporary = heap[first];
            heap[first] = heap[second];
            heap[second] = temporary;
        }

        public int Count
        {
            get { return heap.Count; }
        }

        public bool IsEmpty()
        {
            return heap.Count == 0;
        }
    }
}