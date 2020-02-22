#pragma once
#include "Human.h"
class Child :
	public Human
{
	int zybu;
	bool home;
public:
	Child() : Human(), zybu(0), home(false) {};

	Child(string _name, int _age, string _skin, int _zybu, bool _home) : Human(_name, _age, _skin) {
		zybu = _zybu;
		home = _home;
	};

	void set_zybu(int _remin) { zybu = _remin; }
	void set_home(bool _remin) { home = _remin; }

	int get_zybu() { return zybu; }
	int get_home() { return int(home); };

	void set_all(ifstream& in) {
		in >> name;
		in >> age;
		in >> skin;
		in >> zybu;
		in >> home;
	};
	void get_all(ofstream& out) {
		out << name << "\n";
		out << age << "\n";
		out << skin << "\n";
		out << zybu << "\n";
		out << home << "\n";
	};
};

