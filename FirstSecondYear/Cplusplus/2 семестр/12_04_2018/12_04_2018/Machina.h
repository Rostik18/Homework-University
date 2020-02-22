#pragma once
#include "Engin.h"
#include <iostream>
#include <string>
using namespace std;

class Machina
{
public:
	string name;
	Engin engine;

	Machina() : name("BMW") {
		if (engine.tobe()) 
			cout << name << " is work!";
		else 
			cout << name << " is NO work!";
	};

	Machina(Engin _engin) : name ("Machine"){
		engine = _engin;
		if (engine.tobe())
			cout << name << " is work!";
		else
			cout << name << " is NO work!";
	};
};

