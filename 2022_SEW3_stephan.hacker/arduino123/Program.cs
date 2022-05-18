using System;

namespace arduino123
{
    class Program
    {
        static void Main(string[] args)
        {
            ArduinoSerialPortCommunication arduino1 = new ArduinoSerialPortCommunication("COM5");

            Random rand = new Random();

            int temp = rand.Next(0, 5000);

            arduino1.write(temp.ToString());
        }
    }
}
