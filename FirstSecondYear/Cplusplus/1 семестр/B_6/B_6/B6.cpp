// B6.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream> 
#include <cmath> 
#include <math.h>
#include <iomanip>

using namespace std;


int main() {
	int q = 1;
	int d, m, y, c, S;

	do {
		do {
		cout << "Enter day: ";
		cin >> d;
		} while (d > 31 || d < 1);
		
		do {
			cout << "Enter month: ";
			cin >> m;
		} while (m > 12 || m < 1);

		do {
			cout << "Enter year: ";
			cin >> y;
		} while (y < 1);
		c = y / 100 + 1;
		m = m - 2;

		 S = (d + (13 * m - 1) / 5 + y + (y / 4) + (c / 4) - 2 * c + 777) % 7;

		if (S == 0) {
			cout << "rez: ponedilok";
		}
		else if (S == 1) {
			cout << "rez: vivtorrok";
		}
		else if (S == 2) {
			cout << "rez: sereda";
		}
		else if (S == 3) {
			cout << "rez: chetver";
		}
		else if (S == 4) {
			cout << "rez: potnucia";
		}
		else if (S == 5) {
			cout << "rez: subota";
		}
		else if (S == 6) {
			cout << "rez: nedilia";
		}

		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);
} 