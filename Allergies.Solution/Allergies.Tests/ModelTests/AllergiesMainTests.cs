using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    [TestMethod]
    public void GetAllergies_PrintsAllAllergiesBasedOnScore_None()
    {
      AllergiesMain allergies = new AllergiesMain();
      CollectionAssert.AreEqual(new List<string>() { "none" }, allergies.GetAllergies(0));
    }

    [TestMethod]
    public void GetAllergies_PrintsAllAllergiesBasedOnScore_TomatoAllergy()
    {
      AllergiesMain allergies = new AllergiesMain();
      CollectionAssert.AreEqual(new List<string>() { "Tomatoes" }, allergies.GetAllergies(16));
    }

    [TestMethod]
    public void GetAllergies_PrintsAllAllergiesBasedOnScore_TomatoAndEggAllergy()
    {
      AllergiesMain allergies = new AllergiesMain();
      CollectionAssert.AreEqual(new List<string>() { "Tomatoes", "Eggs" }, allergies.GetAllergies(17));
    }

    [TestMethod]
    public void GetAllergies_PrintsAllAllergiesBasedOnScore_AllAllergies()
    {
      AllergiesMain allergies = new AllergiesMain();
      CollectionAssert.AreEqual(new List<string>() { "Cats", "Pollen", "Chocolate", "Tomatoes", "Strawberries", "Shellfish", "Peanuts", "Eggs" }, allergies.GetAllergies(255));
    }
  }
}