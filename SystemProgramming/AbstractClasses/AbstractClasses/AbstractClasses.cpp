#include <iostream>
#include "Base.h"
#include "Helper.h"
#include<vector>

using namespace std;

int main()
{
	vector<Base*> list;
	string options[4] = { "1) Add a record", "2) Display all records", "3) duplicate a recprd", "4) EXIT" };
	while (true) {
		printOptions(options);
		int selection = GetValidatedInt("Please Choose an option: ", 1, 4);
		system("cls");

		switch (selection) {
		case 1:
			//add record
			break;
		case 2:
			//display
			break;
		case 3:
			//duplicate
			break;
		case 4:
			return 0;
		}
	}
}
