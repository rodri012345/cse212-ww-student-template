using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
 
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
       
        double[] result = new double[length];

       
        for (int i = 0; i < length; i++) {
       
            result[i] = number * (i + 1);
        }

        return result;
    }

    public static void RotateListRight(List<int> data, int amount)  {

        List<int> endPart = data.GetRange(data.Count - amount, amount);

        
        List<int> startPart = data.GetRange(0, data.Count - amount);

        
        data.Clear();

        
        data.AddRange(endPart);

        
        data.AddRange(startPart);
    }
}
