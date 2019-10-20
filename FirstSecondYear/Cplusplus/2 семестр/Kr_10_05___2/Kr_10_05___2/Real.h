#pragma once
#include "Number.h"

class Real :
	public Number
{
	double a, b;
public:
	Real(double _a, double _b) {
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

