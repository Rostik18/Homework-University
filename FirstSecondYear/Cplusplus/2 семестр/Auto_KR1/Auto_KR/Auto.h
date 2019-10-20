#pragma once
#include <string>
#include <iostream>
using namespace std;
class Auto
{
protected:
	string name;
	int age;
	int prise;

public:

	Auto() : name(""), age(0), prise(0) {};

	Auto(string _name, int _age, int _prise) {
		name = _name;
		age = _age;
		prise = _prise;
	};

	void set_name(string _name) { name = _name; };
	void set_age(int _age) { age = _age; };
	void set_prise(int _prise) { prise = _prise; };

	virtual istream& operator>>(istream& in){
		return in;
	};

	virtual void pring_inf() {};
};

