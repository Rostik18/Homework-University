#include "stdafx.h"
#include "Inreger.h"
#include "Real.h"

int main()
{
	int a, b;
	cout << "Enter Int a, b: ";
	cin >> a >> b;

	Inreger A(a, b);

	cout << "division: " << A.division() << endl;
	cout << "multiplication: " << A.multiplication() << endl;
	cout << "subtraction: " << A.subtraction() << endl;
	cout << "sum: " << A.sum() << endl;

	double c, d;
	cout << "Enter Real a, b: ";
	cin >> c >> d;

	Real B(c, d);

	cout << "division: " << B.division() << endl;
	cout << "multiplication: " << B.multiplication() << endl;
	cout << "subtraction: " << B.subtraction() << endl;
	cout << "sum: " << B.sum() << endl;


	system("pause");
	return 0;
}

