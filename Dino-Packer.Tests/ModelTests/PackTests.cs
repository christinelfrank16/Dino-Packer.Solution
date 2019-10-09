using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DinoPacker.Models;
using System;

namespace DinoPacker.Tests
{

    [TestClass]
    public class PackTest
    {
        [TestMethod]
        public void Pack_CreateInstance_PackObject()
        {
            Pack pack = Pack.Instance;
            Assert.IsInstanceOfType(pack, typeof(Pack));
            CollectionAssert.AreEqual(new List<string>{}, pack.Items);
        }
        [TestMethod]
        public void CheckPack_CheckIfPackContainsAllNeededItems_False()
        {
            Pack pack = new Pack();
            pack.Items.AddRange(new List<string>{"shovel", "water"});
            DinoEra era = new DinoEra();
            List<string> itemsForEra = new List<string> { "shovel", "food", "water", "clothes", "dino-deterrent" };
            era.EraItems.Add("Jurassic", itemsForEra);

            bool packIsReady = pack.CheckPack(era, "Jurassic");
            Assert.AreEqual(false, packIsReady);
        }
        [TestMethod]
        public void AddItems_AddItemsToPack_AddedItem()
        {
            Pack pack = new Pack();
            pack.Items.AddRange(new List<string> {"water","food"});
            pack.AddItems(new List<string>{"shovel","water"});
            Console.WriteLine(pack.Items[0]);
            CollectionAssert.AreEquivalent(new List<string> {"shovel", "water","food" },pack.Items);
        }
        
    }
}