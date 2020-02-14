#include <iostream>
#include <queue>
#include <stack>
using namespace std;

class MyInt
{
	int a;
	int index;
public:
	MyInt(int _a, int _i) {
		a = _a;
		index = _i;
	};
	
	void get_a(int _a) {
		a = _a;
	}

	operator int () const  {
		return a;
	}

	bool operator<(const MyInt &P) const {
		return a > P.a;
	}

	ostream& operator<<(ostream & out) {
		out << a << "(" << index << ")";
		return out;
	}
};

class PidPrograma
{
	priority_queue<MyInt> Arr;

	int n;

	void criate_quaue() {
		
		int aa;
		for (int i = 0; i < n; i++) {
			cout << "a[" << i + 1 << "]: ";
			cin >> aa;
			MyInt	a(aa, i);
			Arr.push(a);
		}
	};

public:
	PidPrograma() : n(0) {};
	PidPrograma(int _n) {
		n = _n;
		criate_quaue();
	};
	
	void Out() {
		priority_queue<MyInt> Tmp_queue = Arr;           //запасна п_черга
		stack <MyInt> Tmp_stack;                         //запасний стак

		Tmp_stack.push(Tmp_queue.top());               //заповнення запасного стеку 
		Tmp_queue.pop();
		Tmp_stack.push(Tmp_queue.top());

		int min1 = Arr.top();                           //елемент з 1м пріоритетом
		int min2 = Tmp_queue.top();                    //елемент з 2м пріоритетом 

		if (min1 == min2) {                            //якщо два верхні елементи одинакові, вони виводяться через ЛІФО
			cout << "LIFO out: ";
			cout << Tmp_stack.top() << " ";
			Tmp_stack.pop();
			cout << Tmp_stack.top() << " ";

			Arr.pop();
			Arr.pop();
		}
		else cout << "Standart out: ";

		while (!Arr.empty()) {                         //виводить всі елементи черги
			cout << Arr.top() << " ";
			Arr.pop();
		}
		cout << endl;
	}

};

