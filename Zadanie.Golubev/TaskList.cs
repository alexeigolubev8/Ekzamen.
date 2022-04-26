using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.Golubev
{
    public class TaskList
    {
        private String name;
        private List<Task> tasks;
        /// <summary>
        /// Создаёт объект TaskList
        /// </summary>
        /// <param name="name"></param>
        public TaskList(String name)
        {
            this.name = name;
            tasks = new List<Task>();
        }
        /// <summary>
        ///  Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public String GetName()
        {
            return name;
        }
        /// <summary> 
        /// Добавляет задачу в список задач 
        /// </summary> 
        /// <param name="task"></param> 
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary> 
        /// Возвращает список всех задач 
        /// </summary> 
        /// <returns></returns> 
        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary> 
        /// Удаляет задачу из списка задач 
        /// </summary> 
        /// <param name="task"></param> 
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }

        /// <summary> 
        /// Возвращает список задач на сегодня в хронологическом порядке 
        /// </summary> 
        /// <returns></returns> 
        public List<Task> GetTasksByToday()
        {
            List<Task> tasksByToday = new List<Task>();

            foreach (var task in tasks)
            {
                if (task.Due == DateTime.Now)
                {
                    tasksByToday.Add(task);
                }
            }

            return tasksByToday;
        }
        public List<Task> GetTasksByFuture()
        {
            List<Task> tasksByToday = new List<Task>();

                foreach (var task in tasks)
                {
                    if (task.Due > DateTime.Now)
                    {
                        tasksByToday.Add(task);
                    }
                return tasksByToday;



            }
}
