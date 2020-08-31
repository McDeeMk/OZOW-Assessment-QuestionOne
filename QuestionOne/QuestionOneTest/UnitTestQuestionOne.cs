using NUnit.Framework;

namespace QuestionOneTest
{
    public class Tests
    {
        /// <summary>
        /// Test Sorting of text without the use of a sort method from .Net Library.
        /// </summary>
        [Test]
        public void TestSort()
        {
            Assert.AreEqual("aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy", QuestionOne.Program.SortText("Contrary to popular belief, the pink unicorn flies east"));
        }
    }
}