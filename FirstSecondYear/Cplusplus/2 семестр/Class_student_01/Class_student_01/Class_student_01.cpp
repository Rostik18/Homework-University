#include "stdafx.h"
#include <iostream>
#include <cstring>
#include <string>
#include <fstream>
#include "Student.h"
using namespace std;

int main(){
	ifstream in("Text.txt");
	int n = 4;
	Student* S = new Student[n];

	cout << "rez: " << endl;
	for (int i = 0; i < n; i++) {
		S[i].getInfo(in);
		S[i].SerArf();
		S[i].outInfo();
	}



	system("pause");
    return 0;
}

