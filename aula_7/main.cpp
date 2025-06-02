#include <iostream>
#include <vector>
using namespace std;

int main(){
  int numeros[10];  
  int num;
  int par[10];
  int imp[10];
  int i = 0;
  cout << "Digite numeros inteiros" << endl;
  for ( i = 0; i < 10; i++){
    
    cout << "numero" << i << ": " << endl;
    cin >> num;
    numeros[i] = num;
    
  }
  i = 0;
  for(int num: numeros)
  {
    if(num%2==0){
    //cout << "Numeros pares: " << numeros[i] << endl; 
        par[i] = numeros[i];

    i++;


    }
    else {
    //cout << "Numeros impares: " << numeros[i] << endl; 
    imp[i] = numeros[i];
    i++;
    

    }
  } 
  cout << "numeros pares: " << par[i] << endl;
  cout << "numeros impares: " << imp[i] << endl;




  }