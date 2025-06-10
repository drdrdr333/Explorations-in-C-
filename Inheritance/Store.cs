using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace Inheritance
{
    internal class Store : Building
    {
        private int _id;
        private int _amtOfAisles;
        private string _specialty = string.Empty;

        public int Id { 
            get => _id;
            set => _id = value;
        }

        public int Aisles { 
            get => _amtOfAisles;
            set 
            {
                if (value <= 0) { 
                    throw new ArgumentOutOfRangeException("Store should not have 0 ailes...");
                }
                _amtOfAisles = value;
            }
        }

        public string Specialty { 
            get => _specialty;
            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentNullException("Value should not be null or empty for specialty...");
                }
                _specialty = value;
            }
        }

        public Store() : this(1, 4, "No Specialty", "No Name", "No Address") { }

        public Store(int id, int aisles, string specialty, string name) : this(id, aisles, specialty, name, "No address")
        {
        }

        public Store(int id, int aisles, string specialty, string name, string address) : base(name, address) {
            Id = id;
            Aisles = aisles;
            Specialty = specialty;
        }

        public override string PrintAllAttributes()
        {
            return $"{base.PrintAllAttributes()} id: {this.Id} aisles: {this.Aisles} specialty: {this.Specialty}";
        }
    }
}
