using System;
using System.Diagnostics;

class Checker
{
    static bool VitalsOK(float temperature, int pulseRate, int spo2)
    {
        if(temperature >102 || temperature < 95)
        {
            Console.WriteLine("Temperature critical!");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\r* ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\r *");
                System.Threading.Thread.Sleep(1000);
            }
            return false;
        }
        else if (pulseRate < 60 || pulseRate > 100)
        {
            Console.WriteLine("Pulse Rate is out of range!");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\r* ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\r *");
                System.Threading.Thread.Sleep(1000);
            }
            return false;
        }
        else if (spo2 < 90)
        {
            Console.WriteLine("Oxygen Saturation out of range!");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\r* ");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\r *");
                System.Threading.Thread.Sleep(1000);
            }
            return false;
        }
        Console.WriteLine("Vitals received within normal range");
        Console.WriteLine("Temperature: {0} Pulse: {1}, SO2: {2}", temperature, pulseRate, spo2);
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
        ExpectFalse(VitalsOK(99f, 102, 70));
        ExpectTrue(VitalsOK(98.1f, 70, 98));
        Console.WriteLine("Done");
        return 0;
    }
}
