#include "Wire.h"
#define LED_PIN 9

volatile byte value;
void setup() {
  // put your setup code here, to run once:
  Wire.begin(8);    //Adresse für Slave: 8
  Wire.onReceive(dataReceived);
  pinMode(LED_PIN, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  analogWrite(LED_PIN, value);
}

void dataReceived(int anzahl){
  if(Wire.available()){
    value = Wire.read();
  }
}
