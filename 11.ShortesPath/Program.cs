﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._ShortesPath
{
    internal class Dijkstra
    {
        /********************************************************************
         * 다익스트라 알고리즘 (Dijkstra Algorithm)
         * 
         * 특정한 노드에서 출발하여 다른 노드로 가는 각각의 최단 경로를 구함
         * 방문하지 않은 노드 중에서 최단 거리가 가장 짧은 노드를 선택 후,
         * 해당 노드를 거쳐 다른 노드로 가는 비용 계산
         ********************************************************************/

        const int INF = 99999;

       public static void ShortestPath(int[,] graph,int start, out bool[] visited, out int[] distance, out int[] parents)
        {
            int size = graph.GetLength(0);
            visited = new bool[size];
            distance = new int[size];
            parents = new int[size];

            for( int i = 0; i < size; i++ )
            {
                visited[i] = false;
                distance[i] = INF;
                parents[i] = -1;

            }
            distance[start] = 0;

            for (int i = 0;i < size; i++ )
            {
                //1. 방문하지 않은 정점 중 가장 가까운 정점 선택
                int next = -1;
                int minCost = INF;
                for (int j = 0; j < size; j++ )
                {
                    if (distance[j] < minCost&& // 더 가까운 정점
                        !visited[j]) //방문하지 않은 정점
                    {
                        next = j;
                        minCost = distance[j];
                    }
                }
                if (next < 0)           // 하나도 없는 경우
                    break;

                //2. 직접 연결된 거리보다 거쳐서 더 짧아지는 경우 갱신
                for (int j = 0;j < size; j++ )
                {
                    //AB distance[j] : 목적지까지 직접 연결된 거리
                    //AC distance[next] : 탐색중인 정점까지 거리
                    //BC graph[next,j] : 탐색중인 정점부터 목적지까지의 거리
                    if (distance[j] > distance[next] + graph[next, j])
                    {
                        distance[j] = distance[next] + graph[next, j]; //갱신
                        parents[j] = next;
                        
                    }
                }
                visited[next] = true;
            }
        }
        }
    }
