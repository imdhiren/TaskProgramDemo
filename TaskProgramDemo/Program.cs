using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProgramDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroducingTasks.CreateAndStartSimpleTasks();
            IntroducingTasks.TasksWithState();
            IntroducingTasks.TasksWithReturnValues();

            Console.WriteLine("Main program done, press any key.");
            Console.ReadKey();
        }
    }
}
