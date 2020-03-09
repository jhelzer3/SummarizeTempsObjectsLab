using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int tempcount = 0;
            int totaltemp = 0;

            foreach (int temp in _temperatures)
            {
                tempcount += 1;
                totaltemp += temp;
               
             
            }
           

            return (totaltemp/tempcount); // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            int aboveCounter = 0;
            foreach (int temp in _temperatures)
            {
                
                if (temp > threshold)
                {
                    aboveCounter += 1;

                }
            }


            return aboveCounter; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int belowCounter = 0;
            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    belowCounter += 1;
                }
            }
            return belowCounter;
        }

        public int TempsAtThreshold(int threshold)
        {
            int atCounter = 0;
            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    atCounter += 1;

                }
            }
            return atCounter; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            int tempNumber = 0;
            foreach(int temp in _temperatures)
            {
                tempNumber += 1;
            }
            return tempNumber;
        }
    }
}
