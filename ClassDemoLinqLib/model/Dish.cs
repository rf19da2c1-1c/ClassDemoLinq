using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoLinqLib.model
{
    public class Dish : MenuItem
    {
        // instance field
        private String _typeOfDish;

        // properties
        public string TypeOfDish
        {
            get => _typeOfDish;
            set => _typeOfDish = value;
        }

        // Constructor
        public Dish() : this("dummy", "someDish", 0.0)
        {
        }

        public Dish(string name, string typeOfDish, double price) : base(name, price)
        {
            _typeOfDish = typeOfDish;
        }

        public Dish(string name, string typeOfDish, double price,int recommended) : base(name, price, recommended)
        {
            _typeOfDish = typeOfDish;
        }

        // To String
        public override string ToString()
        {
            return base.ToString() + $", {nameof(TypeOfDish)}: {TypeOfDish}";
        }
    }
}
