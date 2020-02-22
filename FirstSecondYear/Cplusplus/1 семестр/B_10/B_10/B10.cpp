// B10.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream> 
#include <math.h>>

using namespace std;


int main() {
	int q = 1;
	do {
	
		double n, S = 0;

		do {
			cout << "Enter n : ";
			cin >> n;
		} while (n < 1);
		int m = n;
		for (int i = 0; i < n; i++) {
			
			S = S + 1.0 / m;
			m--;
			 }

		cout << "S = " << S;

		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

	return 0;
}