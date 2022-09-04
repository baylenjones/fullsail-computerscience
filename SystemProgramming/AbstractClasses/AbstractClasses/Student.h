#include "Base.h"
class Student : public Base
{
public:
	Student();
	void SetGPA(float);
	virtual void DisplayRecord() override;
private:
	float GPA;
};