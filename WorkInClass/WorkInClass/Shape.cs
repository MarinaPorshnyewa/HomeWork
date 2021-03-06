﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    abstract class Shape
    {
        
        protected double P;
        protected double S;

        public abstract double Area();
        public abstract double Perimeter();
        public override string ToString()
        {
            return $"Perimeter = {P}\nArea = {S}";
        }
    }
}
