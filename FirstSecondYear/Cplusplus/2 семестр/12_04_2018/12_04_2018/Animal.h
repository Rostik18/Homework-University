#pragma once
#include <iostream>
#include "Fruct.h"
#include <string>
using namespace std;

class Animal
{
public:
	string name;
	Fruct fruct;
	Animal() : name("Animal_name") {};
	Animal(string _name) {
		name = _name;
	};

	void eat_fruct() {
		cout << "Animal: " << name << " eat: "; fruct.return_name();
	}

};

