using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tasker.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskBody { get; set; }
        public DateTime DueDate { get; set; }

        public List<Task> GetTasks()
        {
            return new List<Task>()
            {
                new Task ()
                {
                    TaskID = 1
                    , TaskTitle = "Review MVC tutorials"
                    , TaskBody = "Make some time to view MVA videos"
                    , DueDate = DateTime.Now
                },
                new Task ()
                {
                    TaskID = 2
                    , TaskTitle = "Create Test Project"
                    , TaskBody = "Create a test project for demo at work"
                    , DueDate = DateTime.Now.AddDays(1)
                },
                new Task () {
                    TaskID = 3
                    , TaskTitle = "Lunch with Mary"
                    , TaskBody = "Remember to make lunch reservations"
                    , DueDate = DateTime.Now.AddDays(2) },
                new Task ()
                {
                    TaskID = 4
                    , TaskTitle = "Car Service"
                    , TaskBody = "Have the car serviced before trip to HQ"
                    , DueDate = DateTime.Now.AddDays(3)
                }
            };
        }
    }
}