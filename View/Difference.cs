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
using System.Windows;

namespace TextComparatorGUI
{
    public partial class Difference : System.Windows.Forms.Form
    {
        private int currentConflict = 0;
        Form previousForm;
        private Text firstText;
        private Text secondText;
        private ITextComparator textComparator;
        private List<Tuple<int, ConflictEnum, string>> firstListOfText = new List<Tuple<int, ConflictEnum, string>>();
        private List<Tuple<int, ConflictEnum, string>> secondListOfText = new List<Tuple<int, ConflictEnum, string>>();
        private List<KeyValuePair<int,int>> firstTextBoxConflicts = new List<KeyValuePair<int, int>>();
        private List<KeyValuePair<int, int>> secondTextBoxConflicts = new List<KeyValuePair<int, int>>();
        public Difference(Form previousForm, ITextComparator textComparator, Text firstText, Text secondText)
        {
            this.previousForm = previousForm;
            this.firstText = firstText;
            this.secondText = secondText;
            this.textComparator = textComparator;
            InitializeComponent();
            Compare();
        }

        private void diffPrev_Click(object sender, EventArgs e)
        {
            if (currentConflict == 0) return;
            scrollToDiff(currentConflict - 1);
            currentConflict--;
            updateView();
        }

        private void Compare()
        {
            textComparator.MakeComparison(firstText, secondText);
            List<KeyValuePair<int, string>> listOfTexts = textComparator.ListOfTexts;
            splitDifferences(listOfTexts);
            fillTextBox(firstTextBox, firstListOfText, firstTextBoxConflicts);
            fillTextBox(secondTextBox, secondListOfText, secondTextBoxConflicts);
            scrollToDiff(currentConflict);
            updateView();
            this.Enabled = true;
            this.UseWaitCursor = false;
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

        private void fillTextBox(RichTextBox richTextBox, List<Tuple<int, ConflictEnum, string>> listOfText, List<KeyValuePair<int, int>> textBoxConflicts)
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
                    textBoxConflicts.Add(new KeyValuePair<int,int>(counter + 1, text.Item1));
                }
                richTextBox.AppendText(text.Item3);
                counter = richTextBox.Text.Length;
            }
        }

        private void diffNext_Click(object sender, EventArgs e)
        {

            if (currentConflict == firstTextBoxConflicts.Count - 1) return;
            scrollToDiff(currentConflict + 1);
            currentConflict++;
            updateView();
        }
        private void scrollToDiff(int index)
        {
            if (firstTextBoxConflicts.Count <= index) return;
            var firstPosition = firstTextBoxConflicts[index].Key;
            var secondPosition = secondTextBoxConflicts[index].Key;
            firstTextBox.SelectionStart = firstPosition;
            firstTextBox.ScrollToCaret();
            secondTextBox.SelectionStart = secondPosition;
            secondTextBox.ScrollToCaret();
        }
        private void updateView()
        {
            diffNext.Enabled = firstTextBoxConflicts.Count - 1 == currentConflict ? false : true;
            diffPrev.Enabled = currentConflict == 0 ? false : true;
            diffCount.Text = (currentConflict+1).ToString() + "/" + firstTextBoxConflicts.Count;
        }

        private void diffJump_Click(object sender, EventArgs e)
        {
            string result;
            while (true)
            {
                result = InputDialog.ShowDialog("Enter difference index", "Jump to");
                if (result == "") return;
                if (Int32.Parse(result) > firstTextBoxConflicts.Count || Int32.Parse(result) - 1 < 0) result = InputDialog.ShowDialog("Enter correct difference index", "Jump to");
                else break;
            }
            scrollToDiff(Int32.Parse(result) - 1);
            currentConflict = Int32.Parse(result) - 1;
            updateView();
        }
    }
}
