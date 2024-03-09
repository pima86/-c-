```ruby
using System;

namespace Project1
{
    class FileName
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int n = 0; n < N; n++)
            {
                int[] XY = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int y = XY[1] - XY[0];

                double amount = 0;
                int temp = 1;

                while (y > amount + temp * 2)
                {
                    amount += temp * 2;
                    temp++;
                }

                if (y > amount + temp) Console.WriteLine(2 * temp);
                else Console.WriteLine(2 * temp - 1);
            }
        }
    }
}

```
