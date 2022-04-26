using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie.Golubev
{
    public class Task
    {

        /// <summary>
        /// Название задачи
        /// </summary>
        public String Title {get; set; }
            /// <summary>
            /// Дата и время завершения задачи
            /// </summary>
        public DateTime Due { get; set; }
        /// <summary>
        /// Отметка о выполнении задачи
        /// </summary>
        public Boolean Done { get; set: }
     }
 }
