#include "stdafx.h"
//#include <iostream>
//#include <fstream>
//#include <cmath>
//#include <string.h>
//#define RANGE 122
//using namespace std;
//
//int globalCount[RANGE + 1];
//
//void countSort(char **arr, const int n, int d)
//{
//	char output[n][3];
//
//	int count[RANGE + 1], i;
//
//	memset(count, 0, sizeof(count));//заповнюємо нулями count
//
//	for (i = 0; i < n; i++) {
//		int k = arr[i][d];
//		count[k]++;
//		globalCount[k]++;
//	}
//
//	for (i = 97; i <= RANGE; i++) {
//		count[i] += count[i - 1];
//	}
//
//	for (i = n - 1; i >= 0; i--)
//	{
//		int k = arr[i][d];
//		for (int j = 0; j < 3; j++) {
//			output[count[k] - 1][j] = arr[i][j];
//		}
//		count[k]--;
//	}
//	for (i = 0; i < n; ++i) {
//		for (int j = 0; j < 3; j++) {
//			arr[i][j] = output[i][j];
//		}
//	}
//}
//
//void RadixSort(char**arr,const int n) {
//	for (int i = 2; i >= 0; i--) {
//		countSort(arr, n, i);
//		cout << "Перший рядок після " << 3 - i << " ітерації: " << arr[0] << endl;
//	}
//}
//
//char*getParol(char**arr, int n) {
//	char *s = new char[7];
//	int max = globalCount[97], index = 97;
//	for (int i = 98; i <= RANGE; i++) {
//		if (globalCount[i] > max) {
//			max = globalCount[i];
//			index = i;
//		}
//	}
//	for (int i = 0; i < 7; i++) {
//		if (i < 3) {
//			s[i] = arr[0][i];
//		}
//		else if (i > 3) {
//			s[i] = arr[n - 1][i - 4];
//		}
//		else {
//			s[i] = char(index);
//		}
//	}
//	return s;
//}
//
//int main()
//{
//	ifstream in("text");
//	const int n = 1000;
//	char**arr = new char*[n];
//	for (int i = 0; i < n; i++) {
//		arr[i] = new char[3];
//		in >> arr[i];
//	}
//
//	RadixSort(arr, n);
//	cout << "Пароль до лабораторії: " << getParol(arr, n);
//	return 0;
//}
