#include <iostream>
using namespace std;

class Time
{
private:
	int h;
	int m;
	int s;
public:
	Time() :h(0), m(0), s(0) {};
	Time(int h, int m, int s);
	Time(Time& T);
	istream& operator >> (istream &in);
	ostream& operator << (ostream &out);

	Time& operator+(Time& T);
	Time& operator-(Time& T);

	void CheckTime();
};

