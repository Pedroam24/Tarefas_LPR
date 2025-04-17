#include <iostream>
using namespace std;
void media(){
    int qnum, num, soma = 0, cont = 0, i = 0;
    cout << "Iniciando ... " << endl ;
    cout << "VAMOS TIRAR A MEDIA DO NUMERO QUE VOCE ESCOLHER" << endl;
    cout << "Digite a quantidade de numeros: ";
    cin >>  qnum;
     
    while (i < qnum) {
    
        cout << "Digite o " << i + 1 << "º numero: ";
        cin >> num;
    
        if (num % 2 == 0) {
            soma += num;  
            cont++;       
          
        }

        i++;  
    }

    if (cont > 0) {
        
        double media = static_cast<double>(soma) / cont;
        cout << "A media aritmetica dos numeros pares e: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado" << endl;
    }

   
}//fim do media

void somaimpar(){

    int soma = 0, inicio = 2;
cout << "Algoritimo de soma de numeros impares divisivel por 3 entre 50 e 500" << endl;
cout << "Para iniciar aperte 4" << endl ;   
cin >> inicio ;
if (inicio == 4){
    cout << "Iniciando ... " << endl ;
for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;  
        }
    }
 
    cout << "o resultado da soma e:  " << soma << endl;
}
else {
    cout << "Numero de iniciacao nao identificado. tente digitar 4.";
}
    
}//fim do soma impar

void somaaoquadrado(){
    int soma = 0, num, result;
    cout << "Iniciando ... " << endl ;
    cout << "Digite um numero: ";
    cin >> num;

    result = num * num;
    cout << "O numero ao quadrado e: " << result << endl;

    while (result > 0) {
        soma += result % 10; 
        result /= 10;         
    }

    cout << "A soma de cada algarismo do seu numero elevado ao quadrado e: " << soma << endl;

}


int main(){
    int x; 
    cout << "SEJA BEM VINDO AO MENU" << endl;
    cout << "A tres algoritimos, e cada um designado a uma funcao propria" << endl;
    cout << "Digite os seus respectivos numeros para acessar cada um desses algoritimos" << endl;
    cout << "1- Calculador de media" << endl;
    cout << "2- Soma de numeros impares entre 50 e 500 e que sao divisiveis por 3" << endl;
    cout << "3- Soma dos termos de um numero elevado ao quadrado" << endl;
    cout << "Digite um numero: ";
    cin >> x;

    if (x == 1){
        media();
    }
    else if (x == 2){
        somaimpar();
    }
    else if (x == 3){
        somaaoquadrado();
    }
}
