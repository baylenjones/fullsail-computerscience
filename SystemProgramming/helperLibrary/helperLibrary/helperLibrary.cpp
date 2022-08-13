#include <iostream>
#include "Helper.h"

using namespace Helper;

int main()
{
    string options[3] = { "1) testing", "2) to make sure this", "3) works the way I intended" };
    // GetValidatedInt("Please enter a number: ", 0, 5);
    printOptions(options);
    system("pause");
}
