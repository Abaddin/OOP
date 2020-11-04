using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net.Http.Headers;
using System.Threading;

namespace Lab_2
{
    class Program
    {
        static int TimeSinceMidnight (MyTime t) 
        {
            return t.hour * 3600 + t.minute * 60 + t.second;
        }

        static MyTime TimeSinceMidnight(int t) 
        {
            if(t < 86400) 
            { 
                int hour = t / 3600;
                int minute = (t / 60) % 60;
                int second = t % 60;
                return new MyTime(hour, minute, second);  
            }
            else throw new Exception("Illegal time!");

        }

        static MyTime AddOneSecond(MyTime t)
        {
            if (t.hour == 23 && t.minute == 59 && t.second == 59)
            {
                t.hour = 0;
                t.minute = 0;
                t.second = 0;
            }
            else 
            {
                if (t.minute == 59 && t.second == 59)
                {
                    t.second = 0;
                    t.minute = 0;
                    t.hour += 1;
                }
                else 
                {
                    if (t.second == 59) 
                    {
                        t.minute += 1;
                        t.second = 0;
                    }
                    else 
                    {
                        t.second += 1;
                    }
                }
            }
            return t;
        }

        static MyTime AddOneHour(MyTime t)
        {
            if (t.hour == 23)
            {
                t.hour = 0;
            }
            else
            {
                t.hour += 1;
            }
            return t;
        }
        static MyTime AddOneMinute(MyTime t)
        {
            if (t.hour == 23 && t.minute == 59)
            {
                t.hour = 0;
                t.minute = 0;
            }
            else
            {
                if (t.minute == 59)
                {
                    t.minute = 0;
                    t.hour += 1;
                }
                else
                {
                    t.minute += 1;
                }
            }
            return t;
        }

        static MyTime AddSeconds(MyTime t, int s)
        {
            int tempTime = t.hour * 3600 + t.minute * 60 + t.second;
            Console.WriteLine("t: " + tempTime);
            while (s >= 86400) 
            {
                s -= 86400;
            }
            Console.WriteLine("s: " + s);
            tempTime += s;
            while (tempTime >= 86400)
            {
                tempTime -= 86400;
            }
            Console.WriteLine("t: " + tempTime);
            t.hour = tempTime / 3600;
            t.minute = (tempTime / 60) % 60;
            t.second = tempTime % 60;
            return t;
        }

        static int Difference(MyTime mt1, MyTime mt2)
        {
            return ((mt1.hour - mt2.hour) * 3600) + ((mt1.minute - mt2.minute) * 60) + (mt1.second - mt2.second);
        }

        static string WhatLesson(MyTime mt)
        {
            int tempTime = mt.hour * 3600 + mt.minute * 60 + mt.second;
            if (mt.hour <= 7)
            {
                return "пари ще не почалися";
            }
            else if (((8 * 3600) <= (tempTime)) && ((9 * 3600 + 20 * 60 - 1) >= (tempTime)))
            {
                return "1-а пара";
            }
            else if (((9 * 3600 + 20 * 60) <= (tempTime)) && ((9 * 3600 + 40 * 60 - 1) >= (tempTime)))
            {
                return "перерва між 1-ю та 2-ю парами";
            }
            else if (((9 * 3600 + 40 * 60) <= (tempTime)) && ((11 * 3600 - 1) >= (tempTime)))
            {
                return "2-а пара";
            }
            else if (((11 * 3600) <= (tempTime)) && ((11 * 3600 + 20 * 60 - 1) >= (tempTime)))
            {
                return "перерва між 2-ю та 3-ю парами";
            }
            else if (((11 * 3600 + 20 * 60) <= (tempTime)) && ((12 * 3600 + 40 * 60 - 1) >= (tempTime)))
            {
                return "3-я пара";
            }
            else if (((12 * 3600 + 40 * 60) <= (tempTime)) && ((13 * 3600 - 1) >= (tempTime)))
            {
                return "перерва між 3-ю та 4-ю парами";
            }
            else if (((13 * 3600) <= (tempTime)) && ((14 * 3600 + 20 * 60 - 1) >= (tempTime)))
            {
                return "4-а пара";
            }
            else if (((14 * 3600 + 20 * 60) <= (tempTime)) && ((14 * 3600 + 40 * 60 - 1) >= (tempTime)))
            {
                return "перерва між 4-ю та 5-ю парами";
            }
            else if (((14 * 3600 + 40 * 60) <= (tempTime)) && ((16 * 3600 - 1) >= (tempTime)))
            {
                return "5-а пара";
            }
            else if (((16 * 3600) <= (tempTime)) && ((16 * 3600 + 20 * 60 - 1) >= (tempTime)))
            {
                return "перерва між 5-ю та 6-ю парами";
            }
            else if (((16 * 3600 + 20 * 60) <= (tempTime)) && ((17 * 3600 + 40 * 60 - 1) >= (tempTime)))
            {
                return "6-а пара";
            }
            else 
            {
                return "пари вже скінчилися";
            }
        }

        static void Main(string[] args)
        {
            /*String a = "1 2 3 4\t4 5 6 7\t8 9 10 11\t12 13 14 15";
            MyMatrix matrix = new MyMatrix(a);
            
            Console.WriteLine(matrix);*/

            MyTime myTime = new MyTime(7, 59, 59);
            MyTime myTime2 = new MyTime(21, 57, 59);
            Console.WriteLine(myTime.ToString());
            Console.WriteLine("Number of seconds from the beginning of the day -- " + TimeSinceMidnight(myTime));
            Console.WriteLine("Translated seconds to time -- " + TimeSinceMidnight(28799));
            Console.WriteLine("One second is added to the time -- " + AddOneSecond(myTime));
            Console.WriteLine("One minute is added to the time -- " + AddOneMinute(myTime));
            Console.WriteLine("One hour is added to the time -- " + AddOneHour(myTime));
            Console.WriteLine("The difference between the two points -- " + Difference(myTime, myTime2));
            Console.WriteLine("Add seconds to time -- " + AddSeconds(myTime, -60000));
            Console.WriteLine(WhatLesson(myTime));
        } 
    }
}