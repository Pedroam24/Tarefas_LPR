// See https://aka.ms/new-console-template for more information
#include <iostream>
using namespace std;

int main() {
cout << "***************************************" << endl;
cout << "DESCOBRINDO SE OS NUMEROS SÃO MULTIPLOS" << endl;
cout << "***************************************" << endl;

    int num1, num2;
    cout << "Digite o primeiro número: ";
    cin >> num1;
    cout << "Digite o segundo número: ";
    cin >> num2;

  if(num1 % num2 == 0 || num2 % num1 == 0 ){
    cout << num1 << " e " << num2 <<" são múltiplos";
  }
  else {
    cout << num1 << " e " << num2 <<" não são múltiplos";
  }
}