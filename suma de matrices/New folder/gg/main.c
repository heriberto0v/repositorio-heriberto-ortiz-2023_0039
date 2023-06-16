#include <stdio.h>

const int TAM = 3;


void Lectura(int[][TAM], int);
void SumarMatrices(int[][TAM], int[][TAM], int[][TAM], int);
void Imprimir(int[][TAM], int);

int main(void)
{
    int MAT1[TAM][TAM];
    int MAT2[TAM][TAM];
    int resultado[TAM][TAM];

    printf("Ingrese los elementos de la primera matriz:\n");
    Lectura(MAT1, TAM);

    printf("\nIngrese los elementos de la segunda matriz:\n");
    Lectura(MAT2, TAM);

    SumarMatrices(MAT1, MAT2, resultado, TAM);

    printf("\nResultado de la suma:\n");
    Imprimir(resultado, TAM);
