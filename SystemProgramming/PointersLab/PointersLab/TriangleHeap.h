#pragma once
class TriangleHeap
{
private:
	float mBase;
	float mHeight;

public:
	void Set(float a, float b) {
		mBase = a;
		mHeight = b;
	}

	float GetArea() {
		float area = (mBase * mHeight) / 2;
		return area;
	}
};

