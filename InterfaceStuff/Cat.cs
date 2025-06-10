using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceStuff;

namespace InterfaceStuff
{
    internal class Cat : IAnmial
    {
        private int _numOfLegs;
        private int _numOfEyes;
        private string _type;
        private string _name;
        private string _description;

        public bool DoesMate { get; set; }
        public DateTime DateDiscovered { get; set; }
      
        public bool IsPet { get; set; }
        public string Description { get; set; } = "its a cat!!";
        
        public int NumberOfLegs {
            get => _numOfLegs;
            set { 
                if((int)value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"Value for legs should not be 0");
                }
                _numOfLegs = value;
            }
        }

        public int NumberOfEyes { 
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

        
        public string Type { 
            get => _type;
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("Value should not be null or empty!");
                }
                _type = value;
            }
        }

        public string Name { 
            get => _name;
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value should not be null or empty!");
                }
                _name = value;
            }
        }


        public Cat() : this(1, 2, "Feline", "No Name") { }
        public Cat(int numOfLegs, int numOfEyes, string type, string name): this(numOfLegs, numOfEyes, type, name, false, DateTime.Parse("2000-12-01 14:30:00"), true, "its a cat!") { }

        public Cat(int numOfLegs, int numOfEyes, string type, string name, bool doesMate, DateTime dateDiscovered, bool isPet, string description) { 
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
