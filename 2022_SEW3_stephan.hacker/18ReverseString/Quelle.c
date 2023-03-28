#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h> 
// Der Benutzer soll einen Text eingeben. Danach soll der Text umgedreht werden.
// Definiere dazu zuerst eine Funktion mit dem Namen: stringLength

int stringLength(char text[]) {
	int i = 0;
	while (text[i] != '\0') {
		i++;
	}
	return i - 1;
}

void main() {
	char text[10000];

	printf("Geben Sie einen Text ein: ");
	fgets(text, 9999, stdin);
	
	int length = stringLength(text);
	//int length = strlen(text);		// aus string.h
	length -= 1;		//-1 weil wir den Zeilenumbruch der von fgets kommt nicht wollen

	int first = 0;

	while (first < length) {
		char temp = text[first];
		text[first] = text[length];
		text[length] = temp;

		first++;
		length--;
	}

	printf("%s", text);
}


