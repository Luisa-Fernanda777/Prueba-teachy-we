using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = 7; // Number of people
        int k = 3; // Counting interval

        List<int> people = new List<int>{1, 2, 3, 4, 5, 6, 7};

        // Populate the list with people
       /* for (int i = 1; i <= n; i++)
        {
            people.Add(i);
        }*/
        

        int index = 0;

        // Start the elimination process
        while (people.Count > 1)
        {
            index = (index + k - 1) % people.Count;
            people.RemoveAt(index);
        }

        // The last remaining person is the survivor
        int survivor = people[0];
        Console.WriteLine("The survivor is person #" + survivor);
    }
}