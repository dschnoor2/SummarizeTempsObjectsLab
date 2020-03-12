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
            // add logic to calculate the average
            //loop through all temps in the list

            int sumOfTemperatures = 0;
            foreach (int temperatures in _temperatures)
            {
                //add each tempt to my sum variable
                sumOfTemperatures += temperatures;   
            }

            //divide sum variable by list count 
            int averageTemps = sumOfTemperatures / _temperatures.Count;
            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int temperaturesAboveThreshold = 0;
            
            foreach (int temperatures in _temperatures)
            {
                //insert threshold amount
                if (temperatures > threshold)
                {
                    temperaturesAboveThreshold += 1;
                }
                    //if above threshold count
                    //else do not count
            }
            
            return temperaturesAboveThreshold; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int temperaturesBelowThreshold = 0;


            foreach (int temperatures in _temperatures)
            {
                //loop through all list of items
                if (temperatures < threshold)
                {
                    temperaturesBelowThreshold += 1;
                }
                
            }
            
            return temperaturesBelowThreshold; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int temperaturesAtThreshold = 0;

            foreach (int temperatures in _temperatures)
            {
                if (temperatures == threshold)
                {
                    temperaturesAtThreshold += 1;
                }
            }
            
            return temperaturesAtThreshold; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
