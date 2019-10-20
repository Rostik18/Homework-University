#pragma once
#include "Figura.h"

class Rectangle : public Figura{
	double a, b;
public:
	Rectangle();
	Rectangle(double a, double b);
	Rectangle(Rectangle& LoL);
};
////////////////////////////////////////////////////////////////////////////////////////
Rectangle::Rectangle() {}
Rectangle::Rectangle(double a, double b) {}
Rectangle::Rectangle(Rectangle& LoL){}