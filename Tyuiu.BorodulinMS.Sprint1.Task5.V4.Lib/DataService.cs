﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.BorodulinMS.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {


        public int SecondsToHours(int x)
        {
            var res = x / 60 / 60;
            return (int)res;
        }
    }
}
