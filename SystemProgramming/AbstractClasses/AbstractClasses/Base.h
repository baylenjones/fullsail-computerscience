#pragma once
#include <string>
using namespace std;
class Base
{
public:
	Base();
	virtual ~Base();
	void SetName(const char*);
	char* GetName() const;
	virtual void DisplayRecord() = 0;
	Base& operator=(const Base&);
private:
	char* name;
};