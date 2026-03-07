using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start

        // Plan:
        // 1. Create an array of size 'length'
        // 2. Iterate through the array using a for loop
        // 3. At each position i, place number * (i+1)
        //4. Return the entire array at the end

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Plan:
        // 1. Calculate the index at which to cut the list: cutIndex = data.Count - amount
        // 2. Get the final part of the list that will go to the beginning: endPart
        // 3. Get the initial part that will go to the end: startPart
        // 4. Clear the original list using Clear()
        // 5. Add endPart first and then startPart using AddRange()

        int cutIndex = data.Count - amount;
        List<int> endPart = data.GetRange(cutIndex, amount);
        List<int> startPart = data.GetRange(0, cutIndex);
        data.Clear();
        data.AddRange(endPart);
        data.AddRange(startPart);
    }

}


