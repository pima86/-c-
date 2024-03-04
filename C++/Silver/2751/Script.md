##### 🍏 Solution 2751번 [수 정렬하기 2] => https://www.acmicpc.net/problem/2751

```ruby
#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main() {
	int A;
	cin >> A;

	int* num = new int[A];
	for (int i = 0; i < A; i++)
		cin >> num[i];

	sort(num, num + A);
	string result = "";
	for (int i = 0; i < A; i++)
		result += to_string(num[i]) + "\n";

	cout << result;
}
```
