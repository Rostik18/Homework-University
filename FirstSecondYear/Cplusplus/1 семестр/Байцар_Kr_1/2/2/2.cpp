// B10.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream> 
#include <math.h>>

using namespace std;
int main() {
	int q = 1;
	do {
		int n;
		float arr[100], S;
		do {
			cout << "Enter n: ";
			cin >> n;
		} while (n < 1);
		cout << "Enter elements: " << endl;
		for (int i = 0; i < n; i++) {
			cin >> arr[i];
		}
		float a = 1, b = 1, c = 1;
		for (int i = 0; i < n; i++) {

			if (arr[i] > 0) {
				a = arr[i];
				break;
			}
		}
		for (int i = 0; i < n; i++) {

			if (arr[i] > 0 && arr[i] != a) {
				b = arr[i];
				break;
			}
		}
		for (int i = 0; i < n; i++) {
			if (arr[i] > 0 && arr[i] != a && arr[i] != b) {
				c = arr[i];
				break;
			}
		}
		S = a * b * c;
		cout << "a: " << a << " b: " << b << " c: " << c;
		cout << "\nS= " << S;
		cout << "\npress 1 or 0 to exed: ";
		cin >> q;
	} while (q == 1);
	return 0;
}