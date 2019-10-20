#pragma once
#include <iostream>
#include <string>
#include "Heart.h"
using namespace std;


class AnimalHeart
{
public:
	Heart A;
	bool T;
	AnimalHeart(Heart _A, bool _T) {
		A = _A;
		T = _T;
		if (A.ret() && T) cout << "Alive!";
		else cout << "Dead";
	};



};

