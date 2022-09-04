#ifndef TRIANGLESTACK_H
#define TRIANGLESTACK_H

class TriangleStack
{
private:
	float mBase;
	float mHeight;

public:
	TriangleStack();
	void Set(float a, float b);
	float GetArea() const;
};

#endif 
