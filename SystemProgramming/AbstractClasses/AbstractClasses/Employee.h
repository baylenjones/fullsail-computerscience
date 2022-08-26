#pragma once
#include<iostream>
#include "Base.h"
using namespace std;

class Employee : Base
{
private:
	int salary;

public:
	void SetSalary(int a) {
		salary = a;
	}

	virtual void DisplayRecord() {
		cout << GetName() << "\t" << salary;
	}
};

