using System;
using System.Diagnostics;

class Checker
{
    static bool vitalsOK(float temperature, int pulseRate, int co2)
    {
        int beepFrequency = 400;
        if (temperature < 97f || temperature > 99.1f)
        {
            Console.WriteLine("Vitals Received:");
            Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, co2);
            Console.WriteLine("Temperature out of range!\a\n");
            int beepInterval = 100;
            int sleepInterval = 1000;
            if(temperature >102 || temperature < 95)
            {
                Console.WriteLine("Temperature critically out of range!!!");
                beepInterval = 1500;
                sleepInterval = 100;
                beepFrequency = 1000;
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Beep(beepFrequency, beepInterval);
                System.Threading.Thread.Sleep(sleepInterval);
            }
            return false;
        }
        else if (pulseRate < 60 || pulseRate > 100)
        {
            Console.WriteLine("Vitals Received:");
            Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, co2);
            Console.WriteLine("Pulse Rate is out of range!\a\n");
            int beepInterval = 100;
            int sleepInterval = 1000;
            beepFrequency = 700;
            for (int i = 0; i < 6; i++)
            {
                Console.Beep(beepFrequency, beepInterval);
                System.Threading.Thread.Sleep(sleepInterval);
            }
            return false;
        }
        else if (co2 < 16 || co2 > 20)
        {
            Console.WriteLine("Vitals Received:");
            Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, co2);
            Console.WriteLine("Oxygen Saturation out of range!\a\n");
            int beepInterval = 100;
            int sleepInterval = 1000;
            beepFrequency = 800;

            for (int i = 0; i < 6; i++)
            {
                Console.Beep(beepFrequency, beepInterval);
                System.Threading.Thread.Sleep(sleepInterval);
            }
            return false;
        }
        Console.WriteLine("Vitals Received:");
        Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, co2);

        Console.WriteLine("Vitals OK");
        return true;
    }

    static void ExpectTrue(bool expression)
    {
        if (!expression)
        {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression)
    {
        if (expression)
        {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main()
    {
        ExpectTrue(vitalsOK(98.1f, 70, 18));
        ExpectFalse(vitalsOK(99f, 102, 17));
        ExpectFalse(vitalsOK(105f, 104, 22));
        Console.WriteLine("All ok");
        return 0;
    }
}