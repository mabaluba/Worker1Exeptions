using System;
using System.Runtime.CompilerServices;

namespace Worker1Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 3;//количество записей
            var workers = new Worker[n];//создание пустого массива экз рабочих

            InputData data1 = new InputData();//создание экз для введения данных о рабочих
            data1.ArrayOfWorkers(n,workers);//введение информации о рабочих, упорядочение массива рабочих по алфавиту

            ShowWorkers expireExperienceWorkers = new ShowWorkers();
            expireExperienceWorkers.PrintWorkers(workers);//вывод фамилии, если стаж больше заданного числа лет
        }
    }
}
