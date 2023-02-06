using DesignPattern.Observer.Factories;

namespace DesignPattern.Observer.Interfaces.Factories
{
    internal interface IClassBuilder
    {
        ClassBuilder WithAttribute1(string attribute1);
        ClassBuilder WithAttribute2(string attribute2);
        ClassBuilder WithAttribute3(string attribute3);
        ClassBuilder WithAttribute4(string attribute4);
    }
}
