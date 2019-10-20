#pragma once
class Engin
{
public:
	bool be;

	Engin() : be(true) {};
	Engin(bool _be) {
		be = _be;
	};
	bool tobe() {
		return be;
	}
};

