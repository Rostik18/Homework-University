#include "pch.h"
#include <iostream>
#include <string>

using namespace std;

string* split(string str, int& size) {
	string* Rez = new string[str.length()];
	int index = 0;
	string word = "";
	for (int i = 0; i < str.length(); i++)
	{
		while (true) {
			if (str[i] != ' ') {
				word += str[i];
				i++;
				if (i == str.length()) break; // На останній ітерації індекс вилітає за свої межі. Костиль.
			}
			else break;
		}
		if (word != "") {
			Rez[index] = word;
			index++;
		}
		word = "";
	}
	size = index;
	return Rez;
}

int main()
{
	string str;
	cout << "Enter string: ";
	getline(cin, str);

	int words_count = 0;
	string* words = split(str, words_count);
	char first, last;
	cout << "Enter first char: ";
	cin >> first;
	cout << "Enter last char: ";
	cin >> last;

	for (int i = 0; i < words_count; i++)
	{
		if (words[i][0] == first &&
			words[i][words[i].length() - 1] == last)
			continue;
		cout << words[i] << endl;
	}

	system("pause");
}
