//
// Created by igor on 23.11.17.
//

#include "Triangle.h"
#include <cmath>
Triangle::Triangle(Triangle & T){
    a = T.a;
    b = T.b;
    c = T.c;
}
Triangle::Triangle(double x, double y, double z) {
    if ((abs(x + y) <= z)&&(abs(x+z) <= y)&(abs(y+z) <= x)){
        cout << "Triangle can`t be build";
    }else{
        a = x;
        b = y;
        c = z;
    }
}
double Triangle::S() {
    double p = (a+b+c)/2.0;
    return sqrt(p*(p-a)*(p-b)*(p-c));
}
double Triangle::P(){
    return a + b + c;
}
void Triangle::print(Triangle & T) {
    cout << "Rectangle has sides: a = " << a;
    cout << ", b = " << b << ", c = " << c;
    cout << ". Square = " << T.S() << ". Perimeter = " << T.P() << "\n";
 }