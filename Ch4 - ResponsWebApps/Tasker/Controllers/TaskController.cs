using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasker.Models;

namespace Tasker.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            Task task = new Task();
            List<Task> tasks = task.GetTasks();
            return View(tasks);
        }
    }
}