using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paranoid
{
   

    class Program
    {
       

       
        static void Main(string[] args)
        {
            Task task = new Task();
            task.TaskName();
            task.StartDateTask();
            task.EndDateTask();
            task.DateEstimateTask();
            task.DescriptionTask();

            

          

            //Console.WriteLine("                                 ");
            //Console.WriteLine("----------------------------------- ");

            Console.WriteLine("Имя задачи: " + task.getTaskName());
            Console.WriteLine("Дата начала задачи: " + task.getStartDateTask());
            Console.WriteLine("Дата окончания задачи: " + task.getEndDateTask());
            Console.WriteLine("Оценка по времени: " + task.getDateEstimateTask());
            Console.WriteLine("Описание: " + task.getDescriptionTask());

            Console.ReadLine();


        }
    }
}
