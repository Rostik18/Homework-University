#pragma once
#include <cmath>
#include <iostream>
using namespace std;
template <class T> class Perevid{
public:
	T * arr = new T[n];
	int n;
	Perevid() : n(0) {};

	Perevid(T* _arr, int _n) {
		arr = _arr;
		n = _n;
		Per();
	};

	void Per() {
		for (int i(0); i < n; i++) {
			arr[i] = exp (arr[i]);
		}
		Print();
	}

	void Print() {
		for (int i = 0; i < n; i++) {
			cout << arr[i] << " ";
		}
		cout << endl;
	}

};

