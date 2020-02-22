// B8.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int q = 1;
	int a, b, c, d, e;
	int a1, b1, c1, d1, e1;

	do {
		int n = 0;
		cout << "Enter nombers: \n";
		cin >> a >> b >> c >> d >> e;

		a1 = 1 + rand() % 10;
		b1 = 1 + rand() % 10;
		c1 = 1 + rand() % 10;
		d1 = 1 + rand() % 10;
		e1 = 1 + rand() % 10;

		if (a == a1 || a == b1 || a == c1 || a == d1 || a == e1) n = n + 1;
		if (b == a1 || b == b1 || b == c1 || b == d1 || b == e1) n = n + 1;
		if (c == a1 || c == b1 || c == c1 || c == d1 || c == e1) n = n + 1;
		if (d == a1 || d == b1 || d == c1 || d == d1 || d == e1) n = n + 1;
		if (e == a1 || e == b1 || e == c1 || e == d1 || e == e1) n = n + 1;

		cout << "rez: " << n;

		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

    return 0;
}

