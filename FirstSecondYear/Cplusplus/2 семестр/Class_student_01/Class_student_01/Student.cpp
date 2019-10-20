#include "stdafx.h"
#include "Student.h"

//Student::Student(){}

Student::Student(){
	first_name = "";
	points = new int[n];
}
Student::Student(string name, int * m) {
	first_name = "";
	points = new int[n];
}

 void Student::getInfo(ifstream&in) {
	 in >> first_name;
	 for (int i = 0; i < n; i++) {
		 in >> points[i];
	 }
}

double Student::SerArf() {
	double sum = 0;
	for (int i = 0; i < n; i++) {
		sum += points[i];
	}
	 return sum / n;
 }

 void Student::outInfo() {
	 cout << first_name << ": " << SerArf() << endl;
 }
 
