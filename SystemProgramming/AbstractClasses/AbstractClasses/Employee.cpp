#include "Employee.h"
#include <iostream>
using namespace std;
Employee::Employee() : Base(), salary(0) {}

void Employee::SetSalary(int s) {
	salary = s;
}

void Employee::DisplayRecord() {
	cout << GetName() << ", " << salary << endl;
}