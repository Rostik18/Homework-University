#pragma once
#include "Iprog.h"
class Skin :
	public Iprog
{
	double a0;
	double q;
	int n;
public:

	Skin(double _a0, double _q, int _n) : a0(_a0), q(_q), n(_n) {};

	double sumAn() {
		return a0 * pow(q, n);
	}

	void sum() {
		if (q == 1) cout << "Sum n 4lena skin prog is infinity!" << endl;
		else cout << "Sum n 4lena skin prog: " << (a0 - (sumAn() * q)) / (1 - q) << endl;

	}

};

