#include <iostream>
#include <vector>
#include "TriangleHeap.h"
#include "TriangleStack.h"
using namespace std;

void SwapValues(int* a, int* b);
int AddNumbersReturnInt(int* a, int* b);
void AddNumbersReturnVoid(int a, int b, int* sum);

void program1()
{
	int a = 10, b = 5, sum;

	cout << "AddNumbersReturnInt: " << AddNumbersReturnInt(&a, &b) << endl;
	AddNumbersReturnVoid(a, b, &sum);
	cout << "AddNumbersReturnVoid: " << sum << "\n" << endl;

	cout << "Before Swap:" << endl;
	cout << "a = " << a << ", b = " << b << endl;
	SwapValues(&a, &b);
	cout << "After Swap:" << endl;
	cout << "a = " << a << ", b = " << b << "\n" << endl;
}

void program2()
{
	cout << "TriangleStack:" << endl;
	vector<TriangleStack> trStack;

	TriangleStack ts1, ts2;

	ts1.Set(1.1,2.2);

	ts2.Set(3.3,4.4);


	trStack.push_back(ts1);
	trStack.push_back(ts2);


	for (size_t i = 0; i < trStack.size(); i++)
		cout << "Area: " << trStack[i].GetArea() << endl;

	cout << endl << "TriangleHeap:" << endl;
	vector<TriangleHeap> trHeap;

	TriangleHeap th1;


	th1.Set(5.5, 6.6);


	TriangleHeap th2(th1);


	trHeap.push_back(th1);
	trHeap.push_back(th2);


	for (size_t i = 0; i < trHeap.size(); i++)
		cout << "Area: " << trHeap[i].GetArea() << endl;
}

string options[2]{ "1. program 1", "2. program 2" };

int main()
{
	int Choice;
	do
	{


		cout << endl
			<< " 1 - Program 1.\n"
			<< " 2 - Program 2.\n"
			<< " 3 - Exit.\n"
			<< " Enter your choice and press return: ";
		cin >> Choice;
		system("cls");

		switch (Choice)
		{
		case 1:
			program1();
			break;
		case 2:
			program2();
			break;
		case 3:
			cout << "End of Program.\n";
			break;
		default:
			cout << "Not a Valid Choice. \n"
				<< "Choose again.\n";
			break;
		}

	} while (Choice != 3);
	return 0;
}

int AddNumbersReturnInt(int* a, int* b) {
	return *a + *b;
}

void AddNumbersReturnVoid(int a, int b, int* sum) {
	*sum = a + b;
}


void SwapValues(int* a, int* b) {
	int temp = *a;
	*a = *b;
	*b = temp;
}
