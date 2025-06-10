using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStuff
{
    internal class Dog : IAnmial
    {
        private int _numOfLegs;
        private int _numOfEyes;
        private string _type;
        private string _name;
        private string _description;

        public bool DoesMate { get; set; }
        public DateTime DateDiscovered { get; set; }
        public bool IsPet { get; set; }

        public string Description { get; set; } = "its a dog!!";

        public int NumberOfLegs
        {
            get => _numOfLegs;
            set
            {
                if ((int)value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Value for legs should not be 0");
                }
                _numOfLegs = value;
            }
        }

        public int NumberOfEyes
        {
            get => _numOfEyes;
            set
            {
                if ((int)value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Value for legs should not be 0");
                }
                _numOfEyes = value;
            }
        }


        public string Type
        {
            get => _type;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value should not be null or empty!");
                }
                _type = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value should not be null or empty!");
                }
                _name = value;
            }
        }

        public Dog() : this(4, 2, "Canine",
            "No Name") { }

        public Dog(int numOfLegs, int numOfEyes, string type, string name) : this(numOfLegs, numOfEyes, type, name, true, DateTime.Parse("1936-12-01 14:30:00"), true, "its a dog!") { }

        public Dog(int numOfLegs, int numOfEyes, string type, string name, bool doesMate, DateTime dateDiscovered, bool isPet, string description) { 
            _numOfLegs = numOfLegs;
            _numOfEyes = numOfEyes;
            _type = type;
            _name = name;
            DoesMate = doesMate;
            DateDiscovered = dateDiscovered;
            IsPet = isPet;
            Description = description;
        }
    }
}
