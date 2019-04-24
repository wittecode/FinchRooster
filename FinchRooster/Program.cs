using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinchAPI;

namespace FinchRooster
{
    class Program
    {
        static void Main(string[] args)
        {
            // ****************************************
            // Title: Finch Rooster
            // Application Type: Console.net Framework
            // Finch alarm clock
            // Author: Hannah Witte
            // Date Created: (4.18.19)
            // Last Modified: (4.22.19)
            // ****************************************

            double LightThreshold = 0;

            //
            // connect finch
            //
            Finch rooster;
            rooster = new Finch();
            rooster.connect();

            //
            // get threshold light
            //
            LightThreshold = rooster.getLeftLightSensor() + 20;

            //
            // greeting
            //
            Console.WriteLine("Congratulations! You are now the owner of your very own state of the art Finch Rooster");
            Console.WriteLine("More than just your run-of-the-mill alarm clock, the Finch Rooster wakes you up at dawn,");
            Console.WriteLine("by sounding an alarm when the sun rises.");
            Console.WriteLine();
            Console.WriteLine("Now hit the hay, you need to be up early tomorrow!");

            //
            // Alarm
            //
            while (rooster.getLeftLightSensor() < LightThreshold)
            {

            }

            rooster.noteOn(4000);
            Console.WriteLine();
            Console.WriteLine("Wake up!!!");

            //
            // turn alarm off/exit
            //
            Console.WriteLine();
            Console.WriteLine("Press any key to turn off Rooster and exit.");
            Console.ReadKey();
            rooster.disConnect();

        }
    }
}
