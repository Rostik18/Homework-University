#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

void Merge(int* arr, int p, int q, int r) {
	int n1 = q - p + 1,
		n2 = r - q;

	int* L = new int[n1];
	int* R = new int[n2];
	for (int i = 0; i < n1; i++) {

	}

}

void MergeSort(int* arr, int p,int r) {
	if (p < r) {
		int q = (int)(q + r + 1) / 2;
		MergeSort(arr, p, q);
		MergeSort(arr, q+1, r);
		Merge(arr, p, q, r);
	}
}

int main()
{
	int n;
	cout << "Enter n: "; cin >> n;

	int * arr = new int[n];
	for (int i = 0; i < n; i++) {
		arr[i] = rand() % 100;
		cout << arr[i] << " ";
	}
	cout << endl;
	MergeSort(arr, 0, n);

	system("pause");
    return 0;
}

