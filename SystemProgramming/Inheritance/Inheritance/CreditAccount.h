#include "BaseAccount.h"
#include<iostream>

class CreditAccount : BaseAccount {
	const int spendingLimit = 40;

	private:
		int debt = 0;

	public:
		void withdraw(float amount) {
			if (debt > spendingLimit) {
				std::cout << "\nYou have exceeded the spending limit ($40) and will now be charged $5,000\n\n";
				debt = debt + 5000;
			}
			debt = debt + (int)amount;
		}
};