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
	system("pause");
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
	system("pause");
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
		color = "Invisible";
		break;
	};

	cout << "Car: " << c.Year << " " << color << " " << c.Make << " " << c.Model << " with " << c.Mileage << " miles\n";
}

void printCarPointer(Car* c) {
	string color;

	switch ((*c).Color) {
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
		color = "Invisible";
		break;
	};

	cout << "Car: " <<  (*c).Year << " " << color << " " << (*c).Make << " " << (*c).Model << " with " << (*c).Mileage << " miles\n";
}

void addMileage(Car* ptrCar, int milestoadd) {
	(*ptrCar).Mileage = (*ptrCar).Mileage + milestoadd;
	cout << "\n\n" << milestoadd << " Miles have been added to mileage. Total Mileage is: " << (*ptrCar).Mileage << "\n\n";
}

void program3() {
	Car cars[3];
	int choice;
	int milestoadd;

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

	cout << "Printing Cars:\n\n";
	printCar(cars[0]);
	printCar(cars[1]);
	printCar(cars[2]);
	cout << "\nPinting Car Pointers:\n\n";
	printCarPointer(&cars[0]);
	printCarPointer(&cars[1]);
	printCarPointer(&cars[2]);
	milestoadd = InputNumber("Please enter miles you need to add: ");
	addMileage(&cars[0], milestoadd);
	system("pause");
}

int main() {
	int selection;
	string options[4] = { "1) Program 1", "2) Program 2", "3) Program 3", "4) Exit"};

	while (true) {
		system("cls");
		for (int i = 0; i < 4; i++) {
			cout << options[i] << endl;
		}
		selection = InputNumber("\nPlease choose a program: ");

		switch (selection) {
		case 1:
			program1();
			break;
		case 2:
			program2();
			break;
		case 3:
			program3();
			break;
		case 4:
			return 0;
		default:
			continue;
		}
	}

	return 0;
}