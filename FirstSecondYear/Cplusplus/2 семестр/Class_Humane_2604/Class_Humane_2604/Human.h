#pragma once
#include <iostream>
#include <string>

using namespace std;

class Human
{
protected:
	string name;
	int age;
	string skin;

public:
	Human() : name(""), age(0), skin("") {};
	Human(string _name, int _age, string _skin) {
		name = _name;
		age = _age;
		skin = _skin;
	};
	void set_name(string _name) { name = _name; };
	void set_age(int _age) { age = _age; };
	void set_skin(string _skin) { skin = _skin; };
	virtual void set_zp(int _zp) {};
	virtual void set_cm(int _remin) {};
	virtual void set_zybu(int _remin) {};
	virtual void set_home(bool _remin) {};

	string get_name() { return name; };
	int get_age() { return age; };
	string get_skin() { return skin; };
	virtual int get_zp() { return 1; }
	virtual int get_cm() { return 2; };
	virtual int get_zybu() { return 1; }
	virtual int get_home() { return 1; };

	virtual void set_all(ifstream& in) {};
	virtual void get_all(ofstream& out) {};


	//virtual const bool& operator>(const Batia& _B1){ return 1; };
};

