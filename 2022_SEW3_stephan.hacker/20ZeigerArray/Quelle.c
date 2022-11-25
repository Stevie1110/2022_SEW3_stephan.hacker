#include <stdio.h>
#include <stdlib.h>
#include <time.h>

//void reset(int arr[], int size) {
void reset(int* arr, int size){					//int* arr gleichbedeutend mit int arr[]
	for (int i = 0; i < size; i++) {
		arr[i] = 0;						//Verwendung wie ein normales Array!
	}
}

int* getRandom() {
	//int list[10];					//Gültigkeitsbereich von list[] --> nur in Funktion
	static int list[10];								//Gültigkeistbereich von list --> global, die Liste wird so angelegt, dass 
									//sich auch außerhalb der Funktion gültig ist --> static
	srand((unsigned)time(NULL));		
										
	for (int i = 0; i < 10; i++) {
		list[i] = rand() % 11;			//Zufallszahl 0...1
	}

	return list;
}

int main() {
	int list[10];
	reset(list, 10);		//alle Werte auf 0 setzen

	for (int i = 0; i < 10; i++) {
		printf("%d", list[i]);
	}

	int* list2;
	list2 = getRandom();

	printf("list2\n");
	for (int i = 0; i < 10; i++) {
		printf("%d\n", list2[i]);
	}

	return 0;
}