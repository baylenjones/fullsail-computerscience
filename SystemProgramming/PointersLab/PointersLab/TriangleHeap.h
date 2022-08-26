#pragma once
class TriangleHeap
{
private:
	float mBase;
	float mHeight;

public:
	// contruct
	TriangleHeap(float* base, float* height) {
		mBase = (*base);
		mHeight = (*height);
	}
	// Copy construct
	TriangleHeap(const TriangleHeap& source) {
		mBase = source.mBase;
		mHeight = source.mHeight;
		
	}

	// overloaded assignment
	TriangleHeap& operator=(const TriangleHeap& source) {
		if (this == &source) {
			return *this;
		}

		mBase = source.mBase;
		mHeight = source.mHeight;
		return *this;
	}

	//destructor
	~TriangleHeap() {
		// No dynamic memory to delete ?
	}

	

	void Set(float a, float b) {
		mBase = a;
		mHeight = b;
	}

	float GetArea() {
		float area = (mBase * mHeight)/2;
		return area;
	}
};

