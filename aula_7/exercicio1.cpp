#include <iostream>
#include <vector>
using namespace std;

int main(){
  int numeros[10];  
  int num;
  int par[10];
  int imp[10];
  int contpar = 0;
  int contimp = 0;
  
  cout << "Digite numeros inteiros" << endl;
  for ( int i = 0; i < 10; i++){
    
    cout << "numero" << i + 1 << ": " << endl;
    cin >> num;
    numeros[i] = num;
     if (num%2==0){
      par[contpar] = numeros[i];
      contpar++;

     }
    else{
      imp[contimp] = numeros[i];
      contimp++;

    }
  }

  for ( int i = 0; i<contpar ; i++){
  cout << "numeros pares: " << par[i] << endl;
}

  for ( int i = 0; i<contimp ; i++){
  cout << "numeros impares: " << imp[i] << endl;
}




  }