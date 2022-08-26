#pragma once
#include <stdio.h>
#include <string.h>
class Base
{
	Base(){}
	Base(const Base& source) {
		name = source.name;
	}
	Base& operator=(const Base& source) {
		name = source.name;
		return *this;
	}
	~Base() {
		delete[] name;
	}

private:
	char* name = nullptr;

public:
	void SetName(char const* const _name) {
		delete[] name;
		int len = strlen(_name) + 1;
		name = new char[len];

		strcpy_s(name, len, _name);
	}

	char* GetName() {
		return name;
	}

	virtual void DisplayRecord() = 0;
};

