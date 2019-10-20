#pragma once
class Pair
{
protected:
	
	int a, b;
public:
	
	Pair(int _a, int _b) {
		a = _a; b = _b;
	};

	bool rivnist() {
		return a == b ? true : false;
	}

	int mnojennia() {
		return a * b;
	}

	virtual Pair&  operator-(Pair& _B) {
		a -= b;
		_B.a -= _B.b;
		return *this;
	}

};

