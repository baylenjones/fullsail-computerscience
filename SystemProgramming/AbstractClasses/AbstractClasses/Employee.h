#include "Base.h"
class Employee : public Base
{
public:
	Employee();
	void SetSalary(int);
	virtual void DisplayRecord() override;
private:
	int salary;
};