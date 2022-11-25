#include <SPI.h>
#include <Ethernet.h>
#include <String.h>

#define LED_PIN 5
byte mac[] = {0x12, 0x23, 0x45, 0x67, 0x89, 0x09};
EthernetServer server(8888);

void setup() {
  // put your setup code here, to run once:
  pinMode(LED_PIN, OUTPUT);
  Serial.begin(9600);
  while(!Serial){
    ;     //so lange warten bis ein serieller Monitor verbunden ist
  }

  Ethernet.init(10);
  Ethernet.begin(mac);    //ohne Fehlerbehandlung
  //if(Ethernet.begin(mac==0){
  // Fehler beim verbinden
  // }

  Serial.print("IP: ");
  Serial.println(Ethernet.localIP());   //damit wir die IP-Adresse des Arduino wissen und uns verbinden können

  server.begin();   //TCP steht für eingehende Verbindungen zur Verfügung

}

void response(){
  char response[] = "OK\r\n";
  server.print(response);     //print von EthernetServer braucht char[]
  Serial.println("Response OK");
}

String readString() {
  String retValue;
  EthernetClient client = server.available();   //wenn Server bereits eine Verbindung hat, einen Client daraus erzeugen
  if(!client){
    return retValue;
  }
  Serial.println("Client connected");
  //lesen bis \n kommt
  while(true){
    if(client.connected() && client.available()){
      char c = client.read();
      if(c == '\n'){
        return retValue;   //bisher gelesene Zeichen als Rückgabewert liefern
      }
      retValue += c;

      Serial.print("Remote IP: ");
      Serial.println(client.remoteIP());
      Serial.print("Remote Port: ");
      Serial.println(client.remotePort());
    }
  }
  return "Diese Zeile wird nie erreicht";
}

void loop() {
  // put your main code here, to run repeatedly:
  String value = readString();
  if(value == "on"){
    Serial.println("LED on");
    digitalWrite(LED_PIN, HIGH);
    response();
    }else if(value == "off"){
    Serial.println("LED off");
    digitalWrite(LED_PIN, LOW);
    response();
  }
}
