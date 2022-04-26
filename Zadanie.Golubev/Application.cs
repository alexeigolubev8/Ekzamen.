using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.Golubev
{
    public class Application
    {
        ptivate Application application;
        private List<TaskList> taskLists;
        /// <summary>
        /// Создаёт объект
        /// </summary>
        public Application()
        {
            TaskList taskList = new TaskList("Входящие");

            taskLists = new List<TaskList>();

            taskLists.Add(taskList);
        }
        /// <summary> 
        /// Возвращает ссылку на экземпляр приложения, а вего отсутствие создает экземпляр 
        /// </summary> 
        /// <returns></returns> 
        public Application GetApplication()
        {
            if (Application != null)
                return Application;

            Application = new Application();
            return Application;
        }
        /// <summary> 
        /// Cоздает список с задачами и добавляет его в список со списками задач 
        /// </summary> 
        /// <param name="name"></param> 
        public void CreateTaskList(string name)
        {
            TaskList taskList = new TaskList(name);

        }


}

