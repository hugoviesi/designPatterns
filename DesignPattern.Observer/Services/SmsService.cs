using DesignPattern.Observer.Interfaces.Services;
using DesignPattern.Observer.Models;
using System;

namespace DesignPattern.Observer.Services
{
    internal class SmsService : ISmsService
    {
        public void Execute(Class @class)
        {
            Console.WriteLine("Enviando SMS...");
        }
    }
}
