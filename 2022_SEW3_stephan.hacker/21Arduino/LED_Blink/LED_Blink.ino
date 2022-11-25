#define LED_BUILTIN 13

void setup() {
  // put your setup code here, to run once:
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);       //bau rate
}

void loop() {
  // put your main code here, to run repeatedly:
digitalWrite(LED_BUILTIN, HIGH);
Serial.println("LED ein");
delay(500);
digitalWrite(LED_BUILTIN, LOW);
Serial.println("LED aus");
delay(500);
}
