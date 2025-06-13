#include <iostream>
#include <vector>

using namespace std;
int main(){ 
    int num;
    vector<int>numeros(10);
    cout << "Digite numeros inteiros" << endl;
  for ( int i = 0; i < numeros.size(); i++){
    
    cout << "numero" << i + 1 << ": " << endl;
    cin >> numeros[i];
    
}
cout << "Agora digite o número que você quer procurar: " ;
cin >> num ;
int i = 0;
for ( i = 0; i < 10; i++){
    if (numeros[i]==num){
        cout << "O seu numero esta na posição" << i ;
        
    }
}
 if(numeros[i]!=num) {
        cout << " Esse numero não foi encontrado"; 
    }
}