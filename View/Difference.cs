using FileComparator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextComparatorGUI
{
    public partial class Difference : System.Windows.Forms.Form
    {
        public OpenFile previousForm;
        public Result nextForm;

        private Text firstText;
        private Text secondText;
        private ITextComparator textComparator;
        private List<Tuple<int, ConflictEnum, string>> firstListOfText, secondListOfText;
        private Dictionary<int, int> firstTextBoxConflicts, secondTextBoxConflicts;

        public Difference(ITextComparator textComparator)
        {
            this.textComparator = textComparator;
            InitializeComponent();
        }

        public void initialize(Text firstText, Text secondText)
        {
            this.firstText = firstText;
            this.secondText = secondText;
            firstListOfText = new List<Tuple<int, ConflictEnum, string>>();
            secondListOfText = new List<Tuple<int, ConflictEnum, string>>();
            firstTextBoxConflicts = new Dictionary<int, int>();
            secondTextBoxConflicts = new Dictionary<int, int>();
            firstTextBox.Clear();
            secondTextBox.Clear();
            Compare();
            this.Show();
        }

        private void Compare()
        {
            textComparator.MakeComparison(firstText, secondText);
            List<KeyValuePair<int, string>> listOfTexts = textComparator.ListOfTexts;
            splitDifferences(listOfTexts);
            fillTextBox(firstTextBox, firstListOfText, firstTextBoxConflicts);
            fillTextBox(secondTextBox, secondListOfText, secondTextBoxConflicts);
            this.Enabled = true;
        }

        private void backToOpenFile_Click(object sender, EventArgs e)
        {
            previousForm.initialize();
            this.Hide();
        }

        private void diffJump_Click(object sender, EventArgs e)
        {

        }

        private void diffDone_Click(object sender, EventArgs e)
        {
            nextForm.initialize(firstText);
            this.Hide();
        }

        private void splitDifferences(List<KeyValuePair<int, string>> listOfTexts)
        {
            for (int i = 0; i < listOfTexts.Count; i++)
            {
                if (listOfTexts.Count > (i + 1) && listOfTexts[i].Key == listOfTexts[i + 1].Key)
                {
                    firstListOfText.Add(new Tuple<int, ConflictEnum, string>(listOfTexts[i].Key, ConflictEnum.YES, listOfTexts[i].Value));
                    secondListOfText.Add(new Tuple<int, ConflictEnum, string>(listOfTexts[i + 1].Key, ConflictEnum.YES, listOfTexts[i + 1].Value));
                    i++;
                    continue;
                }
                firstListOfText.Add(new Tuple<int, ConflictEnum, string>(listOfTexts[i].Key, ConflictEnum.NO, listOfTexts[i].Value));
                secondListOfText.Add(new Tuple<int, ConflictEnum, string>(listOfTexts[i].Key, ConflictEnum.NO, listOfTexts[i].Value));
            }
        }

        private void fillTextBox(RichTextBox richTextBox, List<Tuple<int, ConflictEnum, string>> listOfText, Dictionary<int, int> textBoxConflicts)
        {
            int counter = 0;
            foreach (Tuple<int, ConflictEnum, string> text in listOfText)
            {
                richTextBox.SelectionStart = richTextBox.TextLength;
                richTextBox.SelectionLength = 0;
                richTextBox.SelectionColor = Color.Black;
                if (text.Item2 == ConflictEnum.YES)
                {
                    richTextBox.SelectionColor = Color.Red;
                    textBoxConflicts.Add(counter + 1, text.Item1);
                }
                richTextBox.AppendText(text.Item3 + $" [{text.Item1}]");
                counter += text.Item3.Length;
            }
        }
    }
}
