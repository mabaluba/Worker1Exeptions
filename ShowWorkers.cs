using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker1Exeptions
{
    class ShowWorkers
    {
        private readonly int MaxExp;
        public ShowWorkers()
        {
            Console.WriteLine("Введите максимально допустимый стаж");
            var maxExp/*maxExperience*/ = int.Parse(Console.ReadLine());
            MaxExp = maxExp;
        }
        public void PrintWorkers(Worker[] arr)
        {
            var res = arr
                .Where(i => DateTime.Now.Year-i.HiredDate > MaxExp)
                .Select(i => i.Initials);
            if(!res.Any())
                Console.WriteLine("Нет работника с таким стажем");
            else
            {
                foreach (var x in res)
                {
                    Console.WriteLine($"Стаж у работника {x} превышает {MaxExp}.");
                }
            }
        }
    }


}
