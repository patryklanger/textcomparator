using FileComparator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextComparatorGUI
{
    public class View
    {
        public OpenFile openFile;
        public Difference difference;
        public Result result;

        public View(PrimaryFileWorker primaryFileWorker, ITextComparator textComparator)
        {
            openFile = new OpenFile(primaryFileWorker);
            difference = new Difference(textComparator);
            result = new Result(textComparator);

            openFile.nextForm = difference;
            difference.previousForm = openFile;
            difference.nextForm = result;
        }
    }
}
