#include <iostream>
using namespace std;
#include "Triangle.h"

int main() {
    Triangle T;
    Triangle K(1, 2, 3);
    T.print(T);
    K.print(K);
    return 0;
}