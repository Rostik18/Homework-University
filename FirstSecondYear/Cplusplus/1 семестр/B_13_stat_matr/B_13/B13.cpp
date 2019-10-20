#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int q = 1;

	do {
		int n, m;
		int arr[10][10];

		//Step 1
		do {
			cout << "1. Enter n: ";
			cin >> n;
		} while (n < 1 || n > 10);

		for (int i = 1; i <= n; i++) {
			for (int j = 1; j <= n; j++) {
				if (i == 1) {
					for (int j = 1; j <= n; j++)
						arr[1][j] = 1;
				}
				else {
					cout << "a" << i << "," << j << ": ";
					cin >> arr[i][j];
				}
			}
		}

		cout << "\n";
		for (int i = 1; i <= n; i++) {
			for (int j = 1; j <= n; j++) {
				cout << arr[i][j] << "  ";
			}
			cout << "\n";
		}

		int  max = arr[1][1], p = 1;
		for (int i = 1; i <= n; i++) {
			if (arr[i][i] > max) {
				max = arr[i][i];
				p = i;
			}
		}

		cout << "\nmax el: " << max << " p: " << p<<"\n";

		//Step 2
		do {
			cout << "2. Enter m: ";
				cin >> m;
		}while(m <1 || m > n);

		int arr1[10][10];
		
		for (int i = 1; i <= n; i++) {
			for (int j = 1; j <= n; j++) {
				arr1[i][j] = arr[i][j];
			}
		}

		for (int j = 1; j <= n; j++) {
			arr1[m][j] = arr[p][j];
        }

		for (int j = 1; j <= n; j++) {
			arr[p][j] = arr[m][j];
		}
		for (int j = 1; j <= n; j++) {
			arr[m][j] = arr1[m][j];
		}


		cout << "\n";
		for (int i = 1; i <= n; i++) {
			for (int j = 1; j <= n; j++) {
				cout << arr[i][j] << "  ";
			}
			cout << "\n";
		}


		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

	return 0;
}