#pragma once
#include "stdafx.h"
#include <iostream>
#include <cmath>

using namespace std;
const double PI = 3.14159265358979;

class Figura{
	double a, b;
public:
	Figura();
	Figura(double a, double b);
	Figura(Figura& LoL);

	virtual istream& operator >>(istream& in);
	virtual ostream& operator<< (ostream& out);

	virtual double Square(double a, double b);
	virtual double Per(double a, double b);
};
////////////////////////////////////////////////////////////////////////////////////////
Figura::Figura() {}
Figura::Figura(double a, double b) {}
Figura::Figura(Figura& LoL) {}

istream& Figura::operator >>(istream& in) {                              //Оператор Вводу
	cout << "Enter a end b: \n";      cin >> a >> b; return in;
}

ostream& Figura::operator<<(ostream& out) {                              //Оператор Виводу
	cout << "Square: " << Square(a, b) << endl;
	cout << "perumt: " << Per(a, b) << endl; return out;
}
double Figura::Square(double a, double b) {
	return a * b;
}

double Figura::Per(double a, double b) {
	return 2 * a + 2 * b;
}



