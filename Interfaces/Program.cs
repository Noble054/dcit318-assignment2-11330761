using System;

interface IMovable
{
    void Move();
}

class Car:IMovable
{
    public void Move()
    {
        Console.WriteLine("The Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(String[] args)
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();
        bicycle.Move();
        car.Move();

        Console.WriteLine("Press any key to exit ....");
        Console.ReadKey();

    }
    

}