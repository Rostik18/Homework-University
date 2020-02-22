#pragma once
#include "Base_class.h"
class Trapeze :
	public Base_class
{
public:
	double a, b, h;
	Trapeze() : a(0), b(0), h(0) {};
	Trapeze(double _a, double _b, double _h) {
		a = _a; b = _b; h = _h;
	}

	double Square() {
		return (a + b) * h / 2;
	}

	void Print() {
		cout << "Trapeze Square: " << Square() << endl;
	}

};

