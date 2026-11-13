
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MarulengMunicipalityApplication
{
    public partial class DataStructuresForm : Form
    {
        public DataStructuresForm()
        {
            InitializeComponent();

            comboArea.Items.AddRange(new object[]
            {
                "Maruleng",
                "Hoedspruit",
                "Mica",
                "Ofcolaco",
                "Burgersfort"
            });

            comboArea.SelectedIndex = 0;

            buttonBFS.Click += buttonBFS_Click;
            buttonDFS.Click += buttonDFS_Click;
            buttonMST.Click += buttonMST_Click;
            buttonTrees.Click += buttonTrees_Click;
            buttonHeap.Click += buttonHeap_Click;
            buttonBack.Click += buttonBack_Click;
        }

        // BREADTH-FIRST SEARCH
        private void buttonBFS_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();

            List<string> result =
                DataStore.ServiceGraph.BreadthFirstSearch(comboArea.Text);

            listResults.Items.Add("Breadth-First Search (BFS)");
            listResults.Items.Add("");

            foreach (string area in result)
            {
                listResults.Items.Add(area);
            }
        }

        // DEPTH-FIRST SEARCH
        private void buttonDFS_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();

            List<string> result =
                DataStore.ServiceGraph.DepthFirstSearch(comboArea.Text);

            listResults.Items.Add("Depth-First Search (DFS)");
            listResults.Items.Add("");

            foreach (string area in result)
            {
                listResults.Items.Add(area);
            }
        }

        // MINIMUM SPANNING TREE
        private void buttonMST_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();

            List<string> result =
                DataStore.ServiceGraph.GetMinimumSpanningTree(comboArea.Text);

            listResults.Items.Add("Minimum Spanning Tree (Prim's)");
            listResults.Items.Add("-------------------------------");

            foreach (string connection in result)
            {
                listResults.Items.Add(connection);
            }
        }

        // TREE DEMONSTRATION
        private void buttonTrees_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();

            listResults.Items.Add("TREE DEMONSTRATION");
            listResults.Items.Add("------------------");

            listResults.Items.Add("Basic Binary Tree: " +
                DataStore.IssueBinaryTree.GetLevelOrder().Count);

            listResults.Items.Add("Binary Search Tree: " +
                DataStore.IssueSearchTree.GetInOrder().Count);

            listResults.Items.Add("AVL Tree: " +
                DataStore.IssueAVLTree.GetInOrder().Count);

            listResults.Items.Add("Red-Black Tree: " +
                DataStore.IssueRedBlackTree.GetInOrder().Count);

            if (DataStore.Issues.Count > 0)
            {
                int id = DataStore.Issues[0].Id;

                listResults.Items.Add("");
                listResults.Items.Add("Search demonstration for ID: " + id);

                listResults.Items.Add("BST found: " +
                    (DataStore.SearchIssueTree(id) != null));

                listResults.Items.Add("AVL found: " +
                    (DataStore.SearchIssueAVL(id) != null));

                listResults.Items.Add("Red-Black found: " +
                    (DataStore.SearchIssueRedBlack(id) != null));

                listResults.Items.Add("Binary Tree found: " +
                    (DataStore.SearchIssueBinaryTree(id) != null));
            }
            else
            {
                listResults.Items.Add(
                    "Submit a service request to test searching.");
            }
        }

        // PRIORITY QUEUE DEMONSTRATION
        private void buttonHeap_Click(object sender, EventArgs e)
        {
            listResults.Items.Clear();

            listResults.Items.Add("MAX HEAP PRIORITY QUEUE");
            listResults.Items.Add("-----------------------");

            listResults.Items.Add("Requests in queue: " +
                DataStore.IssuePriorityQueue.Count);

            Issue highest = DataStore.GetHighestPriorityIssue();

            if (highest != null)
            {
                listResults.Items.Add("Highest-priority request:");
                listResults.Items.Add("Request ID: " + highest.Id);
                listResults.Items.Add("Priority: " + highest.Priority);
                listResults.Items.Add("Category: " + highest.Category);
            }
            else
            {
                listResults.Items.Add(
                    "No requests in the priority queue.");
            }
        }

        // BACK TO MAIN MENU
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
