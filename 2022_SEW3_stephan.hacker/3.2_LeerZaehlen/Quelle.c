#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<stdlib.h>		//Hier ist die Funktion srand drinnen
#include<time.h>

void main() {
    char text[1025];
    int zähler = 0;
    printf("Bitte einen Text eingeben: ");
    fgets(text, 1024, stdin);
    for (int i = 0; i < 1025; i++)
    {
        if (text[i] == ' ')
        {
            zähler++;
        }
    }
    printf("%i", zähler);
}