using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParalAlg
{
    public partial class Form1 : Form
    {
        readonly List<Edge> Graph;
        readonly HashSet<string> Points;

        public Form1()
        {
            Graph = new List<Edge>();
            Points = new HashSet<string>();
            InitializeComponent();
        }

        public void AddEdgeListView()
        {
            var start = StartTxt.Text;
            var finish = FinishTxt.Text;
            StartTxt.Clear();
            FinishTxt.Clear();
            if (start != finish)
            {
                Graph.Add(new Edge(start, finish));
                EdgesListView.Items.Add(new ListViewItem(new string[] { start, "->", finish }));
            }
            StartTxt.Focus();
        }

        private void AddEdge_Click(object sender, EventArgs e)
        {
            AddEdgeListView();
        }

        private void DeleteLastEdge_Click(object sender, EventArgs e)
        {
            var edges = EdgesListView.Items;
            if (edges.Count > 0)
            {
                var lastEdge = edges[edges.Count - 1];
                edges.Remove(lastEdge);
                Graph.RemoveAll(_ => _.Start == lastEdge.SubItems[0].Text && _.Finish == lastEdge.SubItems[2].Text);
            }
            StartTxt.Focus();
        }

        private void FinishTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                AddEdgeListView();
            }
        }

        private void StartTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Right) && StartTxt.SelectionStart == StartTxt.Text.Length)
            {
                FinishTxt.Focus();
            }
        }
    }

    public class Edge
    {
        public string Start { get; set; }
        public string Finish { get; set; }

        public Edge() { }

        public Edge(string start, string finish)
        {
            Start = start;
            Finish = finish;
        }
    }
}
