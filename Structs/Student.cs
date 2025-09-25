using System;
using ConsoleApp1.Enums;
namespace ConsoleApp1.Structs
{
    public struct DrinkType
    {
        public string Name { get; set; }
        public double AlcoholPercent { get; set; }

        public DrinkType(string name, double alcoholPercent)
        {
            Name = name;
            AlcoholPercent = alcoholPercent;
        }
    }
    public struct Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Identifier { get; set; }
        public DateTime BirthDate { get; set; }
        public AlcoholismCategory AlcoholismCategory { get; set; }
        public DrinkType Drink { get; set; }
        public double VolumeConsumed { get; set; } 
        public Student(string lastName, string firstName, int identifier, DateTime birthDate,
                       AlcoholismCategory alcoholismCategory, DrinkType drink, double volumeConsumed)
        {
            LastName = lastName;
            FirstName = firstName;
            Identifier = identifier;
            BirthDate = birthDate;
            AlcoholismCategory = alcoholismCategory;
            Drink = drink;
            VolumeConsumed = volumeConsumed;
        }
        public double GetAlcoholVolume()
        {
            return VolumeConsumed * (Drink.AlcoholPercent / 100.0);
        }
        public override string ToString()
        {
            return $"Студент: {FirstName} {LastName}, ID: {Identifier}, Категория: {AlcoholismCategory}, " +
                   $"Напиток: {Drink.Name} ({Drink.AlcoholPercent}%), Объем: {VolumeConsumed} л";
        }
    }
}
