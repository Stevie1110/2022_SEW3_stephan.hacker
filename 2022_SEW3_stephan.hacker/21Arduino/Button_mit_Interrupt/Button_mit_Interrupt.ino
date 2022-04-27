
// constants won't change. They're used here to set pin numbers:
const int buttonPin = 2;     // the number of the pushbutton pin
const int ledPin =  13;      // the number of the LED pin

// variables will change:
// wichtig!!!(volatile)
volatile int buttonState = 0;         // variable for reading the pushbutton status
// wichtig!!!

void setup() {
  // initialize the LED pin as an output:
  pinMode(ledPin, OUTPUT);
  // initialize the pushbutton pin as an input:
  pinMode(buttonPin, INPUT);

  attachInterrupt(digitalPinToInterrupt(buttonPin), pin_ISR, CHANGE);  //Bei einem Interrupt (CHANGE: wenn sich der Wert ändert) wird pin_ISR aufgerufen
}

void loop() {
  // vorerst nichts zu tun
 delay(10000);
}

void pin_ISR() {
  //dieser Code wird beim Inetrrupt ausgeführt
  buttonState = digitalRead(buttonPin);
  digitalWrite(ledPin, buttonState);
}
