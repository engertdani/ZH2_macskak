using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_macskak
{
    internal class Cat
    {
        //privát adattagok, mezők
        string name; //alapból privát
        int age;
        CatBreed breed;

        public Cat(string name, int age, CatBreed breed)
        {
            this.name = name;
            this.age = age;
            this.breed = breed;
        }

        //publikus tulajdosnágok
        public string Name {  get { return name; }}
        public int Age 
        {
            get 
            {
                return age;
            }
            set
            {
                if(value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The age value cannot be negative!");
                    Console.ResetColor();
                }
            }
        }
        public CatBreed Breed { get { return breed; } }

        public string AllData()
        {
            return $"{name} ({breed}): {age} years old ";
        }
    }
}
