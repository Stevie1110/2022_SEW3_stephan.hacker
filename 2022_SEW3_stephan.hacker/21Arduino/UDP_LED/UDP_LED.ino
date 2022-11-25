#include <Ethernet.h>
#include <EthernetUdp.h>
#include <String.h>

#define LED_PIN 5
byte mac[] = {0x12, 0x23, 0x45, 0x67, 0x89, 0x09};

unsigned int localPort = 8888;
char packetBuffer[UDP_TX_PACKET_MAX_SIZE];

//Ein EthernetUDP Objekt anlegen
EthernetUDP Udp;

void setup() {
  // put your setup code here, to run once:
  Ethernet.init(10);
  Ethernet.begin(mac);    //IP, Gateway und Subnet von DHCP
  Serial.begin(9600);
  while(!Serial){
    ;   //warten auf einen seriellen Kommunikationspartner
  }
  pinMode(LED_PIN, OUTPUT);
  Serial.begin(9600);
  Serial.println("###LED-Steuerung###");

  //Fehlerbehandlung
  if(Ethernet.hardwareStatus() == EthernetNoHardware){
    Serial.println("Kein Ethernet Shield vorhanden");
    while(true){
      delay(100);
    }
  }
  if(Ethernet.linkStatus() == LinkOFF){
    Serial.println("Kein Ethernet Kabel");
  }
  Serial.print("IP: ");
  Serial.println(Ethernet.localIP());

  Udp.begin(localPort);   //Wir horchen auf unseren Port auf UDP-Pakete
}

void loop() {
  // put your main code here, to run repeatedly:
  int packetSize = Udp.parsePacket();   //liefert die Anzahl an vorliegenden Bytes
  if(packetSize>0){
    Serial.print("Datenpaket mit Groeße: ");
    Serial.println(packetSize);
    Serial.print("From: ");
    IPAddress remote = Udp.remoteIP();
    for(int i = 0; i< 4; i++){
      Serial.print(remote[i], DEC);    //umwandeln in Dezimalzahl
      if(i < 3){
        Serial.print(".");
      }
    }
    Serial.print("Port: ");
    Serial.println(Udp.remotePort());

    //lesen der Daten(payload)
    int read = Udp.read(packetBuffer, UDP_TX_PACKET_MAX_SIZE);    //Udp.read liefert die Anzahl an gelesenen Zeichen als Rückgabewert
    packetBuffer[read] = '\0';        // \0 dranhängen, damit wir ein println machen können
    Serial.println("Content: ");
    Serial.println(packetBuffer);
    String result = String(packetBuffer);

    //Led ein oder ausschalten
    if(result == "on"){
      digitalWrite(LED_PIN, HIGH);
      Serial.println("LED wurde eingeschalten.");
    }
    if(result == "off"){
      digitalWrite(LED_PIN, LOW);
      Serial.println("LED wurde ausgeschalten.");
    }
    Udp.beginPacket(Udp.remoteIP(), Udp.remotePort());
    char replyBuffer[] = "acknowlegded";
    Udp.write(replyBuffer);
    Udp.endPacket();
  }
}
