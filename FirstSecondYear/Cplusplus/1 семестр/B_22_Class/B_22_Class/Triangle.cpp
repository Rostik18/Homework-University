#include "stdafx.h"
#include "Triangle.h"
#include <cmath>

Triangle::Triangle() {
	 isnyvannia = false;
	 peremictutu = false;
	 zmina = false;
	 rot = false;
	 exet = false;
}

void Triangle::getCoord() {
	cout << "Enter coor:" << endl;
	cout << "Ax: "; cin >> Ax;
	cout << "Ay: "; cin >> Ay;
	//
	cout << "Bx: "; cin >> Bx;
	cout << "By: "; cin >> By;
	//
	cout << "Cx: "; cin >> Cx;
	cout << "Cy: "; cin >> Cy;
}
void Triangle::stvorennia() {
	a = sqrt(pow((Bx - Cx), 2) + pow((By - Cy), 2));
	b = sqrt(pow((Ax - Cx), 2) + pow((Ay - Cy), 2));
	c = sqrt(pow((Bx - Ax), 2) + pow((By - Ay), 2));

	if (((a + b) > c) && ((a + c) > b) && ((b + c) > a)) {
		isnyvannia = true;
		cout << "a: " << a << " b: " << b << " c: " << c << endl;
	}
	else isnyvannia = false;
}
void Triangle::isnye() {
	if (isnyvannia == true)    cout << "isnye!" << endl;
	else    cout << "ne isnye :(" << endl;
}
void Triangle::peremist() {
	if (isnyvannia == true) {
		cout << "Peremistutu? (1 or 0): ";
		cin >> peremictutu;
	}
	if (peremictutu == true) {
		cout << "Enter X: "; cin >> Xp;
		cout << "Enter Y: "; cin >> Yp;
		//
		Ax = Ax + Xp;
		Bx = Bx + Xp;
		Cx = Cx + Xp;
		//
		Ay = Ay + Yp;
		By = By + Yp;
		Cy = Cy + Yp;

		print();
	}
}

void Triangle::print() {
	cout << endl;
	cout << "new coor:" << endl;
	cout << "Ax: " << setw(7) << Ax;
	cout << "  Ay: " << setw(7) << Ay << endl;
	//
	cout << "Bx: " << setw(7) << Bx;
	cout << "  By: " << setw(7) << By << endl;
	//
	cout << "Cx: " << setw(7) << Cx;
	cout << "  Cy: " << setw(7) << Cy << endl;
}
void Triangle::zmina_rozm() {
	if (isnyvannia == true) {
		cout << "Zminutu rozmir? (1 or 0): ";
		cin >> zmina;
	}
	if (zmina == true) {
		cout << "Enter koef_zbil: ";
		cin >> coef_zbil;
		//
		Bx = Bx * coef_zbil;
		By = By * coef_zbil;
		Cx = Cx * coef_zbil;
		Cy = Cy * coef_zbil;
		//
		a = sqrt(pow((Bx - Cx), 2) + pow((By - Cy), 2));
		b = sqrt(pow((Ax - Cx), 2) + pow((Ay - Cy), 2));
		c = sqrt(pow((Bx - Ax), 2) + pow((By - Ay), 2));
		//
		cout << "a: " << a << " b: " << b << " c: " << c << endl;
		//
		print();
	}
}
void Triangle::povorot() {
	if (isnyvannia == true) {
		cout << "Povernytu? (1 or 0): ";
		cin >> rot;
	}
	if (rot == true) {
		cout << "this triangle is quite steep.\n";
	}
}