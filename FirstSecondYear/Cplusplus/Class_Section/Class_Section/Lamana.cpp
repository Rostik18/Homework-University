#include "stdafx.h"
#include "Lamana.h"


Lamana::Lamana(int ax, int ay, int bx, int by, int cx, int cy) : Section(ax, ay, bx, by)
{
	C.X = cx;
	C.Y = cy;
	length = calculateLength(A.X, A.Y, B.X, B.Y) +
			 calculateLength(B.X, B.Y, C.X, C.Y);
}

Lamana::Lamana(const Lamana& L) {
	A.X = L.A.X;
	A.Y = L.A.Y;
	B.X = L.B.X;
	B.Y = L.B.Y;
	C.X = L.C.X;
	C.Y = L.C.Y;
	length = L.length;
}


void Lamana::operator() (int ax, int ay, int bx, int by, int cx, int cy) {
	A.X = ax;
	A.Y = ay;
	B.X = bx;
	B.Y = by;
	C.X = cx;
	C.Y = cy;
	length = calculateLength(A.X, A.Y, B.X, B.Y) +
		calculateLength(B.X, B.Y, C.X, C.Y);
};

Lamana&  Lamana::operator= (const  Lamana& S) {
	this->A.X = S.A.X;
	this->A.Y = S.A.Y;
	this->B.X = S.B.X;
	this->B.Y = S.B.Y;
	this->C.X = S.C.X;
	this->C.Y = S.C.Y;
	this->length = S.length;
	return *this;
};

void Lamana::setCx(int cx) { C.X = cx; };
void Lamana::setCy(int cy) { C.Y = cy; };

