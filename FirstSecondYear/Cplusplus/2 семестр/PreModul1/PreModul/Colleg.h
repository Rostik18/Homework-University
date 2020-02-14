#pragma once
#include "Worker.h"
#include "Student.h"
#include <fstream>

class Colleg
{
	ifstream Colleg_file;

	string Colleg_name;
	string address;
	Worker * arr_W;
	Student * arr_S;
	int n_W, n_S;
public:
	Colleg() : Colleg_name("Golleg_nonem"), address("Noaddress"), n_W(0), n_S(0) {
		arr_W = new Worker[n_W];
		arr_S = new Student[n_S];
	};

	Colleg(string _Colleg_name, string _address, int _n_W, int _n_S) {
		Colleg_name = _Colleg_name;
		address = _address;
		n_W = _n_W;
		n_S = _n_S;
		arr_W = new Worker[n_W];
		arr_S = new Student[n_S];
	};

	Colleg(ifstream & _Colleg_file) {
		Colleg_file = _Colleg_file;				//конструктор для зчитування з файла

	};

};

