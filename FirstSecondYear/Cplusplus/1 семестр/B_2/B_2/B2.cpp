// B2.cpp: определяет точку входа для консольного приложения.
//
#include "stdafx.h"
#include <iostream>
#include <math.h>

using namespace std;

int main() {
	double x, y, R;
	int q = 1;

	do {
		cout << "Enter  R: ";
		cin >> R;
		cout << "Enter x: ";
		cin >> x;

		if (R == 3) {
			if (x >= -9 && x < -6) {
				y = (-sqrt(pow(R, 2) - pow((x + 6), 2)));
				if (y == -0) cout << "y = " << -y << endl;
				else cout << "y = " << y << endl;
			}
			else if (x >= -6 && x < -3) {
				y = (x + 3);
				cout << "y = " << y << endl;
			}
			else if (x >= -3 && x < 0) {
				y = (sqrt(9 - pow(x, 2)));
				cout << "y = " << y << endl;
			}
			else if (x >= 0 && x < 3) {
				y = (-x + 3);
				cout << "y = " << y << endl;
			}
			else if (x >= 3 && x <= 9) {
				y = ((0.5 * x) - 1.5);
				cout << "y = " << y << endl;
			}
			else cout << "Incorrect x" << endl;
		}
		if (R != 3) {
			if (x >= -9 && x < -6) {
				y = (-sqrt(pow(R, 2) - pow((x + 2 * R), 2)));
				if (y == -0) cout << "y = " << -y << endl;
				else cout << "y = " << y << endl;
			}
			else if (x >= -6 && x < -3) {
				y = (x + R);
				cout << "y = " << y << endl;
			}
			else if (x >= -3 && x < 0) {
				y = (sqrt(pow(R, 2) - pow(x, 2)));
				cout << "y = " << y << endl;
			}
			else if (x >= 0 && x < 3) {
				y = (-x + R);
				cout << "y = " << y << endl;
			}
			else if (x >= 3 && x <= 9) {
				y = ((0.5 * x) - 1.5);
				cout << "y = " << y << endl;
			}
			else cout << "Incorrect x" << endl;
		}
		cout << "press 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);
	


	system("pause");
	return 0;
}