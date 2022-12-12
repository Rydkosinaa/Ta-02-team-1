﻿using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public  class Pizza
{
    List<Ingredient> PizzaIngredients = new List<Ingredient>()
    {
        Ingredient.Dough
    };
     public double PizzaPrice{ get; set; }

    public Pizza()
    {
        PizzaIngredients = new List<Ingredient>(7);
        PizzaPrice = 0;
    }

    public Pizza(Ingredient pizzaIngredients)
    {
       PizzaIngredients.Add(pizzaIngredients);
        PizzaPrice += pizzaIngredients.Price;

    }

    public double AddIngredient(Ingredient ingredient)
    {
        Pizza pizza=new Pizza(ingredient);
        pizza.PizzaPrice += ingredient.Price;
        return pizza.PizzaPrice;
    }

 
    static void Main()
    {

    }
}
public class Ingredient
{
    public static readonly Ingredient Dough = new Ingredient("Dough", 10);
    public static readonly Ingredient Peperoni = new Ingredient("Peperoni", 1);
    public static readonly Ingredient Onion = new Ingredient("Onion", 2);
    public static readonly Ingredient Cheese = new Ingredient("Cheese", 3);
    string Name { get; }
    public double Price { get; }
    public Ingredient(string name, double price){
        Name = name;
        Price = price;  
        
    }

    

}

