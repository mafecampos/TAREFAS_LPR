#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
    int opcao;
    cout << "Bem vindo(a) ao seu RPG, escolha seu personagem\nEscolha uma opcao:\n1)Guerreira;\n2)Mago;\n3)Arqueira." << endl;
    cin >> opcao;
    switch (opcao) {
    case 1:
        opcao = 1;
        cout << "Otima escolha! Suas habilidades sao Ataque Pesado e Defesa Total :)" << endl;
        break;
    case 2:
        opcao = 2;
        cout << "Otima escolha! Suas habilidades sao Bola de Fogo e Escudo de Gelo :)" << endl;
        break;
    case 3:
        opcao = 3;
        cout << "Otima escolha! Suas habilidades sao Flecha Precisa e Disparo Triplo :)" << endl;
        break;
    }
}
