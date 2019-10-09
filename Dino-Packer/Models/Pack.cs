using System.Collections.Generic;
using System.Linq;

namespace DinoPacker.Models
{
    public class Pack
    {
        public static Pack Instance = new Pack();
        public List<string> Items { get; set;}
        public Pack()
        {
            Items = new List<string>{};
        }


        public bool CheckPack(DinoEra era, string eraName)
        {
            bool isPackReady = true;
            List<string> requiredItems = era.EraItems[eraName];
            foreach(string item in requiredItems)
            {
                if(!Items.Contains(item))
                {
                    isPackReady = false;
                    break;
                }
            }
            return isPackReady;
        }
        public void AddItems(List<string> newItems)
        {
            Items.AddRange(newItems);
            Items = Items.Distinct().ToList();
        }
    }
}