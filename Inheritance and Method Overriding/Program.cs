using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sounds");


    }
}

class  Dog:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark!! Bark!!! ");
    }

}

class Cat:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("meow meow meow");
    }
}

class  Program
{
   static void Main(string[] args)
    {
        Animal parentAnimal = new Animal();
        Dog childdog = new Dog();
        Cat childcat = new Cat();

        parentAnimal.MakeSound();
        childdog.MakeSound();
        childcat.MakeSound();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    } 
}   