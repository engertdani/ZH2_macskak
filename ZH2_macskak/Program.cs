using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH2_macskak
{
    enum CatBreed { tabby, black, orange }
    internal class Program
    {
        static void Main(string[] args)
        {
            CrazyCatLady margaret = new CrazyCatLady("cats.csv");
            Console.WriteLine("Oldest: " + margaret.OldestCat().AllData());
            Console.WriteLine("Oldest orange: " + margaret.OldestCat(CatBreed.orange).AllData());
            Console.WriteLine("Average orange: " + margaret.AVGage(CatBreed.orange));
            Cat[] kitties =  margaret.SelectCats(CatBreed.tabby);
            foreach(Cat k in kitties)
            {
                Console.WriteLine(k.AllData());
            }
        }
    }
}
