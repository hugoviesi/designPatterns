using DesignPattern.Observer.Interfaces.Services;
using DesignPattern.Observer.Models;
using System;

namespace DesignPattern.Observer.Services
{
    internal class EmailService : IEmailService
    {
        public void Execute(Class @class)
        {
            Console.WriteLine("Enviando Email...");
        }
    }
}
