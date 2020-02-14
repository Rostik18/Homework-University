#pragma once
#include "Auto.h"
class Heavi :
	public Auto
{
	int spead;
	int C_will;
	int Want_pid;
public:

	Heavi() : spead(0), C_will(0), Want_pid(0) {};
	Heavi(int _spead, int _C_will, int _Want_pid) {
		spead = _spead;
		C_will = _C_will;
		Want_pid = _Want_pid;
	};

	void set_spead(int _spead) { spead = _spead; };
	void set_C_will(int _C_Will) { C_will = _C_Will; };
	void set_Want_pid(int _Want_pid) { Want_pid = _Want_pid; };

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
		cout << "Wantajo pid: ";
		in >> Want_pid;

		return in;
	};

	void pring_inf() {
		cout << "name: " << name << "\nage: " << age << "\nprise: " << prise;
		cout << "\nspead: " << spead << "\nKolis: " << C_will << "\nWantajo pid: " << Want_pid << endl;
	}
};

