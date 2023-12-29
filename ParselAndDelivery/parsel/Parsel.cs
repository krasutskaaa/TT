using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParselAndDelivery.parsel;

public class Parsel
{
    public List <Product> Products = new List<Product>();
    public string Customer;



    public void AddProduct(string name, int price, double weight)
    {
        Products.Add(new Product { Name = name, Price = price, Weight = weight });
    }
    public int GetFullPrice()
    {
        int result = 0;
        foreach (var item in Products)
        {
            result += item.Price;
        }
        return result;
    }
    public double GetWeight() 
    {
        double result = 0;
        foreach (var item in Products)
        {
            result += item.Weight;
        }
        return result;
    }
}
