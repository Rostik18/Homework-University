#include "stdafx.h"
#include <iostream>
#include <cstring>
#include <string>
#include <fstream>
using namespace std;
const int n = 3;

class Student {
	string first_name;
	int* points;
//	int n1;
public:
	Student();
	Student(string, int*);
	void getInfo(ifstream&in);
	double SerArf();
	void outInfo();
};

