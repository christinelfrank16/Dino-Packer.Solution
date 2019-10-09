using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DinoPacker.Models;

namespace DinoPacker.Tests
{
    [TestClass]
    public class DinosaurTest
    {
        [TestMethod]
        public void Dinosaur_CreatesAndAddsToDinoEraList_AddedObject()
        {
            Dinosaur dinosaur = new Dinosaur("T-Rex");
            Assert.IsInstanceOfType(dinosaur, typeof(Dinosaur));
            CollectionAssert.AreEquivalent(new List<Dinosaur>{dinosaur}, DinoEra.ActiveDinosaurs);
        }
        
    }
}