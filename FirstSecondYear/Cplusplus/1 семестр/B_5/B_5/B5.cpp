// B5.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int q = 1;
	double a, b, c, d;

	do {
		cout << "Enter a: ";
		cin >> a;
		cout << "Enter b: ";
		cin >> b;
		cout << "Enter c: ";
		cin >> c;
		cout << "Enter d: ";
		cin >> d;

		if (a == d || b == d || c == d) {
			cout << "rez: " << d;
		}
		else if (a < b && a < c) {
			cout << "rez d - a: " << d - a;
		}
		else if (b < a && b < c) {
			cout << "rez d - b: " << d - b;
		}
		else if (c < b && c < a) {
			cout << "rez d-c: " << d - c;
		}
		else cout << "Inaccurate";

		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

    return 0;
}

