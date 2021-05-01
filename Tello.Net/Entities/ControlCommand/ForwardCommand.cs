﻿using System;
namespace Tello.Net.Entities.ControlCommand
{
    public class ForwardCommand : Command
    {
        public override string Name { get; set; } = "forward";

        public ForwardCommand(int distance) : base(distance)
        {
        }
    }
}
