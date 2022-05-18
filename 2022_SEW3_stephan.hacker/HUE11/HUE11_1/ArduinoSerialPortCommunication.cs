using System;
using System.IO.Ports;

namespace HUE11_1
{
    public class ArduinoSerialPortCommunication
    {
        private SerialPort serialPort;
        public ArduinoSerialPortCommunication(string port)
        {
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            serialPort.Open();

        }

        public void addSerialDataReceivedEventHandler(SerialDataReceivedEventHandler handler)
        {
            serialPort.DataReceived += handler;     //ein neuer EventHandler, der eine Methode aufruft
        }      //wenn Daten empfangen wurden
            public void write(string value)
            {
                try
                {
                    //serialPort.Open();

                    serialPort.Write(value);
                }
                catch
                {
                }
            }
    }
}
