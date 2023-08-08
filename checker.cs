using System;
using System.Diagnostics;

class Checker
{
    static bool vitalsOK(float temperature, int pulseRate, int so2)
    {
        if (temperature < 97 || temperature > 100)
        {
            Console.WriteLine("Vitals Received:");
            Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, so2);
            Console.WriteLine("Temperature out of range!\a\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Beep(500, 100);
                //Console.WriteLine("\a...\n");
                System.Threading.Thread.Sleep(1000);
            }
            return false;
        }
        else if (pulseRate < 60 || pulseRate > 100)
        {
            Console.WriteLine("Vitals Received:");
            Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, so2);
            Console.WriteLine("Pulse Rate is out of range!\a\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Beep(500, 100);
                System.Threading.Thread.Sleep(1000);
            }
            return false;
        }
        else if (so2 < 95 || so2 > 100)
        {
            Console.WriteLine("Vitals Received:");
            Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, so2);
            Console.WriteLine("Oxygen Saturation out of range!\a\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Beep(500, 100);
                System.Threading.Thread.Sleep(1000);
            }
            return false;
        }
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
        ExpectTrue(vitalsOK(98.1f, 70, 99));
        ExpectFalse(vitalsOK(90f, 74, 100));
        Console.WriteLine("All ok");
        return 0;
    }
}