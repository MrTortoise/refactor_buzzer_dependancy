using System;
using Xunit;

namespace RefactorPrinter
{
    /// <summary>
    /// This class is consumed throughout the system.
    /// You cannot modify its existing API - if you do something will break in QA, when this happens QA break you.
    /// </summary>
    public class BuzzerUtilManager
    {
        public void PerformTemperatureChecks()
        {
            var sensor = new HeatSensor();
            var temp = sensor.GetTemperature();
            if (temp > 1500)
            {
                var buzzer = new Buzzer();
                buzzer.Buzz();
            }
        }
    }

    /// <summary>
    /// This is an class in an external API, you cannot modify it in any way
    /// </summary>
    public class Buzzer
    {
        public void Buzz()
        {
            Console.WriteLine("buzz");
        }
    }

    /// <summary>
    /// This is part of a public api that cannot be modified
    /// </summary>
    public sealed class HeatSensor
    {
        public int GetTemperature()
        {
            var generator = new Random();
            return generator.Next(0, 2000);
        }
    }

    /*
     *Your requirements are to produce tests that show that this code functions as intended
     * The perform temp pchecks util manager function needs some new behaviour
     * If the temperature goes over 1500 the alarm needs to go off
     * But the alarm only stops when the temp reduces back below 1300
     *
     * the alarm also needs to go off when the temp drops below 100
     * it needs to stop when the temp goes back above 110
     * 
     */


    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
        }
    }
}