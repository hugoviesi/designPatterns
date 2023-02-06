using DesignPattern.Builder.Factories;
using System;

namespace DesignPattern.Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sempre que tivermos um objeto complexo de ser criado,
            // que possui diversos atributos, ou que possui uma lógica de criação complicada,
            // podemos esconder tudo isso em um Builder.

            var builder = new ClassBuilder();

            var modelClass = builder
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
