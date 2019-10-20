#pragma once
#include "Person.h"
class Student :
	public Person
{
	string grup;
	string spec;
public:
	Student() :  grup("nogrup"), spec("nospec") {
		name = "Student_noname";
	};
	Student(string _name, string _grup, string _spec) {
		name = _name;
		grup = _grup;
		spec = _spec;
	};

	void getter() {
		cout << name << " " << grup << " " << spec << endl;
	}

};

