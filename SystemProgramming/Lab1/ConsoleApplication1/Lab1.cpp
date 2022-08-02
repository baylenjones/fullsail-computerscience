#include <iostream>
using namespace std;

void clearBuffer() {
    cin.clear();
    cin.ignore(INT_MAX, '\n');
}
int InputNumber(string prompt) {

    int number;

    while (true) {
        cout << prompt;
        if (cin >> number) {
            clearBuffer();
            break;
        }
        clearBuffer();
        cout << "\nInvalid Age: Please enter a number: \n";
    }

    return number;
}

void program1() {

    char userInitials[32];
    int age;

    cout << "Please enter your initials: ";
    cin >> userInitials;
    clearBuffer();
    age = InputNumber("Please enter your age: ");
    age = age * 365;
    cout << userInitials << ", did you know you're at least " << age << " days old?\n\n";
    system("pause");
}

void program2() {
    int numbers[5];
    for (int x = 0; x < 5; x++) {
        numbers[x] = InputNumber("Please enter a number: ");
    }
    cout << "\nYou entered: ";
    for (int i = 0; i < 5; i++) {
        cout << numbers[i];
    }
}

int main()
{
    program2();
    return 0;
}

