using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Item> items = new List<Item>();
	
        //items contains all the items to buy
        //add the table, paddle and balls with the required quantities
        //Display the price of each item in items
	
        Console.ReadLine();
    }
}

public abstract class Item
{
    protected int price;
    protected float weight;
    abstract public float getFullPrice();
    public float Weight { get {return weight;} }
}