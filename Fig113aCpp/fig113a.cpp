#include <iostream>

using namespace std;

int main()
{
    int w, x, y, z;
    int i = 4;
    int j = 5;
    {
        int j = 7;
        i = 6;
        w = i + j;
    }
    x = i + j;
    {
        int i = 8;
        y = i + j;
    }
    z = i + j;

    cout << w << endl;
    cout << x << endl;
    cout << y << endl;
    cout << z << endl;
}