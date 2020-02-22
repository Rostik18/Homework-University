#include "stdafx.h"
#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int q = 1;
	do {
		int A[100];
	 int n, s=0, M=0, k=0;
	

			cout << "Enter n (A[n]): ";
			cin >> n;

			for (int i = 0; i < n; i++) {
				cout << "Enter A[" << i << "]";
				cin >> A[i];
				
				M = M + A[i];
			}	
			s = M / n;
		
			cout << "ser arf: " << s << endl;

			for (int i = 0; i < n; i++) {
				if (A[i] > s) {
					cout << A[i] << endl;
				 }
				
			}

		cout << "    1 or 0 to Exet: ";
		cin >> q;
	} while (q == 1);


    return 0;
}

