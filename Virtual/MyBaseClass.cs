using System.Runtime.CompilerServices;
using static System.String;

namespace Virtual
{
    public class MyBaseClass
    {
        public virtual string Name { get; set; }

        private int _num;

        public virtual int Number
        {
            get => _num;
            set => _num = value;
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        private string _name;

        public override string Name
        {
            get => _name;
            set => _name = value != Empty ? value : "Unknown";
        }
    }
}