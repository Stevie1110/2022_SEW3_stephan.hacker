#include <SPI.h>      //Zur kommunikation von Arduino mit Ethernet-Shield
#include <Ethernet.h>

byte mac[] = {0x12, 0x34, 0x56, 0x78, 0x90, 0x09};

void setup() {
  // put your setup code here, to run once:
  Ethernet.init(10);    //10 Standardwerte für Ethernet-Shield
  Serial.begin(9600);
  Serial.println("Initialize Ethernet with DHCP");
  if(Ethernet.begin(mac) == 0){
    // wenn der Rückgabewert 0 ist, dann ist ein Fehler aufgetreten
    Serial.println("Ein Fehler ist aufgetreten");
    if(Ethernet.hardwareStatus() == EthernetNoHardware) {
      // kein Ethernet Shield vorhanden
      Serial.println("Ethernet shield nicht vorhanden");
    }else if(Ethernet.linkStatus() == LinkOFF){
      Serial.println("Ethernet Kabel nicht verbunden");
    }
    while(true){
      //wir können nichts besseres tun!!!
      delay(1);
    }
  }

Serial.print("IP-Adresse: ");
Serial.println(Ethernet.localIP());
}

void loop() {
  // put your main code here, to run repeatedly:

}
