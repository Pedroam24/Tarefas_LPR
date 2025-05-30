#include <iostream>
#include <vector>
using namespace std;

int main(){
  int num;  
  int par[5];
  int imp[4];
  int cpar, cimp;

  cout << "Digite numeros entre 1 e 10" << endl;
    for (int i = 0; i < 10; i++) {
      cout << "numero"<< i << ": ";
      cin >> num;
    
      if (num%2==0){
        par[5] = num; 
        i++;
      }
      else{
        imp[4] = num;
        i++;
      }
    
    }

    cout <<  "pares: " << par[1] << ", " << par[2] << ", " <<  par[3] << ", " << par[4] << ", " << "," << par[5] << endl;
  
  }