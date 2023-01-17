// See https://aka.ms/new-console-template for more information

var solution = new Solution();

var n1 = 3;
var edges1 = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 0 } };
var source1 = 0;
var destination1 = 2;
var output1 = solution.ValidPath(n1, edges1, source1, destination1);
Console.WriteLine(output1.ToString()); // true

var n2 = 6;
var edges2 = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 3, 5 }, new int[] { 5, 4 }, new int[] { 4, 3 } };
var source2 = 0;
var destination2 = 5;
var output2 = solution.ValidPath(n2, edges2, source2, destination2);
Console.WriteLine(output2.ToString()); // true


public class Solution
{
    class DisjointSetUnion
    {
        private int[] parent;

        public DisjointSetUnion(int n)
        {
            this.parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                this.parent[i] = i;
            }
        }

        public bool AreConnected(int u, int v)
        {
            return Find(u) == Find(v);
        }
        public void Union(int u, int v)
        {
            if (u != v)
            {
                int a = Find(u);
                int b = Find(v);
                parent[a] = b;
            }
        }

        private int Find(int u)
        {
            int x = u;
            while (x != this.parent[x])
            {
                x = this.parent[x];
            }

            this.parent[u] = x;
            return x;
        }
    }

    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        DisjointSetUnion set = new DisjointSetUnion(n);
        foreach (int[] edge in edges)
        {
            set.Union(edge[0], edge[1]);
        }

        return set.AreConnected(source, destination);
    }
}