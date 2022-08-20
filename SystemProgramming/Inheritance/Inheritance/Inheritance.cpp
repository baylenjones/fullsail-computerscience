#include <iostream>
#include "BaseAccount.h"
#include "CheckingAccount.h"
#include "CreditAccount.h"
#include "SavingsAccount.h"
#include "Helper2.h"

using namespace std;

void menu(string menu[]);

int main()
{
	CheckingAccount checking;
	SavingsAccount savings;
	CreditAccount credit;

	string accounts[4] = { "1) Checking Account", "2) Savings Account", "3) Credit ", "4) Exit" };
	string options[4] = { "1) Withdraw", "2) Deposit", "3) Check Balance", "4) Exit" };
	menu(options);
	int selection = GetValidatedInt("Please Choose an option: ", 1, 4);

	switch (selection) {
	case 1:
		cout << "fix me tomorrow";
		break;
	}

}

void menu(string menu[]) {
	for (int x = 0; x < 4; x++) {
		cout << menu[x] << "\n";
	}
}