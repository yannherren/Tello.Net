﻿using System;
using Tello.Net.Entities.Connection;
using Tello.Net.Entities.ControlCommand;
using Tello.Net.Entities.Drone;

namespace Tello.Net.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new TelloConnection();
            connection.Connect("192.168.10.1", 8889);

            var drone = new TelloDrone(connection);
            drone.SendCommand(new TakeoffCommand());
            drone.Wait(1000);
            drone.SendCommand(new RcCommand(0, 50, 0, 0));
            drone.Wait(1000);
            drone.SendCommand(new RcCommand(0, 0, 0, 0));
            drone.SendCommand(new LandCommand());
        }
    }
}
