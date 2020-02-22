#pragma once
#include <iostream>
#include <string>

using namespace std;

class Person
{
protected:
	string name;
public:

	/*Person() : name("Noname") {};

	Person(string _name) {
		name = _name;
	};*/

	virtual void getter() = 0;
};

