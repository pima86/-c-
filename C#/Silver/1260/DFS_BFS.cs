using System;
using System.Collections;

namespace Project1
{
    class FileName10
    {
        static int N, M;
        static int[,] edge;
        static bool[] visited;

        static void Main()
        {
            int[] NMV = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            N = NMV[0];
            int M = NMV[1];
            int V = NMV[2];

            edge = new int[N + 1, N + 1];
            
            for (int m = 0; m < M; m++)
            {
                int[] XY = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                edge[XY[0], XY[1]] = edge[XY[1], XY[0]] = 1;
            }

            visited = new bool[N + 1];
            DFS(V);

            Console.WriteLine();

            visited = new bool[N + 1];
            BFS(V);

        }

        static void DFS(int v)
        {
            visited[v] = true;
            Console.Write(v + " ");

            for (int n = 1; n <= N; n++)
            {
                if (edge[v, n] == 1 && !visited[n])
                    DFS(n);
            }
        }

        static void BFS(int v)
        {
            visited[v] = true;

            Queue queue = new Queue();
            queue.Enqueue(v);

            while (queue.Count != 0)
            {
                int Deq = (int)queue.Dequeue();
                Console.Write(Deq + " ");

                for (int n = 1; n <= N; n++)
                {
                    if (edge[Deq, n] == 1 && !visited[n])
                    {
                        queue.Enqueue(n);
                        visited[n] = true;
                    }
                }
            }
        }
    }
}
