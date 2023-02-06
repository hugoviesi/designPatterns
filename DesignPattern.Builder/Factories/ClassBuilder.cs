using DesignPattern.Builder.Interfaces.Factories;
using DesignPattern.Builder.Models;

namespace DesignPattern.Builder.Factories
{
    public class ClassBuilder : IClassBuilder
    {
        public string Attribute1 { get; private set; }
        public string Attribute2 { get; private set; }
        public string Attribute3 { get; private set; }
        public string Attribute4 { get; private set; }

        public Class Builder()
            => new (Attribute1, Attribute2, Attribute3, Attribute4);

        public ClassBuilder WithAttribute1(string attribute1)
        {
            Attribute1 = attribute1;

            return this;
        }

        public ClassBuilder WithAttribute2(string attribute2)
        {
            Attribute2 = attribute2;

            return this;
        }

        public ClassBuilder WithAttribute3(string attribute3)
        {
            Attribute3 = attribute3;

            return this;
        }

        public ClassBuilder WithAttribute4(string attribute4)
        {
            Attribute4 = attribute4;

            return this;
        }
    }
}
