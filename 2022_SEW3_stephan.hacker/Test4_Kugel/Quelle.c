#define _CRT_SECURE_NO_WARNINGS
#define pi 3.14159
#include <stdio.h>
#include <time.h>

void kugel(float r, float* volumen, float* oberflaeche) {
	*oberflaeche = 4 * (r * r) * pi;
	*volumen = 0.75 * pi * (r * r * r);
}

void main() {
	float r = 4.5;
	float volumen;
	float oberflaeche;
	kugel(r, &volumen, &oberflaeche);
	printf("Der Radius: %f\nDas Volumen: %f\nDie Oberflaeche: %f", r, volumen, oberflaeche);
}
