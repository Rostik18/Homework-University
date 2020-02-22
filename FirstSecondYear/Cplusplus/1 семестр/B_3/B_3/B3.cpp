// B3.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double x, y, R;
	int q = 1;

	do {
		cout << "Enter  R: ";
		cin >> R;
		cout << "Enter x: ";
		cin >> x;
		cout << "Enter y: ";
		cin >> y;

		bool firstQuater = x >= 0 && x <= R && y >= 0 && y <= R;
		bool firstIsPoint = pow(x, 2) + pow(y, 2) <= pow(R, 2) && y >= x;
		bool thirdQuater = x >= -R && x <= 0 && y >= -R && y <= 0;
		bool thirdIsPoint = pow(x, 2) + pow(y, 2) <= pow(R, 2) && y <= x;

		if (firstQuater) {
			cout << "res: " << firstIsPoint << endl;
		}
		else if (thirdQuater) {
			cout << "res: " << thirdIsPoint << endl;
		}
		else cout << false;


		cout << "press 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

	system("pause");

		return 0;
	
}

