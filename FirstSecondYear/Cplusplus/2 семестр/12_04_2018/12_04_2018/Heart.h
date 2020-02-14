#pragma once
class Heart
{
public:
	bool T;
	Heart() : T(true){};

	Heart(bool _T) {
		T = _T;
	};

	bool ret() {
		return T;
	}
};

