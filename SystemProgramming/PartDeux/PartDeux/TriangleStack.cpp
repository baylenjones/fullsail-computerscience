#include "TriangleStack.h"

TriangleStack::TriangleStack() : mBase(1), mHeight(1)
{}

float TriangleStack::GetArea() const
{
	return (mBase * mHeight) / 2;
}

void TriangleStack::Set(float a, float b) {
	mBase = a;
	mHeight = b;
}