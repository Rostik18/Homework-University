//
// Created by igor on 23.11.17.
//
#include <iostream>
#ifndef CLASSES_TRIANGLE_H
#define CLASSES_TRIANGLE_H
using namespace std;

class Triangle {
private:
    double a;
    double b;
    double c;
public:
    double S();
    double P();
    void print(Triangle&);
    Triangle():a(3), b(4), c(5){}
    Triangle(Triangle &);
    Triangle(double, double, double);
};


#endif //CLASSES_TRIANGLE_H
