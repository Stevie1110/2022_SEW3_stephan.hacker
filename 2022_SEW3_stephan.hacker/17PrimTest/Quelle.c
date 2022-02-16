#define _CRT_SECURE_NO_WARNINGS
//Der Benutzer soll eine Zahl eingeben und sie sollen überprüfen, ob es sich um eine Primzahl handelt.
#include <stdio.h>


void main() {
	int zahl;
	int erg;
	printf("Bitte geben Sie eine Zahl ein!");
	scanf("%d", &zahl);

	//Schleife um zu testen, ob Zahl ohne Rest dividierbar ist

	for (int i = 2; i < zahl; i++) 
	{
		erg = zahl % i;
		if (zahl % i == 0) {
			printf("Die Zahl %d ist keine Primzahl", zahl);
			return;
		}
	}

	//Keine Zahl gefunden, durch die ich ohne Rest dividieren kann --> Primzahl
	if (zahl < 2) {
		printf("Die zahl %d ist keine Primzahl", zahl);
	}
	else {
		printf("Die zahl %d ist eine Primzahl", zahl);
	}
}