﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogAn
{
    public class Calculator
    {
        private int sum = 0;

        public Calculator()
        {
        }

        public void Add(int number)
        {
            sum += number;
        }

        public int Sum()
        {
            int temp = sum;
            sum = 0;
            return temp;
        }
    }
}
