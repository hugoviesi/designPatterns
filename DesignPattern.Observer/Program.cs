using DesignPattern.Observer.Factories;
using DesignPattern.Observer.Repositories;
using DesignPattern.Observer.Services;
using System;
using System.Collections.Generic;

namespace DesignPattern.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quando o acoplamento da nossa classe está crescendo,
            //ou quando temos diversas ações diferentes a serem executadas após um determinado processo,
            //podemos implementar o Observer.

            var actions = new List<Models.Action>()
            {
                new SmsService(),
                new EmailService(),
                new ClassRepository()
            };

            var modelClass = new ClassBuilder(actions)
                .WithAttribute1("Atributo 01")
                .WithAttribute2("Atributo 02")
                .WithAttribute3("Atributo 03")
                .WithAttribute4("Atributo 04")
                .Builder();

            Console.WriteLine($"{modelClass.Attribute1} | {modelClass.Attribute2} | {modelClass.Attribute3} | {modelClass.Attribute4}");

            Console.ReadKey();
        }
    }
}
