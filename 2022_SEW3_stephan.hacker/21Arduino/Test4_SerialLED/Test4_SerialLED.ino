#define LED_BuiltIn 13

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED_BuiltIn, OUTPUT);
  Serial.println("Geben Sie einen beliebigen Wert zwischen 0 und 5000 ein");
}

int nudel() {
      char eingabeb[10];
      int i = 0;
      char as = '\0';    

while (as != '\n' && i < 10) {
    if (Serial.available()) {    //lest nur wenn Daten vorhanden sind
        as = Serial.read();   // bis \n ist //liefert Char
        eingabeb[i] = as;
        i++;
    }
}
return atoi(eingabeb);
      
}

void loop() {
  int eingabe = nudel();
  if(eingabe > 0 && eingabe < 5000){
        digitalWrite(LED_BuiltIn, HIGH);
        delay(eingabe);
        digitalWrite(LED_BuiltIn,LOW);
      }
}
