namespace DesignPattern.Observer.Models
{
    internal class Class
    {
        public string Attribute1 { get; private set; }
        public string Attribute2 { get; private set; }
        public string Attribute3 { get; private set; }
        public string Attribute4 { get; private set; }

        public Class(string attribute1, string attribute2, string attribute3, string attribute4)
        {
            Attribute1 = attribute1;
            Attribute2 = attribute2;
            Attribute3 = attribute3;
            Attribute4 = attribute4;
        }
    }
}
