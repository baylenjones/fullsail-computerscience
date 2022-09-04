#include "Base.h"
#include <iostream>
#include <string>
#include <cstring>
using namespace std;
Base::Base() : name(nullptr) {}

Base::~Base() {
	delete[] name;
}

void Base::SetName(const char* n) {
	if (name != nullptr) {
		delete[] name;
		name = nullptr;
	}

	int length = strlen(n) + 1;
	name = new char[length];
	strcpy_s(name, length, n);
}

char* Base::GetName() const {
	return name;
}

void Base::DisplayRecord() {
}

Base& Base::operator=(const Base& rhs) {
	if (this == &rhs) return *this;

	SetName(rhs.GetName());
	return *this;
}