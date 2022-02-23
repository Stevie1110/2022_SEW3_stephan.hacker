#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<stdlib.h>		//Hier ist die Funktion srand drinnen
#include<time.h>

//Eine Zufallszahl erzeugen --> Benutzer soll solange eine Zahl eingeben können bis er die zufallszahl erraten hat

void main() {
	srand(time(NULL));		//wir intialisieren den Zufallszahlengenerator
	int r = rand();			//hier wird eine Zufallszahl zw. -2^31 - 2^31
	//Zufallszahl zw. 0 und 10
	
	int zufallszahl = r % 11;			//Maximaler Rest: 10
	int benutzereingabe = -1;
	
	while(benutzereingabe != zufallszahl) {
		printf("Bitte Zahl eingeben: ");
		scanf("%d", &benutzereingabe);
		if (benutzereingabe == zufallszahl) {
			printf("Richtig geraten!\n");
		}
		else {
			printf("Leider falsch!\n");
		}
	}
}