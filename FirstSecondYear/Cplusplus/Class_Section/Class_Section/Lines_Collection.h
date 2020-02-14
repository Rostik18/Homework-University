#pragma once
#include "Lamana.h"
#include <vector>
#include <fstream>
#include <iomanip>

class Lines_Collection
{
private:
	int sizeSec, sizeLam;
	vector<Section> Arr_Section;
	vector<Lamana> Arr_Lamana;

	Section TmpSection;
	Lamana TmpLamana;

	int ax, ay, bx, by, cx, cy;

public:
	Lines_Collection(ifstream& in) {
		in >> sizeSec;
		in >> sizeLam;
	};
	
	void readSection(ifstream& in) {
		for (int i = 0; i < sizeSec; i++) {
			in >> ax;
			in >> ay;
			in >> bx;
			in >> by;
			TmpSection(ax, ay, bx, by);
			Arr_Section.push_back(TmpSection);
			
		}
	}

	void readLamana(ifstream& in) {
		for (int i = 0; i < sizeLam; i++) {
			in >> ax;
			in >> ay;
			in >> bx;
			in >> by;
			in >> cx;
			in >> cy;
			TmpLamana(ax, ay, bx, by, cx, cy);
			Arr_Lamana.push_back(TmpLamana);
		}
	}

	void printToFile(ofstream& out) {
		for (int i = 0; i < sizeSec; i++) {
			out << "length of Section " << i + 1 << ": " << Arr_Section[i].getLength() << "\n";
		}
		out << "\n";
		for (int i = 0; i < sizeLam; i++) {
			out << "length of Lamana " << i + 1 << ": " << Arr_Lamana[i].getLength() << "\n";
		}
		out << "\n";
	}

	void addSection(int ax, int ay, int bx, int by) {
		TmpSection(ax, ay, bx, by);
		Arr_Section.push_back(TmpSection);
		sizeSec++;
	}

	void addLamana(int ax, int ay, int bx, int by, int cx, int cy) {
		TmpLamana(ax, ay, bx, by, cx, cy);
		Arr_Lamana.push_back(TmpLamana);
		sizeLam++;
	}

	void removeSection(int i) {
		if (i >= 0 && i < sizeSec) {
			swap(Arr_Section[i], Arr_Section[sizeSec - 1]);
			Arr_Section.pop_back();
			sizeSec--;
		}
	}

	void removeLamana(int i) {
		if (i >= 0 && i < sizeLam) {
			swap(Arr_Lamana[i], Arr_Lamana[sizeLam - 1]);
			Arr_Lamana.pop_back();
			sizeLam--;
		}
	}

};

