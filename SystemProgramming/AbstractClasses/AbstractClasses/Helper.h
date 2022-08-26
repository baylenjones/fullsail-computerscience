#pragma once
#include<iostream>

using namespace std;

int GetValidatedInt(const char* strMessage, int nMinimumRange = 0, int nMaximumRange = 0) {
	int num;
	while (true) {
		cout << strMessage;
		if (cin >> num) {
			cin.clear();
			cin.ignore(INT_MAX, '\n');
			if (num < nMinimumRange || num > nMaximumRange) {
				cout << "Error: Please enter a number between " << nMinimumRange << " and " << nMaximumRange << endl;
				continue;
			}
			break;
		}
		cin.clear();
		cin.ignore(INT_MAX, '\n');
		cout << "\nError: Please enter a number: \n";
	}
	return num;
}

float GetValidatedFloat(const char* strMessage, float nMinimumRange = 0, float nMaximumRange = 0) {
	float num;
	while (true) {
		cout << strMessage;
		if (cin >> num) {
			cin.clear();
			cin.ignore(INT_MAX, '\n');
			if (num < nMinimumRange || num > nMaximumRange) {
				cout << "Error: Please enter a number between " << nMinimumRange << " and " << nMaximumRange << endl;
				continue;
			}
			break;
		}
		cin.clear();
		cin.ignore(INT_MAX, '\n');
		cout << "\nError: Please enter a number: \n";
	}
	return num;
}

void clearBuffer() {
	cin.clear();
	cin.ignore(INT_MAX, '\n');
}

void printOptions(string options[]) {
	int len = sizeof(options);
	for (int i = 0; i < len; i++) {
		cout << options[i] << endl;
	}
	cout << "Please choose an option: ";
}
