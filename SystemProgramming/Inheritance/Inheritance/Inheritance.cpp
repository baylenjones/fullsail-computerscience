#include <iostream>
#include "BaseAccount.h"
#include "CheckingAccount.h"
#include "CreditAccount.h"
#include "SavingsAccount.h"
#include "Helper2.h"
#include <fstream>
#include <string.h>

using namespace std;

void chooseAccount(string menu[]);
void chooseOption(string menu[], CheckingAccount* account);
void chooseOption(string menu[], SavingsAccount* account);
void chooseOption(string menu[], CreditAccount* account);
void fileSave();
void fileOpen();

string accounts[4] = { "1) Checking Account", "2) Savings Account", "3) Credit ", "4) Exit" };
string options[4] = { "1) Withdraw", "2) Deposit", "3) Check Balance", "4) Return" };
float amount;
int selection;
bool escape = false;

CheckingAccount checking;
CheckingAccount* checkingptr = &checking;

SavingsAccount savings;
SavingsAccount* savingsptr = &savings;

CreditAccount credit;
CreditAccount* creditptr = &credit;

int main()
{
	fileOpen();

	while (escape == false) {
		chooseAccount(accounts);
	}
	fileSave();
}

void chooseAccount(string menu[]) {
	for (int x = 0; x < 4; x++) {
		cout << menu[x] << "\n";
	}

	selection = GetValidatedInt("Please Choose an Account: ", 1, 4);
	system("cls");

	switch (selection) {
	case 1:
		cout << "Current Balance for Checking: $" << checking.GetBalance() << "\n\n";
		cout << "What would you like to do in Checking Account:\n";
		chooseOption(options, checkingptr);
		break;
	case 2:
		cout << "Current Balance for Savings: $" << savings.GetBalance() << "\n\n";
		cout << "What would you like to do in Savings Account:\n";
		chooseOption(options, savingsptr);
		break;
	case 3:
		cout << "Current Balance for Credit: $" << credit.GetBalance() << "\n\n";
		cout << "What would you like to do in Credit Account:\n";
		chooseOption(options, creditptr);
		break;
	case 4:
		escape = true;
		break;
	}

}

void chooseOption(string menu[], CheckingAccount* account) {
	for (int x = 0; x < 4; x++) {
		cout << menu[x] << "\n";
	}
	selection = GetValidatedInt("Please Choose: ", 1, 4);
	system("cls");

	switch (selection) {
	case 1:
		amount = GetValidatedFloat("Please Enter an Amount you wish to Withdraw: ", 1, 10000000);
		(*account).Withdraw(amount);
		break;
	case 2:
		amount = GetValidatedFloat("Please Enter an Amount you wish to Deposit: ", 1, 10000000);
		(*account).Deposit(amount);
		break;
	case 3:
		cout << "Your Balance is: " << (*account).GetBalance() << "\n\n";
		break;
	case 4:
		system("cls");
		return;
	}
}

void chooseOption(string menu[], SavingsAccount* account) {
	for (int x = 0; x < 4; x++) {
		cout << menu[x] << "\n";
	}
	selection = GetValidatedInt("Please Choose: ", 1, 4);

	switch (selection) {
	case 1:
		system("cls");
		amount = GetValidatedFloat("Please Enter an Amount you wish to Withdraw: ", 1, 10000000);
		(*account).Withdraw(amount);
		break;
	case 2:
		system("cls");
		amount = GetValidatedFloat("Please Enter an Amount you wish to Deposit: ", 1, 10000000);
		(* account).Deposit(amount);
		break;
	case 3:
		system("cls");
		cout << "Your Balance is: " << (*account).GetBalance() << "\n\n";
		break;
	case 4:
		system("cls");
		return;
	}
}

void chooseOption(string menu[], CreditAccount* account) {
	for (int x = 0; x < 4; x++) {
		cout << menu[x] << "\n";
	}
	selection = GetValidatedInt("Please Choose: ", 1, 4);

	switch (selection) {
	case 1:
		system("cls");
		amount = GetValidatedFloat("Please Enter an Amount you wish to Withdraw: ", 1, 10000000);
		(*account).Withdraw(amount);
		break;
	case 2:
		system("cls");
		amount = GetValidatedFloat("Please Enter an Amount you wish to Deposit: ", 1, 10000000);
		(*account).Deposit(amount);
		break;
	case 3:
		system("cls");
		cout << "Your Balance is: " << (*account).GetBalance() << "\n\n";
		break;
	case 4:
		system("cls");
		return;
	}
}

void fileSave() {
	fstream fout;
	fout.open("accounts.txt", ios_base::out);

	if (fout.is_open()) {
		fout << checking.GetBalance() << endl;
		fout << savings.GetBalance() << endl;
		fout << credit.GetBalance() << endl;

		fout.close();
	}
}

void fileOpen() {
	ifstream fin;
	float a, b, c;
	char x[32];
	char y[32];
	char z[32];
	fin.open("accounts.txt");

	if (fin.is_open()) {
		while (true) {
			fin.getline(x, INT_MAX, '\n');
			if (fin.eof()) break;
			fin >> a;
			checking.SetBalance(a);
			fin.getline(y, INT_MAX, '\n');
			if (fin.eof()) break;
			fin >> b;
			savings.SetBalance(b);
			fin.getline(z, INT_MAX, '\n');
			if (fin.eof()) break;
			fin >> c;
			credit.SetDebt(c);
		}
		// this part will skip lines. idk why, ran out of time.
		
	}
	fin.close();
}