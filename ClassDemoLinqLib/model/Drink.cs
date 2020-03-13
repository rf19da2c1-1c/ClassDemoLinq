using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoLinqLib.model
{
    public class Drink : MenuItem
    {
        // instance fields
        private String _typeOfDrink;
        private bool _isAlcoholic;


        // Properties
        public string TypeOfDrink
        {
            get => _typeOfDrink;
            set => _typeOfDrink = value;
        }

        public bool IsAlcoholic
        {
            get => _isAlcoholic;
            set => _isAlcoholic = value;
        }

        // Constructor
        public Drink() : this("dummy", "somedrink", true, 0.0)
        {
        }

        public Drink(string name, string typeOfDrink, bool isAlcoholic, double price) : this(name,typeOfDrink,isAlcoholic,price, -1)
        {
            _typeOfDrink = typeOfDrink;
            _isAlcoholic = isAlcoholic;
        }
        public Drink(string name, string typeOfDrink, bool isAlcoholic, double price,int recommended) : base(name, price, recommended)
        {
            _typeOfDrink = typeOfDrink;
            _isAlcoholic = isAlcoholic;
        }

        // To String
        public override string ToString()
        {
            return base.ToString() + $", {nameof(TypeOfDrink)}: {TypeOfDrink}, {nameof(IsAlcoholic)}: {IsAlcoholic}";
        }
    }
}
