```ruby
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1
{
    class FileName
    {
        static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        static StringBuilder sb = new StringBuilder();
        static List<int> heap = new List<int>();

        static void Heap_Add(int x)
        {
            heap.Add(x);

            int size = heap.Count - 1;
            while (size > 0)
            {
                int p = (size - 1) / 2;
                if (heap[p] < heap[size])
                {
                    Swap(p, size);
                    size = p;
                }
                else
                    break;
            }
        }

        static void Heap_Pop()
        {
            if (heap.Count == 0)
                sb.AppendLine("0");
            else
            {
                int temp = heap[0];
                heap[0] = heap[heap.Count - 1];
                heap.RemoveAt(heap.Count - 1);

                int i = 0;
                int j = heap.Count - 1;
                while (i < j)
                {
                    int index = i * 2 + 1;

                    if (index < j && heap[index] < heap[index + 1])
                        index = index + 1;

                    if (index > j || heap[i] > heap[index])
                        break;

                    Swap(i, index);
                    i = index;
                }
                sb.AppendLine(temp.ToString());
            }
        }

        static void Swap(int p, int size)
        {
            int temp = heap[p];
            heap[p] = heap[size];
            heap[size] = temp;
        }

        static void Main()
        {
            int N = int.Parse(sr.ReadLine());
            while (N-- > 0)
            {
                int num = int.Parse(sr.ReadLine());

                if (num == 0)
                    Heap_Pop();
                else
                    Heap_Add(num);
            }

            sw.Write(sb.ToString());

            sw.Close();
            sr.Close();
        }
    }
}

```
