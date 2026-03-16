namespace Skyline.DataMiner.Utils.MyNuGet.UnitTests
{
	[TestClass]
	public class Class1Tests
	{
		/// <summary>
		/// Tests that the IsOk method returns true when called.
		/// Input: None.
		/// Expected: Method returns true.
		/// </summary>
		[TestMethod]
		public void IsOk_WhenCalled_ReturnsTrue()
		{
			// Arrange
			Class1 sut = new Class1();

			// Act
			bool result = sut.IsOk();

			// Assert
			Assert.IsTrue(result);
		}
	}
}