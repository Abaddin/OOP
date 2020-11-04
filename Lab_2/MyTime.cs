using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    struct MyTime
    {
        public int hour, minute, second;

        public MyTime(int h, int m, int s) 
        {
            if(h <= 23 && m <= 59 && s <= 59) 
            {
                hour = h;
                minute = m;
                second = s;
            }
            else throw new Exception("Illegal time!");
        }

        public override string ToString()
        { 
            return hour + ":" + minute + ":" + second; 
        }
    }
}
