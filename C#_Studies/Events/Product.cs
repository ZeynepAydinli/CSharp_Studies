using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events;

public delegate void StockControl(); //delegate

public class Product
{
    private int _stock;

    public Product(int stock)
    {
        _stock = stock;
    }

    public event StockControl StockControlEvent; //event

    public string ProductName { get; set; }
    public int Stock {
        get
        {
            return _stock;
        }
        set
        {
            _stock = value;
            if (value <= 15 && StockControlEvent != null)
            {
                StockControlEvent();
            }
        }
     }       

    public void Sell(int amount)
    {
        Stock = Stock - amount; 
        Console.WriteLine("Stock amount: " + Stock + " " + ProductName);
    }
}
