// B4.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <iostream>

using namespace std;

int main() {

	
	int q = 1;

	do {
		float x, f, xk, h, a, b, c;

	printf("Input a: ");
	scanf_s("%f", &a);
	printf("Input b: ");
	scanf_s("%f", &b);
	printf("Input c: ");
	scanf_s("%f", &c);
	printf("Input x1: ");
	scanf_s("%f", &x);
	printf("Input xn: ");
	scanf_s("%f", &xk);
	printf("\nInput step: ");
	scanf_s("%f", &h);
	printf("x   |  F\n");
	

	while (x <= xk) {
			if ((x < 0) && (b != 0)) {
				f = a * pow(x, 2) + b;
				printf("%.1f | %.1f\n", x, f);
			}

			if ((x > 0) && (b == 0)) {

				if (x == c) {
					printf("%.1f | Ops\n", x);
				}
				else {
					f = ((x - a) / (x - c));
					printf("%.1f | %.1f\n", x, f);
				}
			}

			else {

				if (c == 0) {
					printf("%.1f | Ops\n", x);
				}
				else {
					f = x / c;
					printf("%.1f | %.1f\n", x, f);
				}

		}
		x += h;
	}
		
	cout << "press 1 or 0 to exed: ";
	cin >> q;

	} while (q == 1);
}
