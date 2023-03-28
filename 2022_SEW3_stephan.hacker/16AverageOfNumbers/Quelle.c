// Der Benutzer soll 5 Zahlen eingeben und als Ausgabe den Mittelwert dieser 5 Zahlen erhalten
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#define NR_OF_ELEMENTS 10		//Präprozessorvariable bzw. Konstante

void main() {		//Lösung 1
	int zahl1;
	int zahl2;
	int zahl3;
	int zahl4;
	int zahl5;
	
	printf("Bitte geben Sie die 1. Zahl ein\n");
	scanf("%d", &zahl1);

	printf("Bitte geben Sie die 2. Zahl ein\n");
	scanf("%d", &zahl2);

	printf("Bitte geben Sie die 3. Zahl ein\n");
	scanf("%d", &zahl3);

	printf("Bitte geben Sie die 4. Zahl ein\n");
	scanf("%d", &zahl4);

	printf("Bitte geben Sie die 5. Zahl ein\n");
	scanf("%d", &zahl5);

	int zahlen = zahl1 + zahl2 + zahl3 + zahl4 + zahl5;
	int mittelwert = zahlen / 5;

	printf("Der Mittelwert ist: ");
	scanf("%d", &mittelwert);
}

void main() {		//Lösung 2
	int input1=0;
	int input2=0;
	int input3=0;
	int input4=0;
	int input5=0;

	printf("Bitte 5 Zahlen eingeben: ");
	scanf("%d%d%d%d%d", &input1, &input2, &input3, &input4, &input5);

	int sum = input1 + input2 + input3 + input4 + input5;
	double average = sum / 5.0;

	printf("Der Mittelwert ist: %f\n", average);
}

void main() {		//Lösung 3
	int sum = 0;
	printf("Bitte 5 Zahlen eingeben: ");
	for (int i = 0; i < 5; i++) {
		printf("Eingabe: ");
		int input = 0;
		scanf("%d", &input);
		sum += input;
	}

	double average = sum / 5.0;
	printf("Der Mittelwert ist: %f\n", average);
}

void main() {		//Lösung 4
	int numbers[5];
	printf("Bitte 5 Zahlen eingeben:\n");
	for (int i = 0; i < 5; i++) {
		printf("Eingabe:");
		scanf("%d", &numbers[i]);
	}

	int sum = 0;
	for (int i = 0; i < 5; i++) {
		sum += numbers[i];
	}

	double average = sum / 5.0;
	printf("Der Mittelwert ist: %f\n", average);
}

void main() {		//Lösung 5
	int numbers[NR_OF_ELEMENTS];
	printf("Bitte 5 Zahlen eingeben:\n");
	for (int i = 0; i < NR_OF_ELEMENTS; i++) {
		printf("Eingabe:");
		scanf("%d", &numbers[i]);
	}

	int sum = 0;
	for (int i = 0; i < 5; i++) {
		sum += numbers[i];
	}

	double average = sum / (double)NR_OF_ELEMENTS;
	printf("Der Mittelwert ist: %f\n", average);
}