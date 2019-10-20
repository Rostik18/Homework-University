#include "pch.h"
#include "Time.h"

Time::Time(int h, int m, int s) {
	this->h = h;
	this->m = m;
	this->s = s;
	CheckTime();
};

Time::Time(Time& T) {
	this->h = T.h;
	this->m = T.m;
	this->s = T.s;
};

istream& Time::operator >> (istream &in)
{
	do {
		cout << "Enter h:";
		in >> h;
	} while (h < 0 || h> 24);
	do {
		cout << "Enter m:";
		in >> m;
	} while (m < 0 || m> 60);
	do {
		cout << "Enter s:";
		in >> s;
	} while (s < 0 || s> 60);
	cout << endl;
	CheckTime();
	return in;
}
ostream& Time::operator << (ostream &out)
{
	out << "h: " << h << " m: " << m << " s: " << s << endl;
	CheckTime();
	return out;
}

Time& Time::operator+(Time& T) {
	this->h += T.h;
	this->m += T.m;
	this->s += T.s;
	CheckTime();
	return *this;                 //Розіменування вказівника
}                                 //Тобто працюємо із силкою, а повертаємо сам об'єкт.
Time& Time::operator-(Time& T) {
	this->h -= T.h;
	this->m -= T.m;
	this->s -= T.s;
	CheckTime();
	return *this;
}

void Time::CheckTime() {
	int sum = 3600 * h + 60 * m + s; //Весь час в секундах.

	if (sum < 0) {
		h = 0; m = 0; s = 0; return;     //оператор return передчасно завершає роботу функції.
	}

	s = sum % 60;
	sum /= 60;    //Залишить кількість секунд.
	m = sum % 60;
	sum /= 60;
	h = sum % 24;
}
