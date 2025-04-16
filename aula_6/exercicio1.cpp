#include <iostream>
using namespace std;
int retornoinverso(int num){
   int reverso = 0 ;
while (num != 0){
    int digito;
    digito = num % 10 ;
    reverso = reverso * 10 + digito; 
    num /= 10;
}
return reverso;
}
int main(){
    int x ;
    cout << "Digite um numero inteiro: ";
    cin >> x;

    int result = retornoinverso(x);
    cout << result <<"hello world" ;
    
}
