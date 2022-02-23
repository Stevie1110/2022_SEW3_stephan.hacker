#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<stdlib.h>		//Hier ist die Funktion srand drinnen
#include<time.h>

void main() {
    char name[50];
    float zahlen[6];
    printf("Bitte Namen eingeben: ");
    scanf("%s", &name);

    printf("Bitte 6 Gleitkommazahlen eingeben: ");
    scanf("%f %f %f %f %f %f", &zahlen[0], &zahlen[1], &zahlen[2], &zahlen[3], &zahlen[4], &zahlen[5]);

    float temp = 0;
    for (int i = 0; i < 6; i++) {
        temp += zahlen[i];
    }
    float mw = temp / 6;
    printf("%s \n", name);
    for (int i = 0; i < 6; i++) {
        if (zahlen[i] > mw) {
            printf("%f \n", zahlen[i]);
        }
    }
}