#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void lotto(int* lottoNumbers) {
    //static int lotto[7];
    int i, j, k, z;

    srand(time(NULL));

    i = 0;
    while (i < 7) {
        z = rand() % 46 + 1;
        for (j = 0; j < i && z > lottoNumbers[j]; j++) {
            ;
        }
        if (j < i&& z == lottoNumbers[j]) {
            // Zahl schon vorhanden
            continue;
        }
        if (i == 6) {
            lottoNumbers[i] = z;
        }
        else {
            for (k = i; k > j; k--) {
                lottoNumbers[k] = lottoNumbers[k - 1];
            }
            lottoNumbers[k] = z;
        }
        i++;
    }
}


void main()
{
    int numbers[7];
    lotto(numbers);
    for (int i = 0; i < 7; i++)
    {
        printf("%d. Zahl = %d\n", i, numbers[i]);
    }
}

void main() {
    int lottoNumbers[7];
    lotto(&lottoNumbers);
    printf("Lottozahlen inkl. Zusatzzahl\n");
    for (int i = 0; i < 7; i++)
    {
        printf("%i\n", lottoNumbers[i]);
    }
}