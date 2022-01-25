using System;
using System.Collections.Generic;

namespace FileComparator
{
    public interface ITextComparator
    {
        public void MakeComparison(Text text1, Text text2);
        public List<KeyValuePair<int, string>> ListOfTexts { get; }
    }
}
