#include<iostream>
#include<string>

using namespace std;

enum EnumColorDefinition {
	red = 1,
	white = 2,
	blue = 3
};

struct Car {
	char Make[32];
	char Model[32];
	int Year;
	int Mileage;
	EnumColorDefinition Color;
};

void clearBuffer() {
	cin.clear();
	cin.ignore(INT_MAX, '\n');
}

int InputNumber(string prompt) {

	int number;

	while (true) {
		cout << prompt;
		if (cin >> number) {
			clearBuffer();
			break;
		}
		clearBuffer();
		cout << "\nInvalid Age: Please enter a number: \n";
	}

	return number;
}

void program1() {
	int numbers[15];

	for (int i = 0; i < 15; i++) {
		numbers[i] = rand();
		cout << "Number " << (i+1) << ": " << numbers[i] << "\tAddress: " << &numbers[i] << endl;
	}
}

void printAddress(int num, int* pointer) {
	cout << "Number: " << num << "\tAddress: " << pointer << endl;
}

void program2() {
	int numbers[15];

	for (int i = 0; i < 15; i++) {
		numbers[i] = rand();
		int* pointer = &numbers[i];
		printAddress(numbers[i], pointer);
	}
}

void program3() {
	Car cars[3];
	int choice;
	string color;

	for (int i = 0; i < 3; i++) {
		cout << "Please Enter Make of Vechile #" << (i+1) << ": ";
		cin.getline(cars[i].Make, 32);
		cout << "Please Enter Model of Vechile #" << (i + 1) << ": ";
		cin.getline(cars[i].Model, 32);
		cout << "Please Enter Year of Vechile #" << (i + 1) << ": ";
		cars[i].Year = InputNumber("");
		cout << "Please Enter Mileage of Vechile #" << (i + 1) << ": ";
		cars[i].Mileage = InputNumber("");
		cout << "Please Enter Color of Vechile #" << (i + 1) << "\n1) Red    2) White    3) Blue\n\n::";
		choice = InputNumber("");
		cars[i].Color = (EnumColorDefinition)choice;
		system("cls");
	}

	cout << "Vechiles:\n\n";

	for (int i = 0; i < 3; i++) {
		switch (cars[i].Color) {
		case 1:
			color = "Red";
			break;
		case 2:
			color = "White";
			break;
		case 3:
			color = "Blue";
			break;
		default:
			cout << "Invisible";
			break;
		};

		cout << "Car " << (i + 1) << ": " << cars[i].Year << " " << color << " " << cars[i].Make << " " << cars[i].Model << " with " << cars[i].Mileage << " miles\n";
	}
}

int main() {
	program3();
	return 0;
}