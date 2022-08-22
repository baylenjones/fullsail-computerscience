#pragma once
#include "BaseAccount.h"
#include<iostream>

class SavingsAccount : public BaseAccount {
public:

	SavingsAccount(){};

	void Withdraw(float amount) {
		if (withdraws < 4) {
			BaseAccount::Withdraw(amount);
		}
		else { std::cout << "\nError: Too many withdraws on this savings account\n\n"; }
	}
};