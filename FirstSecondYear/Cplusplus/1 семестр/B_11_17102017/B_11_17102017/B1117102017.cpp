// B1117102017.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int q = 1;

	do {
		int n, max, min;
		int arr[100];

			cout << "Enter n: ";
			cin >> n;

		cout << "Enter el 1: ";
		cin >> arr[0];
		max = arr[0];
		min = arr[0];
		n = n + 1;
		for (int i = 2; i < n; i++) {
			cout << "Enter el " << i << ": ";
			cin >> arr[i];
			if (arr[i] > max) max = arr[i];
			if (arr[i] < min) min = arr[i];
		}

		cout << "Max: " << max << endl;
		cout << "Min: " << min;

		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

	return 0;
}