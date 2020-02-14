#include "stdafx.h"
#include <iostream>
#include <cstdio>
#include <ctime>
#include <iomanip>

using namespace std;

int main()
{
	int q = 1;

	do {
		int  n;
		do {
			cout << "Enter n: ";
			cin >> n;
		} while (n < 2);

		int **a = new int *[n];

		int Z;
		cout << "Zapovnutu Randomno? (1 or 0): ";
		do {
			cin >> Z;
		} while (Z < 0 || Z > 1);

		for (int i = 1; i <= n; i++) {
			a[i] = new int[n];
			for (int j = 1; j <= n; j++) {
				if (Z == 0) {
					cin >> a[i][j];
				}
				if (Z == 1) {
					a[i][j] = -99 + rand() % 200;
				}
			}
		}
		cout << "\nmatrix: \n";

		for (int i = 1; i <= n; i++) {
			for (int j = 1; j <= n; j++) {
				cout << setw(4) << a[i][j] << " ";
			}
			cout << endl;
		}

		int *b = new int[n];

		for (int i = 1; i <= n; i++) {
			b[i] = a[i][1];
		}

		int x, y;

		for (int i = 1; i <= n; i++) {
			for (int j = 1; j <= n; j++) {
				if (b[i] < a[i][j]) {
					b[i] = a[i][j];
				}
			}
		}

		int c = b[1];

		for (int i = 1; i <= n; i++) {
			if (c > b[i]) {
				c = b[i];
			}
		}

		for (int i = 1; i <= n; i++) {
			for (int j = 1; j <= n; j++) {
				if (a[i][j] == c) {
					x = i;
					y = j;
				}
			}
		}
		cout << endl;
		for (int i = 1; i <= n; i++) {
				cout << b[i] << " ";
		}
		cout << "\nindx: " << x << "," << y;
		cout << "\npress 1 or 0 to exed: ";
		cin >> q;
	} while (q == 1);
	return 0;
}