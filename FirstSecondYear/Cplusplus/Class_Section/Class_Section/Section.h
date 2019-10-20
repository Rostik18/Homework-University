#pragma once
#include <iostream>
#include <cmath>

using namespace std;

class Point {
public:
	int X, Y;
};

class Section
{
protected:
	Point A, B;
	double length;

	double calculateLength(int x1, int y1, int x2, int y2);
public:
	Section() {};
	Section(int ax, int ay, int bx, int by);
	Section(const Section& S);

	double getLength();

	void print();

	void operator() (int ax, int ay, int bx, int by);
	Section& operator= (const Section& S);
	bool operator< (Section& S);

	void setAx(int ax);
	void setAy(int ay);
	void setBx(int bx);
	void setBy(int by);
};

