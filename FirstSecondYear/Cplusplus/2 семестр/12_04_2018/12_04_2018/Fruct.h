#pragma once
#include <iostream>
#include <string>
using namespace std;
class Fruct
{
public:
	string name;

	Fruct() : name("X") {};
	Fruct(string _name) {
		name = _name;
	};
	
	void return_name() {
		cout << name;
	}
};

