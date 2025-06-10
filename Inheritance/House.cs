using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace Inheritance
{
    internal class House : Building
    {
        private int _id;
        private int _rooms;
        private int _windows;

        public int Id {
            get => _id;
            set => _id = value;
        }

        public int Rooms {
            get => _rooms;
            set {
                if (value <= 0) { 
                    throw new ArgumentOutOfRangeException("Should not have zerorooms...");
                }
                _rooms = value;
            }
        }

        public int Windows { 
            get => _windows;
            set {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Should not have zero windows...");
                }
                _windows = value;
            }
        }

        public House() : this(1, 1, 1, "No Name", "No Address") { }

        public House(int id, int rooms, int windows, string name, string address) : base(name, address) {
            Id = id;
            Rooms = rooms;
            Windows = windows;
        }

        public override string ToString() {
            string s = $" base --> {base.ToString()} and windows -> {this.Windows} rooms -> {this.Rooms}";
            return s;
        }

        public override string PrintAllAttributes()
        {
            return base.PrintAllAttributes();
        }
    }
}
