﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı");
        }
    }
}
