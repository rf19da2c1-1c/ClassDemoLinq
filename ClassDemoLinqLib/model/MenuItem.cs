using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoLinqLib.model
{
    public class MenuItem
    {
        // Instance fields
        protected String _name;
        protected double _price;
        protected int _recommended;


        // properties
        public string Name
        {
            get => _name;
            set
            {
                // always make the check before setting the value
                if (string.IsNullOrEmpty(value) || value.Length < 3 || 60 < value.Length)
                {
                    throw new ArgumentException($"Name is not between 3-60 characters it was {value}");
                }

                _name = value;
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                // always make the check before setting the value
                if (value < 0)
                {
                    throw new ArgumentException($"Price is not equal or above zero but it was {value}");
                }

                _price = value;
            }
        }

        public int Recommended
        {
            get => _recommended;
            set => _recommended = value;
        }

        // constructor
        public MenuItem() : this("dummy", 0.0, -1)
        {
        }

        public MenuItem(string name, double price) : this(name, price, -1)
        {
        }
        public MenuItem(string name, double price, int recommended)
        {
            Name = name;
            Price = price;
            _recommended = recommended;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price}";
        }

    }
}
