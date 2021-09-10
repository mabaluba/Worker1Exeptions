using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker1Exeptions
{
    class InputData
    {
        public void ArrayOfWorkers(int n, Worker[] workers)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите Фамилию И.О.");
                var a = Console.ReadLine().Trim();

                Console.WriteLine("Введите занимаемую должность.");
                var b = Console.ReadLine().Trim();

                Console.WriteLine("Введите дату вступления в должность.");
                var c = 0;
                try
                {
                    c = int.Parse(Console.ReadLine().Trim());
                    if (c < 1900 || c > 2020)
                    {
                        c = 0;
                        throw Exceptions.YearException();
                    }
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine(/*"Не верный формат года, должно быть число", */e.Message);
                }
                workers[i] = new Worker(a, b, c);
            }

            var workersSorted = workers.OrderBy(i=>i.Initials);
        }
    }
}
