#include <iostream>
#include <vector>
#include "TriangleHeap.h"
#include "TriangleStack.h"
using namespace std;

void SwapValues(int* a, int* b);
int AddNumbersReturnInt(int* a, int* b);
void AddNumbersReturnVoid(int a, int b, int* sum);

int main()
{
    float a = 5;
    float b = 10;
    float c = 15;
    float d = 20;
    float sum;
    float* Aptr = &a;
    float* Bptr = &b;
    float* Cptr = &c;
    float* Dptr = &d;
    float* sumPtr = &sum;

    TriangleStack tri1;
    TriangleStack tri2;
    TriangleHeap Tri1;
    TriangleHeap Tri2;

    tri1.Set(Aptr, Bptr);
    tri2.Set(Cptr, Dptr);
    Tri1.Set(a, b);
    Tri2.Set(c, d);

    vector<TriangleStack> listStack;
    vector<TriangleHeap> ListHeap;
    listStack.push_back(tri1);
    listStack.push_back(tri2);
    ListHeap.push_back(Tri1);
    ListHeap.push_back(Tri2);

    for (TriangleStack x : listStack) {
        cout << x.GetArea() << endl;
    }

    for (TriangleHeap x : ListHeap) {
        cout << x.GetArea() << endl;
    }
    system("pause");
}

int AddNumbersReturnInt(int* a, int* b) {
    int sum = (*a) + (*b);
    return sum;
}

void AddNumbersReturnVoid(int a, int b, int* sum) {
    (*sum) = a + b;
}

void SwapValues(int* a, int* b) {
    int temp = (*a);
    (*a) = (*b);
    (*b) = temp;
}