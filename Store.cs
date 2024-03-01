﻿using System.Collections.Generic;

namespace CarShopGUI
{
    public class Store
    {
        public List<Car> CarList { get; set; }

        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var car in CarList)
            {
                totalCost += car.Price;
            }

            ShoppingList.Clear();
            return totalCost;
        }
    }
}