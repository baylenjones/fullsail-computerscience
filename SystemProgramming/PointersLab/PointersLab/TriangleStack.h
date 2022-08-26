#pragma once
class TriangleStack
{
private:
	float mBase;
	float mHeight;

public:
	TriangleStack(float base, float height) {
		mBase = base;
		mHeight = height;
	}
	void Set(float a, float b) {
		mBase = a;
		mHeight = b;
	}

	float GetArea() {
		float area = (mBase * mHeight) / 2;
		return area;
	}
};

