#pragma once
#include "BaseAccount.h"
#include<iostream>

class CheckingAccount : public BaseAccount {
public:
	CheckingAccount(){};

	void Withdraw(float amount) {
		BaseAccount::Withdraw(amount);
		if (withdraws > 10) {
			balance = balance - 5;
			std::cout << "\nYou have exceeded withdraw limit (10) and charged $5 from your account\n\n";
		}
	}
};