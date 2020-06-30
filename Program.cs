using System;
using System.Collections.Generic;

namespace Lab5_2EnumTaskList
{
    class Program
    {
        // 1. Start by creating an enum. Remember that you must do this above the Main() code block.
        // Trying to create this inside of it will give you an error.  
        // This enum will represent the days of the week.
        public enum WeekDays {
            
            Monday,
            Tuesday,
            Wednesday,
            Thurday,
            Friday,
            Saturday,
            Sunday
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab5_2EnumTaskList!");

            // 2. Inside of the main code block, let’s create a list of 
            // strings to represent our list of task items.

            // Create a list to hold tasks
            List<string> taskList = new List<string>();

            // 3. Now, the next step is to loop through all of the values in the enum, 
            // offering the user a chance to assign a task to the day.  To do this, we 
            // have to use a special function called Enum.GetValues().  This will get 
            // all of our values from our enum.After getting each enum value & getting 
            // input from the user, we add the task to our list.

            // for each value in the Enum...let the user create a task.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {

                Console.WriteLine($"Enter a new task for {day}");
                //Console.WriteLine("Enter a new task for " + day);
                string task = $"{day} : {Console.ReadLine()}";
                // string task = day + " : " + Console.ReadLine();
                taskList.Add(task);

            }


            // 4. Finally, all that is left to do is print each task from the list.

            // print all the tasks.
            foreach (string task in taskList) 
            {
                Console.WriteLine(task);
            }

        }
    }
}
