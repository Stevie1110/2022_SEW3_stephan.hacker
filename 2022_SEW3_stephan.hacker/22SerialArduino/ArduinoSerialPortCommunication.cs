using System;
using System.IO.Ports;

namespace _22SerialArduino
{
    public class ArduinoSerialPortCommunication
    {
        private SerialPort serialPort;

        public ArduinoSerialPortCommunication(string port)
        {
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            serialPort.Open();      // verbindung aufbauen, um auf Nachrichten zu hören. bleibt solange offen, wie das Programm läuft

            //serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);     //ein neuer EventHandler, der eine Methode aufruft
                                                                                                           //wenn Daten empfangen wurden

            //serialPort.DataReceived += SerialPort_DataReceived;        // diese Zeile hat gleiche Bedeutung wie Zeile 15                                  

        }

        public void addSerialDataReceivedEventHandler(SerialDataReceivedEventHandler handler)
        {
            serialPort.DataReceived += handler;     //ein neuer EventHandler, der eine Methode aufruft
                                                    //wenn Daten empfangen wurden
                                                   

        //private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    Console.Write(serialPort.ReadExisting());
        //}

        public void write(string value)
        {
            try
            {
               
                serialPort.Write(value);
            }
            catch
            {
                //aktuell noch keine Fehlerbehandlung
            }
            finally
            {
               
            }
        }
    }
}
