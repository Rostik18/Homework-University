#pragma once
#include "Figura.h"

class Kolo: public Figura {
	double R;
public:
	Kolo();
	Kolo(double R);
	Kolo(Kolo& LoL);

	istream& operator >>(istream& in);
	ostream& operator<< (ostream& out);
	double Square(double R);
	double Per(double R);
};
////////////////////////////////////////////////////////////////////////////////////////
Kolo::Kolo(){}
Kolo::Kolo(double R){}
Kolo::Kolo(Kolo& LoL) {}

istream& Kolo::operator >>(istream& in) {
	cout << "Enter R: "; cin >> R;
	return in;
}
ostream& Kolo::operator<< (ostream& out) {
	cout << "Square: " << Square(R) << endl;
	cout << "perumt: " << Per(R) << endl; return out;
}

double Kolo::Square(double R) {
	return PI * R*R;
}
double Kolo::Per(double R) {
	return PI * (R + R);
}




