#pragma once
#include "stdafx.h"
#include <iostream>
#include <cmath>

using namespace std;
const double PI = 3.14159265358979;

class Kolo{
	int name;
	double x, y, R, h;
public:
	Kolo();
	Kolo(double x, double y, double R, double h, int name);
	Kolo(Kolo& LoL);
	//----//----//----//
	istream& operator>>(istream& in);
	ostream& operator<<(ostream& out);
	Kolo& operator= (Kolo& K2);
	Kolo& operator== (Kolo& K2);
	//----//----//----//
	void setname(int _name);
	void outputname();
	double S_osn();
	double V_celindr();
	double V_konus();
	double vidstan(Kolo& K2);
	void peretn(Kolo& K1);
};

