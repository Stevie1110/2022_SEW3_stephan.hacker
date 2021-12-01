#include<stdio.h>
#include <string.h>

int main() {
	char name[1];

	printf("Name eingeben: ");
	scanf("%[^'\n']", &s); //in eclipse sind die letzten Zeichen '\n' und '\0' sonst nur '\0'
	printf("\nEingabe war: %s \n", s);

	return 0;
}