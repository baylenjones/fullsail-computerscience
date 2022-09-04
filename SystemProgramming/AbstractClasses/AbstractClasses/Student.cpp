#include "Student.h"
#include <iostream>
using namespace std;
Student::Student() : Base(), GPA(0) {}

void Student::SetGPA(float s) {
	GPA = s;
}

void Student::DisplayRecord() {
	cout << GetName() << ", " << GPA << endl;
}