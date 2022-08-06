#include <iostream>

using namespace std;

unsigned int bitField = 155;

void print(unsigned int number, int size) {
    char* text = new char[size + 1];

    text[size] = '\0';

    for (int i = size - 1; i >= 0; i--) {
        if (number % 2 == 0) {
            text[i] = '0';
        }
        else { text[i] = '1'; }

        number = number / 2;
    }

    cout << "Bits: " << text << "\n\n";
    delete[] text;
}
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

void TurnOn(int index) {
    bitField = bitField | (1 << index);
}

void TurnOff(int index) {
    bitField = bitField & ~(1 << index);
}

void Toggle(int index) {
    bitField = bitField ^ (1 << index);
}

void Negate() {
    bitField = ~bitField;
}

void LeftShift() {
    bitField = bitField << 1;
}

void RightShift() {
    bitField = bitField >> 1;
}
int main()
{
    string options1[7] = {
        "1) Turn On",
        "2) Turn Off",
        "3) Toggle",
        "4) Negate",
        "5) Left Shift",
        "6) Right Shift",
        "7) exit",
    };

    int operation;
    int index;

    while (true) {
        system("cls");
        cout << "bitField: " << bitField << "\n\n";
        print(bitField, 32);

        for (int i = 0; i < 7; i++) {
            cout << options1[i] << endl;
        }

        operation = InputNumber("\nPlease Choose an opertation: ");

        switch (operation) {
        case 1:
            index = InputNumber("\nPlease Choose an Index number 1 - 32: ") - 1;
            TurnOn(index);
            break;
        case 2:
            index = InputNumber("\nPlease Choose an Index number 1 - 32: ") - 1;
            TurnOff(index);
            break;
        case 3:
            index = InputNumber("\nPlease Choose an Index number 1 - 32: ") - 1;
            Toggle(index);
            break;
        case 4:
            Negate();
            break;
        case 5:
            LeftShift();
            break;
        case 6:
            RightShift();
            break;
        case 7:
            return 0;
        default:
            cout << "invalid operations" << endl;
            break;
        }
    }
    return 0;
}