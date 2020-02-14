#pragma once
#include "Section.h"
class Lamana :
	public Section
{
private:
	Point C;
	
public:
	Lamana() {};
	Lamana(int ax, int ay, int bx, int by, int cx, int cy) ;
	Lamana(const Lamana& L);

	void operator() (int ax, int ay, int bx, int by, int cx, int cy);
	Lamana& operator= (const Lamana& S);

	void setCx(int cx);
	void setCy(int cy);
};

