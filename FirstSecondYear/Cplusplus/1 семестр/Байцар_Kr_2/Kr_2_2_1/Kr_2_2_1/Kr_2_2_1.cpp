
#include "stdafx.h"
#include <iostream>
using namespace std;


int main(){
	int n, k;

	do {
		cout << "n: ";
		cin >> n;
	} while (n < 1);

	do {
		cout << "k: ";
		cin >> k;
	} while (n < 0);

	int *arr = new int[n];
	cout << "Enter a: \n";
	for (int i = 0; i < n; i++) {
		cout << "a" << i + 1 << ": ";
		cin >> arr[i];
  }
	int *arr1 = new int[n];
	for (int i = 0; i < n; i++) {
		if (arr[i] % 10 == k) {
			arr1[i] = arr[i];
		}
	}

	for (int i = 0; i < n; i++) {
		if (arr1[i] % 10 == k) {
			cout << arr1[i] << "   ";
		}
	}
	cout << endl;
	system("pause");
    return 0;
}

