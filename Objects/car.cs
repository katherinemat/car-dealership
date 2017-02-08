using System;
using System.Collections.Generic;

namespace CarDealership.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _cars = new List<Car> {};

    public void SetMakeModel(string newMakeModel)
    {
      _makeModel = newMakeModel;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetPrice(int newPrice)
    {
      if (newPrice >= 0) {
        _price = newPrice;
      }
      else {
        Console.WriteLine("Price needs to be positive");
      }
    }
    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_price < (maxPrice + 100) && _miles < maxMiles);
    }

    public Car(string carMakeModel, int carPrice, int carMiles)
    {
      _makeModel = carMakeModel;
      _price = carPrice;
      _miles = carMiles;
    }
    public void Save()
    {
      _cars.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _cars;
    }

    public static void ClearAll()
    {
      _cars.Clear();
    }

  }
}
