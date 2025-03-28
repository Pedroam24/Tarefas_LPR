#include <iostream>

using namespace std;

int main() {
    int soma = 0;
cout << "Algoritimo de soma de numeros impares divisivel por 3 entre 50 e 500" << endl;
    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;  
        }
    }

    cout << "o resultado da some e:  " << soma << endl;

    return 0;
}
