#pragma once
#include "BaseAccount.h"
#include<iostream>

class CreditAccount : public BaseAccount {
	const int spendingLimit = 40;

	private:
		int debt = 5;
	public:
		CreditAccount(){};

		void Withdraw(float amount) {
			debt = debt + (int)amount;
			if (debt > spendingLimit) {
				std::cout << "\nYou have exceeded the spending limit of (" << spendingLimit << ") and will now be charged $5,000\n\n";
				system("pause");
				debt = debt + 5000;
			}
		}

		void SetDebt(float num) {
			debt = num;
		}
		float GetBalance() {
			return (float)debt;
		}
};