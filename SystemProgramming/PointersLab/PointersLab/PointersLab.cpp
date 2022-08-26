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

    TriangleHeap tri1(Aptr, Bptr);
    TriangleHeap tri2(Cptr, Dptr);
    TriangleStack Tri1(a, b);
    TriangleStack Tri2(d, c);

    vector<TriangleHeap> listHeap;
    vector<TriangleStack> ListStack;
    listHeap.push_back(tri1);
    listHeap.push_back(tri2);
    ListStack.push_back(Tri1);
    ListStack.push_back(Tri2);

    for (TriangleHeap x : listHeap) {
        cout << x.GetArea() << endl;
    }

    for (TriangleStack x : ListStack) {
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