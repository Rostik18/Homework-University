#pragma once
#include "Iprog.h"
class neSkin :
	public Iprog
{
	double a0;
	double q;

public:
	neSkin(double _a0, double _q) : a0(_a0), q(_q) {};
	
	void sum() {
		cout << "NeSkin prog: ";
		if (q == 1 || a0 / (1 - q) >= INT_MAX || a0 / (1 - q) <= INT_MIN ) cout << " infinity!" << endl;
		else cout << a0 / (1 - q) << endl;
	}

};

