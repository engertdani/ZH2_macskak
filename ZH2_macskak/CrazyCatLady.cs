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
    }
}
