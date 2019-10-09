using System.Collections.Generic;

namespace DinoPacker.Models
{
    public class DinoEra
    {
        public Dictionary<string,List<string>> EraItems { get; }
        public static List<Dinosaur> ActiveDinosaurs = new List<Dinosaur>{};
        public static Dictionary<string,List<string>> DinosaurNames {get;set;}
        public DinoEra()
        {
            EraItems = new Dictionary<string,List<string>> {};
            DinosaurNames = new Dictionary<string,List<string>>{};

            List<string> jurassicItems = new List<string>{"shovel", "water", "food", "dino deterrant", "vehicle", "hat", "bug spray"};
            EraItems.Add("Jurassic", jurassicItems);
        }



        
    }
}