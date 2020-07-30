using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingWithEnums
{
    
     //you can specify allocated data required to store enum by placing ":" before type and then the "{}"
    enum DayOfTheWeek : byte { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    
    struct Task
    {
       public string name;
       public bool complete;
    }

    class TaskList
    {
        List<Task> task = new List<Task>();

        public Task(string name) : this()
        {
            this.name = name;
            complete = false;
        }
        
        public AddTask(string s)
        {
            Task T;
            t.name = s;
            t.complete = false;

            task.Add(t);
        }
    }
    class Program
    
    static void Main(string[] args)
    {
    }
    
}
