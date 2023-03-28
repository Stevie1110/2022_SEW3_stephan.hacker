#include <stdio.h>

void swap(int x, int y) {
	int temp = x;
	x = y;
	y = temp;
	printf("Adresse von x: %d\n", &x);
	printf("Adresse von y: %d\n", &y);
}

void swap2(int* p1, int* p2) {			//Parameter p1 und p2 sind Speicheradressen
	int temp = *p1;						//mit *Operator auf den Wert zugreifen, der sich unter der Speicheradresse p1 befindet.
	*p1 = *p2;
	*p2 = temp;
}

int main() {
	int a = 12345;			//int: 4 byte
	int b = 10000;
	int c = 5;

	long adressA = &a;
	printf("%d\n", adressA);
	long adressB = &b;
	printf("%d\n", adressB);
	int* adressC = &c;			// Adresse zum Speicherplatz eines int, oder Zeiger auf einen int

	printf("c=%d\n", c);
	printf("c=%d\n", *adressC);		//*Operator liefert den Wert auf dieser Speicheradresse
	*adressC = 10;
	printf("c=%d\n", c);
	printf("c=%d\n", *adressC);
	//adressC = 123423;
	//printf("c=%d\n", *adressC);		//Speicherzugriffsverletzung

	printf("a=%d\n", a);
	printf("b=%d\n", b);
	swap(a, b);							// call by value
	printf("a=%d\n", a);
	printf("b=%d\n", b);
	swap2(&a, &b);						// call by reference
	printf("a=%d\n", a);
	printf("b=%d\n", b);

	return 0;
}