using System;

namespace Worker1Exeptions
{
    static class Exceptions
    {
        public static Exception YearException()
        {
            Exception exception = new Exception("Год должен быть от 1900 до 2020.");
            
            return exception;
        }
    }
}