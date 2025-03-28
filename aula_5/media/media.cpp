#include <iostream>
using namespace std;

int main() {
    int qnum, num, soma = 0, cont = 0, i = 0;
    cout << "VAMOS TIRAR A MEDIA DO NUMERO QUE VOCE ESCOLHER" << endl;
    cout << "Digite a quantidade de numeros: ";
    cin >>  qnum;
     /*i no inicio é 0, então enquanto a quantidade de i for menor que
        a quantidade de numero digitado, ficara nessa função*/
    while (i < qnum) {
    
        cout << "Digite o " << i + 1 << "º numero: ";
        cin >> num;
     //verifica se o numero é par
        if (num % 2 == 0) {
            soma += num;  
            cont++;       
            //conta quantos numeros pares foram digitados
        }

        i++;  
    }

    // se cpnt > 0, pelo menos um numero par foi digitado
    if (cont > 0) {
        
        double media = static_cast<double>(soma) / cont;
        cout << "A media aritmetica dos numeros pares e: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado" << endl;
    }

    return 0;
}
