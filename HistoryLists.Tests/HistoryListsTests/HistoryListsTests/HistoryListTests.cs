using System;
using Xunit;

namespace HistoryListsTests
{
    public class HistoryListTests
    {
        [Fact]
        public void EmptyListIsEmpty()
        {
            HList SUT = new HList();

            Assert.Null(Hlist[0]);

        }
    }
}
