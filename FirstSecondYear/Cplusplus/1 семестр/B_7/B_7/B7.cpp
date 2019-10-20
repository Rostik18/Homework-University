// B7.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <cstdio>
#include <ctime>

using namespace std;

int main()
{
	int q = 1;

	do {

	int arr[50];
	int max = arr[50];
	

	for (int i = 0; i < 50; i++) {
		
	cout << "Enter nombers: ";
			cin >> arr[i];
			

			if (arr[i] == 0) {
				i = 50;
			}
	}

	for (int i = 0; i < 50; i++) {
		if (arr[i] > max) {
			max = arr[i];
		}
	}
		cout << "rez: " << max;
		
	cout << "\npress 1 or 0 to exed: ";
	cin >> q;

	} while (q == 1);


	return 0;
}