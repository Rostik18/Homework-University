#include "stdafx.h"
#include <iostream>
#include <cstdio>
#include <stdio.h>
#include <cstring>
using namespace std;

int main(){
		char ryadok[200];
		bool found;
		int kil = 1;
		cout << "Enter radok: \n";
        gets_s(ryadok);
			for (int i = 0; i < strlen(ryadok) - 1; i++) {
				if (ryadok[i] == ' ' && ryadok[i + 1] != ' ') {
					kil++;
				}
			}
			int q;
			cout << "Sliw: " << kil;
			cin >> q;
return 0;
}