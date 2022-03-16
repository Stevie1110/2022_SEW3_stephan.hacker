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
        }

        public void write(string value)
        {
            try
            {
                serialPort.Open();
                serialPort.Write(value);
            }
            catch
            {
                //aktuell noch keine Fehlerbehandlung
            }
            finally
            {
                serialPort.Close();
            }
        }
    }
}
