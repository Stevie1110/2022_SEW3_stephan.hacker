#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<stdlib.h>		//Hier ist die Funktion srand drinnen
#include<time.h>


int stringLength(char text[]) {
    int counter = 0;
    while (text[counter] != '\0') {
        counter++;
    }
    return counter;
}

int hauefigstesZeichen(char text[]) {
    char abc[] = "abcdefghijklmnopjrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int count[52];
    for (int i = 0; i < stringLength; i++) {
        for (int j = 0; j < 53; j++) {
            if (abc[j] == text[i]) {
                count[j]++;
            }
        }
    }
    int max;
    for (int x = 0; x < 53; x++) {
        int max = count[x];
        if (count[x] > max) {
            max = count[x];
        }
    }
    return max;

}

void main() {
    char text[] = "Hallo, dies ist ein einfacher Beispieltext. Dieser hat keinen Zweck, steht also nur so zum Selbstzweck da.";
    haeufigstesZeichen(text);

}
char zeichen[];

 