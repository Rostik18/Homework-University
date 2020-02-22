#pragma once
#include "Base_class.h"
class Kolo :
	public Base_class
{
public:
	double R;
	Kolo() : R(0) {};
	Kolo(double _R) { R = _R; };

	double Square() {
		return R * R * 3.1415926535;
	}

	void Print() {
		cout << "Kolo Square: " << Square() << endl;
	}
};

