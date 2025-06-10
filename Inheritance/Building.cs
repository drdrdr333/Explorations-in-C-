using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Building
    {
        private string _name = string.Empty;
        private string _address = string.Empty;

        public string Name { 
            get => _name;
            set {
                if (string.IsNullOrEmpty(value)) { 
                    throw new ArgumentNullException("Value for name should not be empty");
                }
                _name = value;
            }
        }

        public string Address { 
            get => _address;
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value for address should not be empty");
                }
                _address = value;
            }
        }

        public Building() : this("No name", "No address") { }

        public Building(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString() {
            string s = $"{base.ToString()} <-- thats the base to string {this.Address} {this.Name}";
            return s;
        }

        public virtual string PrintAllAttributes() {
            return $" address: {this.Address} name: {this.Name}";
        }
    }
}
