#pragma once
#include<iostream>
#include "Base.h"
using namespace std;
class Student : Base
{
private:
	float gpa;
public:
	void SetGPA(float a) {
		gpa = a;
	}

	virtual void DisplayRecord() {
		cout << GetName() << "\t" << gpa;
	}
};

