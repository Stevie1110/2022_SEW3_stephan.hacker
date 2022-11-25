

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  char textA[7] = {'H','a','l','l','o','!'};  //C
  char textB[] = "Hallo";                     //C

  String textC = "Hall";
  String textD = "o Welt";

  Serial.print("Text A: ");
  Serial.println(textA);
  
  //Serial.print("Text A: " + textA);   //geht NICHT!!! --> weil char[]

  Serial.print("Text B: ");
  Serial.println(textB);

  Serial.print("TextC und D: ");
  Serial.println(textC + textD);    //erlaubt, weil vom Datentyp string

  //Serial.print("TextC und D: "+ textC + textD);   //geht NICHT!!! --> weil char[] + string nicht definiert
  int temperature = 20;
  //Serial.println("Die Temperatur beträgt: " + temperature);   //geht NICHT --> char[] + int nicht definiert
  Serial.print("Die Temperatur beträgt: ");   Serial.print(temperature); Serial.println("°C");
  delay(5000);
}
