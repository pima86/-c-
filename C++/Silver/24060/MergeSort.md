```ruby
#include<iostream>
#define fastio ios::sync_with_stdio(0), cin.tie(0), cout.tie(0)
using namespace std;

void Merge(int* A, int k, int start, int end);
void MergeSort(int* A, int k, int start, int middle, int end);

int count = 0;

int main()
{
	fastio;

	//배열의 크기와 가져올 K번째 숫자
	int N, K;
	cin >> N >> K;

	//배열 A
	int* A = new int[N];
	for (int i = 0; i < N; i++)
		cin >> A[i];
	
	Merge(A, K, 0, N-1);
	if (::count < K)
		cout << -1;

	return 0;
}

void Merge(int* A, int k, int start, int end)
{
	if (start < end)
	{
		int middle = (start + end) / 2;
		Merge(A, k, start, middle);
		Merge(A, k, middle + 1, end);
		MergeSort(A, k, start, middle, end);
	}
}

void MergeSort(int* A, int k, int start, int middle, int end)
{
	int temp[end];
	int i = start, j = middle + 1, t = 0;

	while (i <= middle && j <= end)
	{
		if (A[i] <= A[j])
			temp[t++] = A[i++];
		else
			temp[t++] = A[j++];
	}

	while (i <= middle)
		temp[t++] = A[i++];
	while (j <= end)
		temp[t++] = A[j++];

	i = start, t = 0;

	while (i <= end)
	{
		A[i++] = temp[t++];
		if (++::count == k)
			cout << temp[t - 1];
	}
}
```
