using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace list_test1
{
    internal class dijkstraTEst
    {
        const int INF = 99;

        public static void dijkstraTest(in int[,] graph, int start,out bool[] visited,out int[] parents,out int[] distance, out Queue<int>[] queue)
        {
            int n = graph.GetLength(0);
            queue = new Queue<int>[n];    
            visited = new bool[n];
            parents = new int[n];
            distance = new int[n];

            for (int i = 0; i < n; i++)
            {
                queue[i] = new Queue<int>();
                visited[i] = false;
                parents[i] = -1;
                distance[i] = INF;
                
            }
            distance[start] = 0;
            for (int i = 0; i < n; i++)
            {
                int next = -1;
                int minCost = INF;
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j] && distance[j] < minCost)
                    {
                        minCost = distance[j];
                        next = j;
                        
                    }
                }
                if (next < 0)
                {
                    break;

                }
                for (int j = 0; j < n; j++)
                {
                    if (distance[j] > graph[j, next] + distance[next])
                    {
                        distance[j] = graph[j, next] + distance[next];
                        parents[j] = next;
                        queue[j].Enqueue(next);
                    }
                }
                visited[next] = true;
                
            }



        }

        static void Main(string[] args)
        {
            int[,] graph = new int[18, 18]
   {
       {  0,  6,  6,INF,INF,INF,INF,  7,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF},
       {  6,  0,INF,INF,INF,  9,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF},
       {  6,INF,  0,  7,INF,INF,  8,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF},
       {INF,INF,  7,  0,INF,INF,  8,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,  3},
       {INF,INF,INF,INF,  0,  2,INF,  7,  8,INF,INF,INF,INF,INF,INF,INF,INF,INF},
       {INF,  9,INF,INF,  2,  0,  1,INF,INF,  2,INF,INF,INF,INF,INF,INF,INF,INF},
       {INF,INF,  8,  8,INF,  1,  0,INF,INF,  2,  8,INF,INF,INF,INF,INF,INF,INF},
       {  7,INF,INF,INF,  7,INF,INF,  0,  4,INF,INF,  5,INF,INF,  5,INF,INF,INF},
       {INF,INF,INF,INF,  8,INF,INF,  4,  0,  3,INF,INF,  4,INF,INF,INF,INF,INF},
       {INF,INF,INF,INF,INF,  2,  2,INF,  3,  0,  5,INF,  1,INF,INF,INF,INF,INF},
       {INF,INF,INF,INF,INF,INF,  8,INF,INF,  5,  0,INF,INF,INF,INF,INF,INF,  7},
       {INF,INF,INF,INF,INF,INF,INF,  5,INF,INF,INF,  0,INF,INF,  3,INF,INF,INF},
       {INF,INF,INF,INF,INF,INF,INF,INF,  4,  1,INF,INF,  0,INF,INF,  4,  7,INF},
       {INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,  1,INF},
       {INF,INF,INF,INF,INF,INF,INF,  5,INF,INF,INF,  3,INF,INF,  0,  2,INF,INF},
       {INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,  4,INF,  2,  0,  1,  6},
       {INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,INF,  7,  1,INF,  3,  0,INF},
       {INF,INF,INF,  3,INF,INF,INF,INF,INF,INF,  7,INF,INF,INF,INF,  6,INF,  0}
   };

            dijkstraTEst.dijkstraTest(graph, 0, out bool[] visited, out int[] parents, out int[] distance,out Queue<int>[] queue);

            Console.WriteLine("dijkstra");
            Dijkstraaaa(distance, parents, queue);
        }

        private static void Dijkstraaaa(int[] distance, int[] parents, Queue<int>[] queue)
        {
            Console.WriteLine($"{"Vertex",8}{"Visit",8}{"Path",8}");


            for (int i = 0; i < distance.Length; i++)
            {
                Console.Write($"     {i,-8}");

                if (distance[i] >= INF)
                {
                    Console.Write($"{"INF",-8}");
                }
                else
                {
                    Console.Write($"{distance[i],-8}");
                }


                    Console.Write($"{parents[i],-8}");


                Console.WriteLine();
            }
        }
           
        }
    }




