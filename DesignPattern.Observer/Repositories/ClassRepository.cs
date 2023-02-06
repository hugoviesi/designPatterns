using DesignPattern.Observer.Interfaces.Repositories;
using DesignPattern.Observer.Models;
using System;

namespace DesignPattern.Observer.Repositories
{
    internal class ClassRepository : IClassRepository
    {
        public void Execute(Class @class)
        {
            Console.WriteLine("Persistindo no repositório...");
        }
    }
}
