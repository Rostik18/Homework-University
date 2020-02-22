#include <iostream>
#include <math.h>
#include <iomanip>
#include <cmath> 
#define PI 3.14159265
using namespace std;

class Triangle {
private:
	double a, b, c, Ax, Ay, Bx, By, Cx, Cy, coef_zbil;
	double  Xp, Yp;   //переміщення
	bool isnyvannia;
	bool peremictutu;
	bool zmina;
	bool rot;
	bool exet;
public:
	Triangle();

	void getCoord();
	void stvorennia();
	void isnye();
	void peremist();

	void print();

	void zmina_rozm();
	void povorot();
};