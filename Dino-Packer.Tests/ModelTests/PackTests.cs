using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DinoPacker.Models;

namespace DinoPacker.Tests
{

    [TestClass]
    public class PackTest
    {
        [TestMethod]
        public void Pack_CreateInstance_PackObject()
        {
            Pack pack = new Pack();
            Assert.IsInstanceOfType(pack, typeof(Pack));
            CollectionAssert.AreEqual(new List<string>{}, pack.Items);
        }

        public void CheckPack_CheckIfPackContainsAllNeededItems_False()
        {
            Pack pack = new Pack();
            pack.Items.AddRange(new List<string>{"shovel", "water"});
            DinoEra era = new DinoEra();
            List<string> itemsForEra = new List<string> { "shovel", "food", "water", "clothes", "dino-deterrent" };
            era.EraItems.Add("Jurassic", itemsForEra);

            bool packIsReady = pack.CheckPack(era, "Jurrasic");
            Assert.AreEqual(false, packIsReady);
        }
    }
}