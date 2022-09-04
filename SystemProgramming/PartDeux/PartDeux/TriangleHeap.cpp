#include <iostream>
#include "TriangleHeap.h"

using namespace std;

TriangleHeap::TriangleHeap()
{
	mBase = new float;
	mHeight = new float;
	*mBase = 1;
	*mHeight = 1;
}

TriangleHeap::TriangleHeap(const TriangleHeap& rhs)
{
	mBase = new float;
	mHeight = new float;
	*mBase = *(rhs.mBase);
	*mHeight = *(rhs.mHeight);
}

TriangleHeap::~TriangleHeap()
{
	delete mBase;
	delete mHeight;
}

float TriangleHeap::GetArea() const
{
	return ((*mBase) * (*mHeight)) / 2;
}
void TriangleHeap::Set(float a, float b) {
	*mBase = a;
	*mHeight = b;
}