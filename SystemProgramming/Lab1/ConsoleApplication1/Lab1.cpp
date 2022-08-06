#include <iostream>
#include <string>

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
    cout << "\n\n";
    system("pause");
}

void program3() {
    int a;
    int b;
    int c;
    int resultA;
    int resultB;

    cout << "Please enter 3 numbers\n";
    a = InputNumber("\nPlease enter value for A: ");
    b = InputNumber("\nPlease enter value for B: ");
    c = InputNumber("\nPlease enter value for C: ");

    resultA = (a + 1 * b + 2 - c);
    resultB = ((a + 1) * (b + 2) - c);

    cout << "\n" << a << " + 1 * " << b << " - " << c << " = " << resultA;
    cout << "\n" << "(" << a << " + 1) * (" << b << " + 2) - " << c << " = " << resultB << "\n\n";
    system("pause");
}

void program4() {
    cout << "Table of integral variable type ranges in C++:\n\ntype\trange\n\n-----------------------------------------\n\n";
    cout << "ushort" << "\t\t" << "0 to " << USHRT_MAX << "\n\n";
    cout << "short" << "\t\t" << SHRT_MIN << " to " << SHRT_MAX << "\n\n";
    cout << "int" << "\t\t" << INT_MIN << " to " << INT_MAX  << "\n\n";
    cout << "uint" << "\t\t" << "0 to " << SHRT_MAX  << "\n\n";
    cout << "longlong" << "\t" << LONG_MIN << " to " << LONG_MAX << "\n\n";
    cout << "ulonglong" << "\t" << "0 to " << SHRT_MAX << "\n\n";

    system("pause");
}

void program5() {
    char name[32];

    cout << "Please enter your name: ";
    cin.getline(name, 32);

    cout << "Hello there " << name << ". did you know that tomatoes are scientifically fruits.\nbut declared to be vegtables in the U.S to avoid legal taxation from imports\n\n";
    system("pause");
}

void program6() {
    int age;

    age = InputNumber("How old are you? ");
    
    if (age < 16) {
        cout << "\nIm sorry but you're too young to play this game. Bye!\n\n";
    }
    else { cout << "You're a quarter of a century old!  Your life is slowly slipping away.\n\n"; }

    system("pause");
}

void program7() {
    int num;

    num = InputNumber("Please enter an even number: ");

    if ((num % 2) == 0) {
        cout << "\n\nNice!\n\n";
    }
    else { cout << "\n\nBOO!\n\n"; }

    system("pause");
}

void program8() {
    int div;
    int a;

    div = InputNumber("Please enter a divisor: ");
    for (int i = 0; i < 3; i++) {
        a = rand();

        if ((a % div) == 0) {
            cout << a << "\t-" << "YES!\n\n";
        }
        else {
            cout << a << "\t-" << "NOOO!\n\n";
        }
    }
    system("pause");
}

void program9() {
    int choice;
    choice = InputNumber("what color Popsicle would you like from the freezer ? \n1) Red\n2) Blue\n3) Green\n4) Orange\n\n:: ");

    switch (choice) {
    case 1:
        cout << "\n\nPerfect for the Red White and Blue\n\n";
        break;
    case 2:
        cout << "\n\nYou are so bluuuuuetiful\n\n";
        break;
    case 3:
        cout << "\n\nGreen machine!!!\n\n";
        break;
    case 4:
        cout << "\n\nWar Eagle!\n\n";
        break;
    default:
        cout << "\n\nwell your all out of luck!!\n\n";
    };

    system("pause");
}

void program10() {
    int choice;
    int enemy;
    choice = InputNumber("Please choose a Difficulty level: \n\n1) Easy\n\n2) Medium\n\n3) Hard\n\n :: ");

    switch (choice) {
    case 1:
        enemy = rand() % 25;
        cout << "\n\nYou will fight " << enemy << " Kolbalds!\n\n";
        break;
    case 2:
        enemy = rand() % 50 + 25;
        cout << "\n\nYou will fight " << enemy << " Orcs!!!\n\n";
        break;
    case 3:
        enemy = rand() % 100 + 50;
        cout << "\n\nYou will fight " << enemy << " MindFlayers!!!\n\n";
    default:
        cout << "\n\nYou will fight basic math!!!\n\n";
        break;
    };
    system("pause");
}

int main()
{
    int choice;
    string options[11] = { "1) Program 1", "2) Program 2", "3) Program 3", "4) Program 4", "5) Program 5", "6) Program 6", "7) Program 7", "8) Program 8", "9) Program 9", "10) Program 10", "11) EXIT", };
    while (true) {
        for (int i = 0; i < 11; i++) {
            cout << options[i] << "\n";
        }
        choice = InputNumber("\nPlease choose a program to run: ");

        switch (choice) {
        case 1:
            program1();
            system("cls");
            break;
        case 2:
            program2();
            system("cls");
            break;
        case 3:
            program3();
            system("cls");
            break;
        case 4:
            program4();
            system("cls");
            break;
        case 5:
            program5();
            system("cls");
            break;
        case 6:
            program6();
            system("cls");
            break;
        case 7:
            program7();
            system("cls");
            break;
        case 8:
            program8();
            system("cls");
            break;
        case 9:
            program9();
            system("cls");
            break;
        case 10:
            program10();
            system("cls");
            break;
        case 11:
            return 0;
        };
    }
    return 0;
}

