#pragma once
#include "Figura.h"
#include <iomanip>
class Trapeze : public Figura {
	double a, b, c, d;
public:
	Trapeze();
	Trapeze(double a, double b, double c, double d);
	Trapeze(Trapeze& LoL);

	istream& operator >>(istream& in);
	 ostream& operator<< (ostream& out);

	double Square(double a, double b, double c, double d);
	 double Per(double a, double b, double c, double d);
};
////////////////////////////////////////////////////////////////////////////////////////
Trapeze::Trapeze() {}
Trapeze::Trapeze(double a, double b, double c, double d) {}
Trapeze::Trapeze(Trapeze& LoL) {}

istream& Trapeze::operator>>(istream& in) {
	cout << "Enter a, b, c, d: " << endl;
	cin >> a >> b >> c >> d;
	return in;
}
ostream& Trapeze::operator<< (ostream& out) {
	if (Square(a, b, c, d) == 0) cout << "Thes Figura is not Trapeze!" << endl;
	else {
		cout << "Square: " << Square(a, b, c, d) << endl;
		cout << "perumt: " << Per(a, b, c, d) << endl;
	} return out;
 }

double Trapeze::Square(double a, double b, double c, double d) {
	if (b < a) swap(a, b);
	if (c < d) swap(c, d);
	if((b - a + c + d)*(a - b + c - d)*(a - b - c + d) > 0)
			return ((a + b) / 4 * (b - a))*sqrt((b - a + c + d)*(a - b + c - d)*(a - b - c + d));
	else return 0;
}

double Trapeze::Per(double a, double b, double c, double d) {
	return a + b + c + d;
}