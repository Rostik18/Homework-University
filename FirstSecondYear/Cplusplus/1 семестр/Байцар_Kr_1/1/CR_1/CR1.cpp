// B10.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream> 
#include <math.h>>


using namespace std;


int main() {
	int q = 1;
	do {
		float x, g, f, xk, h, a, b, S=1;

		printf("Input a: ");
		scanf_s("%f", &x);
		
		do {
			printf("Input b: ");
			scanf_s("%f", &xk);
		} while (xk <= x);

		do {
			printf("\nInput step: ");
			scanf_s("%f", &h);
		} while (h <= 0);
		printf("x   |  y\n");

		while (x <= xk) {
			g = cos(x / 2);
						if (g == 0) {
					printf("%.1f | Ops\n", x);
			}
				else {
					f = tan(x / 2) - (2 * cos(x));
					printf("%.1f | %.1f\n", x, f);

					if (f > 0) {
						S = S * (f * f);
					}
				}
			
			x += h;
		}
	
		cout << "S = " << S << endl;
	 
		cout << "\npress 1 or 0 to exed: ";
		cin >> q;

	} while (q == 1);

	return 0;
}