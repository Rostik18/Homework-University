#include "stdafx.h"
#include "Section.h"


Section::Section(int ax, int ay, int bx, int by)
{
	A.X = ax;
	A.Y = ay;
	B.X = bx;
	B.Y = by;
	length = calculateLength(A.X, A.Y, B.X, B.Y);
}

Section::Section(const Section& S) {
	A.X = S.A.X;
	A.Y = S.A.Y;
	B.X = S.B.X;
	B.Y = S.B.Y;
	length = S.length;
};


double Section::calculateLength(int x1, int y1, int x2, int y2) {
	return sqrt(pow(x1 - x2, 2) + pow(y1 - y2, 2));
}

double  Section::getLength() {
	return length;
}

void Section::print() {
	cout << "Section length: " << length << endl;
}

void Section::operator() (int ax, int ay, int bx, int by) {
	A.X = ax;
	A.Y = ay;
	B.X = bx;
	B.Y = by;
	length = calculateLength(A.X, A.Y, B.X, B.Y);
};

Section& Section::operator= (const Section& S) {
	this->A.X = S.A.X;
	this->A.Y = S.A.Y;
	this->B.X = S.B.X;
	this->B.Y = S.B.Y;
	this->length = S.length;
	return *this;
};

bool Section::operator< (Section& S) {
	return length < S.length;
}

void Section::setAx(int ax) { A.X = ax; };
void Section::setAy(int ay) { A.Y = ay; };
void Section::setBx(int bx) { B.X = bx; };
void Section::setBy(int by) { B.Y = by; };



