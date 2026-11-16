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
        }
    }
}
