#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>

int main() {
	char input[1];

	printf("Name eingeben: ");
	scanf("%s[^'\n']", &input); //in eclipse sind die letzten Zeichen '\n' und '\0' sonst nur '\0'
	printf("\nEingabe war: %s \n", input);
}