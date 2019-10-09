using System.Collections.Generic;

namespace DinoPacker.Models
{
    public class Pack
    {
        public List<string> Items { get; }
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
    }
}