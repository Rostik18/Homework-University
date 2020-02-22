#pragma once
#include "Human.h"
class Batia :
	public Human
{
	int zp;
	int cm;

public:
	Batia() : Human(), zp(0), cm(0) {};
	Batia(string _name, int _age, string _skin, int _zp, bool _remin) : Human(_name, _age, _skin) {
		zp = _zp;
		cm = _remin;
	};

	void set_zp(int _zp) { zp = _zp; }
	void set_cm(int _remin) { cm = _remin; }

	int get_zp() { return zp; }
	int get_cm() { return cm; };

	void set_all(ifstream& in) {
		in >> name;
		in >> age;
		in >> skin;
		in >> zp;
		in >> cm;
	};
	void get_all(ofstream& out) {
		out << name << "\n";
		out << age << "\n";
		out << skin << "\n";
		out << zp << "\n";
		out << cm << "\n";
	};

	//const bool operator > (const Batia& _B1) { return cm > _B1.cm; }

};

