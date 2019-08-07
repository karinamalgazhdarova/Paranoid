using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Paranoid
{
    class Task
    {
        string taskName;
        DateTime startDateTask;
        string userInput;
        DateTime endDateTask;
        int dateEstimate;
        string description;
        
        public void TaskName()
        {
            try
            {
                Console.WriteLine("Введите имя задачи:");
                taskName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(taskName))
                {
                    throw new Exception("Значение 'Имя задачи' не введено");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                TaskName();

            }
        }
        public String getTaskName() {
            return taskName;
        }

        public void StartDateTask()
        {
            try
            {
                Console.WriteLine("Введите дату начала задачи в формате 00.00.0000:");
                userInput = Console.ReadLine();
               

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    throw new Exception("Значение 'Дата начала задачи' не введено");

                }

                startDateTask = DateTime.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.ToString()}");
                Console.WriteLine($"{ex.Message}");
                StartDateTask();

            }
           
        }
        public DateTime getStartDateTask() {
            return startDateTask;
        }

        public void EndDateTask()
        {
            try
            {
                Console.WriteLine("Введите дату окончания задачи в формате 00.00.0000:");
                userInput = Console.ReadLine();
                

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    throw new Exception("Значение 'Дата окончания задачи' не введено");

                }
                endDateTask = DateTime.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                EndDateTask();

            }
        }
        public DateTime getEndDateTask()
        {
            return endDateTask;
        }

        public void DateEstimateTask()
        {
            try
            {
                Console.WriteLine("Введите оценку по времени: ");
                userInput = Console.ReadLine();
              

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    throw new Exception("Значение 'Оценка по времени' не введено ");

                }

                int i;
               
                if (int.TryParse(userInput, out i) == false)
                {
                    throw new Exception("Значение не соответствует числу");
                }
                dateEstimate = Int16.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                DateEstimateTask();

            }
            if (string.IsNullOrWhiteSpace(userInput))
            {
                throw new Exception("Значение 'Оценка по времени' не введено ");

            }
           
}
        public int getDateEstimateTask()
        {
            return dateEstimate;
        }

       

        public void DescriptionTask()
        {
            try
            {
                Console.WriteLine("Введите описание: ");
                description = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(description))
                {
                    throw new Exception("Значение 'Описание' не введено ");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                DateEstimateTask();

            }
        }
        public String getDescriptionTask()
        {
            return description;
        }


    }
}
