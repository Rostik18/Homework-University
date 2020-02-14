#pragma once
#include "Pair.h"
class Rational :
	public Pair
{

public:
	Rational(int _a, int _b):Pair(a, b) {
		a = _a; b = _b;
	};
	
	double operator+(Rational& _B) {
		return (a / b) + (_B.a / _B.b);
	}

	double operator/(Rational& _B) {
		return a / b / _B.a / _B.b;
	}

	double operator-(Rational& _B) {
		return (a / b) - (_B.a / _B.b);
	}
};

