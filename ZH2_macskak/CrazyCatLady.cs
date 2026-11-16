using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_macskak
{
    internal class CrazyCatLady
    {
        public List<Cat> Cats { get; set; }
        public int SumOfAge
        {
            get
            {
                int sum = 0;
                foreach (Cat c in Cats)
                {
                    sum += c.Age;
                }
                return sum;
            }
        }
        public CrazyCatLady(string filename)
        {
            Cats = new List<Cat>();
            string[] lines = File.ReadAllLines(filename);
            for(int i  = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string name = parts[0];
                DateTime birthdate = DateTime.Parse(parts[1]);
                TimeSpan difInTime = DateTime.Today - birthdate;
                int age = (int)difInTime.TotalDays / 365;
                CatBreed breed = (CatBreed)Enum.Parse(typeof(CatBreed), parts[2]);

                Cats.Add(new Cat(name, age, breed));
            }
        }

        public Cat OldestCat()
        {
            int maxIDX = 0;
            for(int i = 1; i < Cats.Count; i++)
            {
                if(Cats[maxIDX].Age < Cats[i].Age)
                {
                    maxIDX = i;
                }
            }
            return Cats[maxIDX];
        }

        public Cat OldestCat(CatBreed breed)
        {
            int maxIDX = -1;
            int maxAge = int.MinValue;
            for (int i = 0; i < Cats.Count; i++)
            {
                if (Cats[i].Breed == breed)
                {
                    if (maxAge < Cats[i].Age)
                    {
                        maxIDX = i;
                        maxAge = Cats[i].Age;
                    }
                }
            }
            if (maxIDX != -1)
            {
                return Cats[maxIDX];
            }
            else
            {
                return null;
            }
        }

        public double AVGage(CatBreed breed)
        {
            double avgAge = 0;
            int count = 0;
            for(int i = 0; i < Cats.Count; i++)
            {
                if (Cats[i].Breed == breed)
                {
                    avgAge += Cats[i].Age;
                    count++;
                }
            }
            avgAge = avgAge / count;
            return Math.Round(avgAge, 2);
        }

        public Cat[] SelectCats(CatBreed breed)
        {
            List<Cat> selected = new List<Cat>();
            foreach(Cat c in Cats)
            {
                if(c.Breed == breed)
                {
                    selected.Add(c);
                }
            }
            return selected.ToArray();
        }
    }
}
