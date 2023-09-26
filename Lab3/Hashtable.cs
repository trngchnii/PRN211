using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
        class Program3
        {
            static void Main()
            {
                Hashtable daysOfWeek = new Hashtable();
                daysOfWeek.Add(1, "Sunday");
                daysOfWeek.Add(2, "Monday");
                daysOfWeek.Add(3, "Tuesday");
                daysOfWeek.Add(4, "Wednesday");
                daysOfWeek.Add(5, "Thursday");
                daysOfWeek.Add(6, "Friday");
                daysOfWeek.Add(7, "Saturday");

                // Find and print Tuesday
                if (daysOfWeek.ContainsKey(3))
                {
                    Console.WriteLine("Tuesday found: " + daysOfWeek[3]);
                }
                else
                {
                    Console.WriteLine("Tuesday not found.");
                }

                // Print all days of the week
                foreach (DictionaryEntry day in daysOfWeek)
                {
                    Console.WriteLine($"Key: {day.Key}, Value: {day.Value}");
                }
            }
        }
}

