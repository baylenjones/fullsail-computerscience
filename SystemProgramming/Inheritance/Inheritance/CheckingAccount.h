#include "BaseAccount.h"
#include<iostream>

class CheckingAccount : BaseAccount {
	void Withdraw(float amount) {
		BaseAccount::Withdraw(amount);
		if (withdraws < 10) {
			BaseAccount::balance = BaseAccount::balance - 5;
			std::cout << "\nYou have exceeded withdraw limit (10) and charged $5 from your account\n\n";
		}
	}
};