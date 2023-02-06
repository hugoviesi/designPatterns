using DesignPattern.Observer.Interfaces.Factories;
using DesignPattern.Observer.Models;
using System.Collections.Generic;

namespace DesignPattern.Observer.Factories
{
    internal class ClassBuilder : IClassBuilder
    {
        public string Attribute1 { get; private set; }
        public string Attribute2 { get; private set; }
        public string Attribute3 { get; private set; }
        public string Attribute4 { get; private set; }

        public ClassBuilder(IList<Action> actionsAfterCriation)
        {
            ActionsAfterCriation = actionsAfterCriation;
        }

        private IList<Action> ActionsAfterCriation { get; set; }

        public Class Builder()
        {
            var classModel = new Class(Attribute1, Attribute2, Attribute3, Attribute4);

            foreach (var action in ActionsAfterCriation)
            {
                action.Execute(classModel);
            }

            return classModel;
        }

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
