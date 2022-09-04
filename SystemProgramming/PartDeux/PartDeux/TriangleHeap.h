#ifndef TRIANGLEHEAP_H
#define TRIANGLEHEAP_H

class TriangleHeap
{
private:
	float* mBase, * mHeight;

public:
	TriangleHeap();
	TriangleHeap(const TriangleHeap& rhs);
	~TriangleHeap();
	void Set(float a, float b);
	float GetArea() const;
};
#endif

