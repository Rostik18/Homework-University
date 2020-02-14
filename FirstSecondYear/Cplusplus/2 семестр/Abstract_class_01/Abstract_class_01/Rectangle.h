#pragma once
#include "Base_class.h"
class Rectangle :
	public Base_class
{
public:
	int a, b;
	Rectangle() : a(0), b(0) {}
	Rectangle(int _a, int _b) {
		a = _a; b = _b;
	}

	double Square() {
		return a * b;
	}

	void Print() {
		cout << "Rectangle Square: " << Square() << endl;
	}





};

