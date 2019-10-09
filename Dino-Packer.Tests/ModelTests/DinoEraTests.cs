using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DinoPacker.Models;

namespace DinoPacker.Tests
{

    [TestClass]
    public class DinoEraTest
    {
        [TestMethod]
        public void DinoEra_CreateInstance_DinoEraObject()
        {
            DinoEra era = new DinoEra();
            Assert.IsInstanceOfType(era, typeof(DinoEra));
            CollectionAssert.AreEqual(new Dictionary<string, List<string>> { }, era.EraItems);
        }

        public void AddEra_AddEraAndItemsToDictionary_UpdateDictionary()
        {
            DinoEra era = new DinoEra();
            List<string> itemsForEra = new List<string>{"shovel", "food", "water", "clothes", "dino-deterrent"};
            era.EraItems.Add("Jurassic", itemsForEra);

            Dictionary<string,List<string>> result = new Dictionary<string, List<string>>{};
            result.Add("Jurassic", itemsForEra);

            CollectionAssert.AreEqual(result, era.EraItems);
        }
    }
}