#pragma once
#include "Number.h"
class Inreger :
	public Number
{
	int a, b;
public:
	Inreger(int _a, int _b) {
		a = _a; b = _b;
	};

	double sum() { return a + b; };
	double subtraction() { return a - b; };
	double multiplication() { return a * b; };
	double division() {
		if (b == 0) b++;
		return a / b;
	};
};

