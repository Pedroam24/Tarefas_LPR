#include <iostream>
#include <cstdlib> // para rand() e srand()
#include <ctime>   // para time()


using namespace std;

int main() {
    
   
        srand(static_cast<unsigned int>(time(0)));
        int numdigitado = 0;
        int numeroAleatorio = rand() % 100;
        cout << "DIGITE UM NUMERO DE 0 A 100"<< endl;
        
    
        do{
            cout << "Digite um numero: " ; 
            cin >> numdigitado;

            if(numdigitado < numeroAleatorio){
                cout << "chutou baixo" << endl;
            }
            else if (numdigitado > numeroAleatorio){
                cout << "chutou alto" << endl;
            }
            else { 
                cout<< "voce acertou";
            }
        }while (numdigitado != numeroAleatorio);

        return 0;

    

    
}
