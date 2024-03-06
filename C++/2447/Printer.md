```ruby
#include<iostream>
using namespace std;

int X, Y = 0;

void Printer(int x, int y, int n);

int main()
{
	int N;
	cin >> N;


	for (int y = 0; y < N; y++)
	{
		for (int x = 0; x < N; x++)
			Printer(x, y, N);
		cout << '\n';
	}

	return 0;
}

void Printer(int x, int y, int n)
{
	if ((x / n) % 3 == 1 && (y / n) % 3 == 1)
		cout << ' ';
	else if (n / 3 == 0)
	{
		cout << '*';
	}
	else
		Printer(x, y, n / 3);
}
```
