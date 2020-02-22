#include "stdafx.h"
//x = '1111'
//y = '2222'
//count = 0
//
//def karatsuba(x, y) :
//	global count
//	if len(str(x)) == 1 or len(str(y)) == 1 :
//		x = int(x)
//		y = int(y)
//		return x * y
//	else:
//x = int(x)
//y = int(y)
//n = int(max(len(str(x)), len(str(y))))
//z = int(n / 2)
//a = int(x / 10  z)
//b = int(x % 10  (z))
//c = int(y / 10  (z))
//d = int(y % 10  (z))
//ac = karatsuba(a, c)
//bd = karatsuba(b, d)
//ad_plus_bc = karatsuba(a + b, c + d) - ac - bd
//prod = ac * 10  (2 * z) + (ad_plus_bc * 10  z) + bd
//if ad_plus_bc == 7:
//count += 1
//return int(prod)
//
//
//print(karatsuba(1111, 2222))
//print("\n")
//print(count)
//
//
//#include <iostream>
//#include <math.h>
//
//using namespace std;
//
//int getLength(long long value); // îòðèìàòè ê-ñòü öèôð ó ÷èñë³
//long long multiplyKaratsuba(long long x, long long y); // ìíîæåííÿ Êàðàöóáè
//
//int main() {
//	long long a = 0;
//	cout << "a = ";
//	cin >> a;
//
//	long long b = 0;
//	cout << "b = ";
//	cin >> b;
//
//	cout << "a * b = " << multiplyKaratsuba(a, b) << endl;
//}
//
//int getLength(long long value) {
//	int counter = 0;
//	while (value != 0) {
//		counter++;
//		value /= 10;
//	}
//	return counter;
//}
//
//long long multiplyKaratsuba(long long x, long long y) {
//	const int xLength = getLength(x);
//	const int yLength = getLength(y);
//
//	long long result = 0;
//
//	// á³ëüøå ÷èñëî
//	int N = (int)(fmax(xLength, yLength));
//
//	// äëÿ ìàëèõ ÷èñåë øâèäøå çä³éñíèòè òðèäèö³éíå ìíîæåííÿ
//	if (N < 10) {
//		result = x * y;
//	}
//	else {
//		// ìàêñèìàëüíó ðîçðÿäí³ñòü ïîä³ëèòè òà çàîêðóãëèòè
//		N = (N / 2) + (N % 2);
//
//		const long long multiplier = pow(10, N);
//
//		const long long b = x / multiplier;
//		const long long a = x - (b * multiplier);
//		const long long d = y / multiplier;
//		const long long c = y - (d * N);
//
//		const long long z0 = multiplyKaratsuba(a, c);
//		const long long z1 = multiplyKaratsuba(a + b, c + d);
//		const long long z2 = multiplyKaratsuba(b, d);
//
//		result = z0 + ((z1 - z0 - z2) * multiplier) + (z2 * (long long)(pow(10, 2 * N)));
//		return result;
//	}
//
//
//	system("pause");
//
//}