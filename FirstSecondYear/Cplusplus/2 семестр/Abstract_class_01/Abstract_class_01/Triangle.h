#pragma once
#include "Base_class.h"
class Triangle :
	public Base_class
{
public:
	double a, b;
	Triangle() : a(0), b(0) {};
	Triangle(double _a, double _b) {
		a = _a; b = _b;
	}

	double Square() {
		return a * b / 2;
	}

	void Print() {
		cout << "Triangle Square: " << Square() << endl;
	}





};

