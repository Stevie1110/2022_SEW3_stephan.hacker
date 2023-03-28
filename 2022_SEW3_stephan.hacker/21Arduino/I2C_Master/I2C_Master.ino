#include "Wire.h"   //für I²C
#define PIN_PORI 2

void setup() {
  // put your setup code here, to run once:
  Wire.begin();   //kein Argument --> master
}

void loop() {
  // put your main code here, to run repeatedly:
  int value = analogRead(PIN_POTI);
  // value: 0...1023
  // I2C kann nur 8 bit übertragen
  value = value / 4;
  Write.beginTransmission(8);   //wir wollen zum Slave mit Adresse 8 übertragen
  Wire.write(value);
  Wire.endTransmission();
  delay(500);
}
