using System;
using Xunit;
using LINQ;
using System.Collections.Generic;

namespace HistoryList.Library
{
    public class HList<T> : List<T>
    {
        public static var History(int listIndex, int itemIndex, out var listItem)
        {
            List<S> histList = new HList[listIndex];
            var listItem = histList[itemIndex;]
        }
    }
}
