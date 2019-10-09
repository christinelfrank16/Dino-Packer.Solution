using System.Collections.Generic;

namespace DinoPacker.Models
{
    public class DinoEra
    {
        public Dictionary<string,List<string>> EraItems { get; }
        public DinoEra()
        {
            EraItems = new Dictionary<string,List<string>> { };
        }

        
    }
}