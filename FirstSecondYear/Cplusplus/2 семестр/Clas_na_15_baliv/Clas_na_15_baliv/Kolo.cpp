#include "stdafx.h"
#include "Kolo.h"


Kolo::Kolo() : x(0), y(0), R(0), h(0)  {}
Kolo::Kolo(double x, double y, double R, double h, int name){}
Kolo::Kolo(Kolo& LoL){
	x = LoL.x;
	y = LoL.y;
	R = LoL.R;
	h = LoL.h;
	name = LoL.name;
}
//----//----//----//
istream& Kolo::operator>>(istream& in) {     
	cout << "Enter \nX: ";
	in >> x;
	cout << "Y: ";
	in >> y;
	cout << "Enter Radiys: ";
	in >> R;
	cout << "Enter h: ";
	in >> h;
	return in;
}//перевантаження входу
ostream& Kolo::operator<<(ostream& out) {  
	out << "S_osnovu: " << S_osn() << "\nV_celindra: " << V_celindr() << "\nV_conusa: " << V_konus();
	return out;
}//перевантаження виходу
Kolo& Kolo::operator= (Kolo& K2) {
	x = K2.x;
	y = K2.y;
	R = K2.R;
	h = K2.h;
	name = K2.name;
	return *this;
}
Kolo& Kolo::operator== (Kolo& K2) {
	R == K2.R;
	return *this;
}
//----//----//----//
void Kolo::setname(int _name) {
	name = _name;
}
void Kolo::outputname() {
	cout << name;
}
double Kolo::S_osn() {
	return PI * R *R;
}
double Kolo::V_celindr() {
	return S_osn() * h;
}
double Kolo::V_konus() {
	return V_celindr() / 3;
}
double Kolo::vidstan(Kolo& K2){
	return sqrt(pow(x - K2.x, 2) + pow(y - K2.y, 2));
}
void Kolo::peretn(Kolo& K2) {
	if (vidstan(K2) > (R + K2.R)) cout << 0;
	else if (vidstan(K2) < (R + K2.R)) cout << 2;
	else cout << 1;
}











