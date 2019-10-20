#pragma once
#include "Auto.h"
class Light :
	public Auto
{
	int spead;
	int C_will;
	bool inWork;

public:
	Light() : spead(0), C_will(0), inWork(false) {};
	Light(int _spead, int _C_will, bool _inWork) {
		spead = _spead;
		C_will = _C_will;
		inWork = _inWork;
	};

	void set_spead(int _spead) { spead = _spead; };
	void set_C_will(int _C_Will) { C_will = _C_Will; };
	void set_inWork(bool _inWork) { inWork = _inWork; };

	void pring_inf() {
		cout << "name: " << name << "\nage: " << age << "\nprise: " << prise;
		cout << "\nspead: " << spead << "\nKolis: " << C_will << "\nRobocha: " << inWork << endl;
	}

	istream& operator>>(istream& in) {
		cout << "Enter \nname: ";
		in >> name;
		cout << "age: ";
		in >> age;
		cout << "prise: ";
		in >> prise;
		cout << "spead: ";
		in >> spead;
		cout << "K-ct kolis: ";
		in >> C_will;
		cout << "inWork (1 or 0): ";
		in >> inWork;

		return in;
	};

};

