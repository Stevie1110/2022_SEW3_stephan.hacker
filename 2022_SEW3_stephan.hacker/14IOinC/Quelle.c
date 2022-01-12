#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>

void main() {
	//char input[100];
	//char lastname[100];
	//printf("Bitte deinen Vor- und Nachname eingeben: ");
	//scanf("%s %s[^'\n']", &input, &lastname); //in eclipse sind die letzten zeichen '\n' und '\0' sonst nur '\0' ( "\0" beendet den string) //"%s" --> als text einlesen
	//printf("\nhallo, %s %s, ich wünsche dir einen schönen tag\n", input, lastname);

	char input2[100];
	int n = 80;
	printf("Bitte deinen 2. Vor- und Nachname eingeben: ");
	fgets(input2, n, stdin);		// Lesen von Standardeingabe (stdin) --> Console
	printf("Hallo %s, ich wuensche", input2);
}