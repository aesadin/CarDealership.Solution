using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _listOfCars = new List<Car> {};

//Car newCar = new Car(string Honda, int 3000, int 200,000)
//_listOfCars.Add(this)
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _listOfCars.Add(this);

    }

    public static  List<Car> GetCars()
    {
      return _listOfCars;
    }
  }
}