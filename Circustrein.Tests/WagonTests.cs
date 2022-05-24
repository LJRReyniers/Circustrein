using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Circustrein.Tests
{
    [TestClass]
    public class WagonTests
	{
		private Wagon _wagon;

		[TestInitialize]

		public void Setup()
		{
			_wagon = new Wagon();
		}

		[TestMethod]
		public void Wagon_Can_Be_Constructed_With_Default_Capacity()
		{
			// Arrange

			// Act

			//Assert
			Assert.IsNotNull(_wagon);
			Assert.AreEqual(10, _wagon.Volume);
		}

		[TestMethod]
		public void When_Animal_Is_Added_Capacity_Is_Lower()
		{
			// Arrange
			Animal a = Herbivore;
			int originalCapacity = _wagon.Capacity;
			int animalSize = (int)a.Size;
			int expectedCapacity = originalCapacity – animalSize;

			// Act
			_wagon.AddAnimal(a);

			// Assert
			Assert.AreEqual(expectedCapacity, _wagon.Capacity);
		}


	}

}
