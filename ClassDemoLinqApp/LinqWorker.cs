using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using ClassDemoLinqLib.model;

namespace ClassDemoLinqApp
{
    class LinqWorker
    {
        
        public void Start()
        {
            MenuCard mcard = new MenuCard();
            PopulateDrinks(mcard);
            PopulateDish(mcard);

            //Console.WriteLine(mcard);

            //LinqVælgEnkeltProperty(mcard);
            //LinqVælgFlereProperty(mcard);
            //LinqVælgDrikkeOver40(mcard);
            //LinqVælgDrikkeOver40Ordnet(mcard);
            //LinqVælgeFraTostrukturer(mcard);

            //linqMetodeDrikkeOver40(mcard);
            LinqMetodeFindAll(mcard);



        }

        private void LinqMetodeFindAll(MenuCard mcard)
        {
            var liste = mcard.Drinks.FindAll(d => !d.IsAlcoholic);

            foreach (var drink in liste)
            {
                Console.WriteLine(drink);
            }

        }

        private void linqMetodeDrikkeOver40(MenuCard mcard)
        {
            var liste = mcard.Drinks.Where(d => d.Price > 40).OrderBy(d => d.Price);

            foreach (Drink drink in liste)
            {
                Console.WriteLine(drink);
            }


        }


        private void LinqVælgeFraTostrukturer(MenuCard mcard)
        {
            var liste =
                from d in mcard.Drinks
                join dish in mcard.Dishes on d.Recommended equals dish.Recommended
                where d.Recommended != -1
                orderby dish.Name
                select new {dish.Name, DrinkName = d.Name};

            foreach (var v in liste)
            {
                
                Console.WriteLine($"ret={v.Name} du bør drikke {v.DrinkName}");
            }


        }

        private void LinqVælgDrikkeOver40Ordnet(MenuCard mcard)
        {
            var liste =
                from d in mcard.Drinks
                orderby d.Price
                select d;

            foreach (var drink in liste)
            {
                Console.WriteLine(drink);
            }

        }

        private void LinqVælgDrikkeOver40(MenuCard mcard)
        {
            var liste = 
                from d in mcard.Drinks
                where d.Price > 40
                select d;

            foreach (var drink in liste)
            {
                Console.WriteLine(drink);
            }

        }

        private void LinqVælgFlereProperty(MenuCard mcard)
        {
            // SQL : select Name, Price from Drink

            var liste =
                from d in mcard.Drinks
                select new {d.Name, d.Price};

            foreach (var v in liste)
            {
                Console.WriteLine($"Navn={v.Name} prisen er {v.Price}");
            }

        }

        private void LinqVælgEnkeltProperty(MenuCard mcard)
        {
            var drikkevareNavne = 
                from d in mcard.Drinks
                select d.Name;

            foreach (var drink in drikkevareNavne)
            {
                Console.WriteLine(drink);
            }


        }


        private void PopulateDish(MenuCard mcard)
        {
            mcard.Dishes.Add(new Dish("ministrone", "starter", 46));
            mcard.Dishes.Add(new Dish("ribeye", "main", 158, 1));
            mcard.Dishes.Add(new Dish("lasagne", "main", 95));
            mcard.Dishes.Add(new Dish("ice", "dessert", 38));
            mcard.Dishes.Add(new Dish("crepesuzette", "dessert", 55));
            mcard.Dishes.Add(new Dish("bananasplit", "dessert", 61));
            mcard.Dishes.Add(new Dish("scrimps", "starter", 71));
            mcard.Dishes.Add(new Dish("lopster", "starter", 137));
            mcard.Dishes.Add(new Dish("foiegras", "starter", 110));
            mcard.Dishes.Add(new Dish("chicken", "main", 98, 2));
            mcard.Dishes.Add(new Dish("meetloaf", "main", 88));
            mcard.Dishes.Add(new Dish("lambSteak", "main", 132, 1));

        }

        private void PopulateDrinks(MenuCard mcard)
        {
            mcard.Drinks.Add(new Drink("rioja", "redwine", true, 56.8));
            mcard.Drinks.Add(new Drink("bourgone", "redwine", true, 49.5, 1));
            mcard.Drinks.Add(new Drink("bordeaux", "redwine", true, 116.8, 1));
            mcard.Drinks.Add(new Drink("alsace", "whitewine", true, 72.8, 2));
            mcard.Drinks.Add(new Drink("chile", "whitewine", true, 49));
            mcard.Drinks.Add(new Drink("cablis", "whitewine", true, 93.2));
            mcard.Drinks.Add(new Drink("provance", "rosewine", true, 70));
            mcard.Drinks.Add(new Drink("perrier", "water", false, 22));
            mcard.Drinks.Add(new Drink("rioja riserva", "redwine", true, 68, 1));
            mcard.Drinks.Add(new Drink("fanta", "softdrink", false, 18));
            mcard.Drinks.Add(new Drink("sprite", "softdrink", false, 18));

        }

    }
}