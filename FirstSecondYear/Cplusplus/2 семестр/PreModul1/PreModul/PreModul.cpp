#include "stdafx.h"
#include <iostream>
#include <fstream>
#include "Worker.h"
#include "Student.h"
#include "Colleg.h"

using namespace std;

const int n = 3;

int main()
{
	Colleg* arr_Colleg = new Colleg[n];

	ifstream Colleg_file("Colleg_file1");

	Colleg A(Colleg_file);

	system("pause");
    return 0;
}

