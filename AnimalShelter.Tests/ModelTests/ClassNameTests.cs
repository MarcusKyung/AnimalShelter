using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System;

namespace ProjectName.Tests
{
  [TestClass]
  public class ClassNameTests : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }
    // Test methods go here
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   Assert.AreEqual(ExpectedResult, CodeToTest);
    // }

    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      Category newCategory = new Category("test category");
      Assert.AreEqual(typeof(Category), newCategory.GetType());
    }


  }
}

      // [TestMethod]
      // public void AddItem_AssociatesItemWithCategory_ItemList()
      // {
      //   //Arrange
      //   string description = "Walk the dog.";
      //   Item newItem = new Item(description);
      //   List<Item> newList = new List<Item> { newItem };
      //   string name = "Work";
      //   Category newCategory = new Category(name);
      //   newCategory.AddItem(newItem);

      //   //Act
      //   List<Item> result = newCategory.Items;

      //   //Assert
      //   CollectionAssert.AreEqual(newList, result);
      // }