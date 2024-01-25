using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_test
{
    public class Program
    {
        public static void DFS(in bool[,] graph, int start, int[] parents, bool[] visited)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }
            SearchNode(graph, start, parents,visited);
        }
        private static void SearchNode(in bool[,]graph,int start, int[] parents,bool[] visited)
        {
            visited[start] = true;
            for(int i = start; i < graph.GetLength(0); i++)
            {
                if (graph[start, i] && !visited[i])
                {
                    parents[i] = start;
                    SearchNode(graph,i, parents, visited);
                }
            }
        }
        public static void BFS(in bool[,] graph, int start, int[] parents, bool[] visited)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for (int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }
            Queue<int> queue = new Queue<int>();
            visited[start] = true;
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int n = queue.Dequeue();
                for(int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[n, i] && !visited[i])
                    {
                        visited[i] = true;
                        parents[i] = n;
                        queue.Enqueue(i);
                    }
                }
            }
        }
        public static void Mai45n(string[] args)
        {

        }
    }

}

