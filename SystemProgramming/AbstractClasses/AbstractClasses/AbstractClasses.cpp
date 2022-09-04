#include "Base.h"
#include "Employee.h"
#include "Student.h"
#include <vector>
#include <string>
#include <iostream>
using namespace std;

void AddRecord(vector<Base*>& v);
void DisplayRecords(vector<Base*>& v);
void DuplicateRecord(vector<Base*>& v);

int main()
{
	vector<Base*> vec;

	bool running = true;
	while (running) {
		cout << "1) to add a record\n2) to display all records\n3) to duplicate a record\n4) EXIT\nChoice:  ";
		int choice;
		cin >> choice;
		system("cls");
		switch (choice) {
		case 1: AddRecord(vec); break;
		case 2: DisplayRecords(vec); system("pause"); break;
		case 3: DuplicateRecord(vec); break;
		case 4: running = false; break;
		default: cout << "\nInvalid input. Please try again." << endl; break;
		}
		system("cls");
	}

	for (Base* p : vec) {
		delete p;
	}

	return 0;
}

void AddRecord(vector<Base*>& v) {
	cout << "\nEnter the type of record you want to add (employee or student): ";
	string type;
	cin >> type;

	if (type == "employee" || type == "Employee") {
		Employee* e = new Employee();

		cout << "Enter name: ";
		string name;
		cin >> name;
		e->SetName(name.c_str());

		cout << "Enter salary: ";
		int salary;
		cin >> salary;
		e->SetSalary(salary);

		v.push_back(e);
	}
	else if (type == "student" || type == "Student") {
		Student* s = new Student();

		cout << "Enter name: ";
		string name;
		cin >> name;
		s->SetName(name.c_str());

		cout << "Enter GPA: ";
		float GPA;
		cin >> GPA;
		s->SetGPA(GPA);

		v.push_back(s);
	}
	else {
		cout << "\nInvalid input. Please try again." << endl;
	}
}

void DisplayRecords(vector<Base*>& v) {
	for (Base* p : v) {
		p->DisplayRecord();
	}
}

void DuplicateRecord(vector<Base*>& v) {
	cout << "\nEnter the index of the record you want to duplicate: ";
	int i;
	cin >> i;

	if (i < 0 || i >= v.size()) {
		cout << "\nIndex out of bounds." << endl;
		return;
	}

	Employee* e = dynamic_cast<Employee*>(v[i]);
	Student* s = dynamic_cast<Student*>(v[i]);

	if (e != nullptr) {
		Employee* newE = new Employee(*e);
		v.push_back(newE);
	}
	else if (s != nullptr) {
		Student* newS = new Student(*s);
		v.push_back(newS);
	}
	else {
		cout << "\nUnknown cast error." << endl;
	}
}