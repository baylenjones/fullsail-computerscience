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

void repaintCar(Car* ptrCar, EnumColorDefinition newcolor) {
	ptrCar->Color = newcolor;
}

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

void printCar(Car c) {
	string color;

	switch (c.Color) {
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

	cout << "Car: " << c.Year << " " << color << " " << c.Make << " " << c.Model << " with " << c.Mileage << " miles\n";
}

void printCarPointer(Car* c) {
	string color;

	switch (c.Color) {
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

	cout << "Car: " << c.Year << " " << color << " " << c.Make << " " << c.Model << " with " << c.Mileage << " miles\n";
}

void program3() {
	Car cars[3];
	int choice;

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

	Car* pointers[3];
	pointers[0] = &cars[0];
	pointers[1] = &cars[1];
	pointers[2] = &cars[2];

	cout << "Printing Cars:\n\n";
	printCar(cars[0]);
	printCar(cars[1]);
	printCar(cars[2]);
	cout << "\nPinting Car Pointers:\n\n";
	printCarPointer(pointers[0]);
	printCarPointer(pointers[1]);
	printCarPointer(pointers[2]);
}

int main() {
	program3();
	return 0;
}