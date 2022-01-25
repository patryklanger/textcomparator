using FileComparator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComparatorGUI
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            ITextComparator textComparator = new PrimaryTextComparator();
            View view = new View(new PrimaryFileWorker(), textComparator);
            Application.Run(view.openFile);
        }
    }
}
