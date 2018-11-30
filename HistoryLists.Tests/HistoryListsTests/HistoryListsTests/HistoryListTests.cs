using System;
using Xunit;

namespace HistoryListsTests
{
    public class HistoryListTests
    {
        [Fact]
        public void EmptyListIsEmpty()
        {
            HList SUT = new HList<string>();

            Assert.Null(Hlist[0]);

        }

        [Theory]

        [InlineData(new string[] {"a", "b", "c"}, new string[] {"c", "b", "a"}, new string[] {"Yo mama", "My mama", "Hot mama"}, 2, 2, "Hot mama")]
        public void RecallOldStringsFromList(string[] firstSet, string[] secondSet, string[] thirdSet, int firstRef, int secondRef, string expected)
        {
            // arrange
            HList SUT = new HList<string>();
            foreach (string item in firstSet)
            {
                SUT.Add(item);
            }
            SUT.Clear();

            foreach (string item in secondSet)
            {
                SUT.Add(item);
            }
            SUT.Clear();
            foreach (string item in thirdSet)
            {
                SUT.Add(item);
            }

            // act
            string actual = HList.History(firstRef, secondRef);

            // assert
            Assert.Equal(actual, expected);

        }
    }
}
