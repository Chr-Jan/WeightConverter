﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    public class Calculator
    {
        public double Add(int x, int y)
        {
            return x + y;
        }
        public double Subtract(int x, int y)
        {
            return x - y;
        }
        public double Divide(int x, int y)
        {
            return x / (double)y;
        }
        public double Multiply(int x, int y)
        {
            return x * y;
        }
    }
}