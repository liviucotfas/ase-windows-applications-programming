using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBindingSample.ViewModel;

namespace DataBindingSample.Tests
{
	[TestClass]
	public class MainFormViewModelUnitTest
	{
		[TestMethod]
		public void AddParticipantTestMethod()
		{
			//Unit testing basics: https://msdn.microsoft.com/en-us/library/hh694602.aspx

			// arrange
			var viewModel = new MainFormViewModel();

			// act
			viewModel.AddParticipant();

			// assert  
			Assert.AreEqual(viewModel.Participants.Count, 1);
		}
	}
}
