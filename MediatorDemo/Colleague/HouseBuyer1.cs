﻿using MediatorDemo.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDemo.Colleague
{
    public class HouseBuyer1:People
    {
        public HouseBuyer1(HouseMediator mediator):base(mediator)
        { }

        public void GetHouseMsg(string msg)
        {
            Console.WriteLine($"买房者1获得房源消息:{msg}");
        }
    }
}
