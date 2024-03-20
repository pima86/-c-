using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class FileName13
    {
        static int N, M;

        static int[,] map;
        static bool[,] visited;

        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, 1, -1 };

        static void BFS(int n, int m)
        {
            visited[n, m] = true;

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((n, m));

            //Queue가 비워질 때까지
            while (queue.Count != 0)
            {
                var Deq = queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int Deq_x = Deq.Item1 + dx[i];
                    int Deq_y = Deq.Item2 + dy[i];

                    //범위 밖일 경우 패스
                    if (Deq_x < 0 || Deq_y < 0 || Deq_x > N || Deq_y > M ||
                        visited[Deq_x, Deq_y] || map[Deq_x, Deq_y] == 0)
                        continue;

                    visited[Deq_x, Deq_y] = true;
                    queue.Enqueue((Deq_x, Deq_y));
                }
            }
        }

        static void Main()
        {
            int T = int.Parse(Console.ReadLine()); //테스트 케이스의 개수

            //T만큼 반복수행
            for (int t = 0; t < T; t++) 
            {
                int[] MNK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                M = MNK[0]; //배추밭의 가로길이
                N = MNK[1]; //배추밭의 세로길이
                int K = MNK[2]; //배추가 심어져 있는 위치의 개수


                //BFS_Reset
                int count = 0; //배추흰지렁이의 수
                map = new int[51, 51]; //배추밭
                visited = new bool[51, 51]; //방문확인

                for (int k = 0; k < K; k++)
                {
                    int[] XY = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    
                    int X = XY[0]; //배추의 가로 좌표
                    int Y = XY[1]; //배추의 세로 좌표

                    map[Y, X] = 1;
                }


                //BFS()
                for (int n = 0; n < N; n++)
                {
                    for (int m = 0; m < M; m++)
                    {
                        //Console.Write(map[n, m]);
                        if (map[n, m] == 1 && visited[n, m] == false)
                        {
                            BFS(n, m);
                            count++;
                        }
                    }
                    //Console.Write("\n");
                }

                Console.WriteLine(count);
            }
        }
    }
}
