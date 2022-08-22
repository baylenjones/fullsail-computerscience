#pragma once
class BaseAccount {

	protected:
		float balance = 0.0;
		int withdraws = 0;
	
	public:
		
		void Withdraw(float amount) {
			balance = balance - amount;
			withdraws++;
		}

		void Deposit(float amount) {
			balance = balance + amount;
		}

		float GetBalance() {
			return balance;
		}

		void SetBalance(float amount) {
			balance = amount;
		}

};
