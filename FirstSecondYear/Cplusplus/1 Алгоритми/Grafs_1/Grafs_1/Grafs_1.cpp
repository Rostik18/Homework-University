#include "stdafx.h"
#include <iostream>
#include <algorithm>
#include <stack>
#include <queue>
#include <fstream>
using namespace std;

void BFS(int**G, int size_G) {
	queue<int> queue;
	int current = 0;

	queue.push(current);
	cout  << current + 1 << " ";

	G[current][current] = -1;
	while (!queue.empty()) {
		current = queue.front();
		//cout << "\nPop: " << current + 1;
		queue.pop();
		for (int i = 0; i < size_G; i++) {
			if (i != current) {
				if (G[current][i] == 1) {
					G[current][i] = 0;
					G[i][current] = 0;
					if (G[i][i] != -1) {
						queue.push(i);
						cout  << i + 1 << " ";
						G[i][i] = -1;
					}
				}
			}
		}
	}
}

int main() {
	int n;
	ifstream in("fin.txt");
	in >> n;
	int**matrix = new int*[n];
	for (int i = 0; i < n; i++) {
		matrix[i] = new int[n];
		for (int j = 0; j < n; j++) {
			in >> matrix[i][j];
		}
	}
	cout << endl << "qeue: ";
	cout << "BFS: " << endl;
	BFS(matrix, n);

	cout << endl;
	system("pause");
	return 0;
}

