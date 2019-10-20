// B10.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream> 
#include <math.h>>

using namespace std;


int main() {
	int q = 1;
	do {
		double x, y, k;
		int S = 0;

		cout << "Enter x: ";
		cin >> x;
		cout << "Enter y: ";
		cin >> y;

		k = y / x;
		if (x > 0 && y > 0 && x <= 1 && y <= 1 && (x <= y || y <= x)) {
			S = 1;
		}

		if (x < 0 && y > 0 && x >= -1 && y <= 1 && (x <= -y || y <= -x)) {
			S = 1;
		}

		if (x <= 1 && y <= 0 && x >= -1 && y >= -3) {
			S = 1;
		}


		cout << k<< " Rez: " << S;

		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

	return 0;
}