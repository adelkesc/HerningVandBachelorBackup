﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BachelorApp
{
    public class Reading
    {
        public Reading(float p1s, float p1o, float p2s, float p2o, float rain, float niv, int m, int d, int h)
        {
            pump1StartQuantity = p1s;
            pump1OperatingTime = p1o;
            pump2StartQuantity = p2s;
            pump2OperatingTime = p2o;
            rainInMM = rain;
            niveauInCM = niv;
            month = m;
            day = d;
            hour = h;
        }
        public float pump1StartQuantity { get; set; }
        public float pump1OperatingTime { get; set; }
        public float pump2StartQuantity { get; set; }
        public float pump2OperatingTime { get; set; }
        public float rainInMM { get; set; }
        public float niveauInCM { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public int hour { get; set; }
    }
}