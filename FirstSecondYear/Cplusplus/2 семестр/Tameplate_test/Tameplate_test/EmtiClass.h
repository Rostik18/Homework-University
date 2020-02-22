#pragma once
#include <iomanip>
#include <iostream>
using namespace std;
template <class T> class EmtiClass
{
	T * arr;
	int n;
public:
	EmtiClass() : n(0) {
		for (int i = 0; i < n; i++) {
			arr[i] = 0;
		}
	};
	EmtiClass(T* _arr, int _n) {
		arr = _arr;
		n = _n;
	};

	void quickSort() {
		cout << "___" << n << endl;

		for (int i = 0; i < n -1 ; i++) {
			for (int j = 0; j < n - 1 - i; j++) {
				if (arr[j] > arr[j + 1]) swap(arr[j], arr[j + 1]);
			}
		}
		
		for (int i = 0; i < n; i++) {
			cout << arr[i] << " ";
		}
		cout << endl;
	}

};

