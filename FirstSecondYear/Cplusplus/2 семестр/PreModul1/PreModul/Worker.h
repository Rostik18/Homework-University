#pragma once
#include "Person.h"

class Worker :
	public Person
{
	string post;
	int zp;
public:
	
	Worker() : post("Nopost"), zp(0) {
		name = "Worker_noname";
	};

	Worker(string  _name, string _post, int _zp) {
		name = _name;
		post = _post;
		zp = _zp;
	};

	void getter() {
		cout << name << " " << post <<" "<< zp << endl;
	}
};

