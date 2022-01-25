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
        private class ConflictData
        {
            public int textID, textPosition, textLength;
            public ConflictState conflictState;

            public ConflictData(int textID, int textPosition, int textLength, ConflictState conflictState)
            {
                this.textID = textID;
                this.textPosition = textPosition;
                this.textLength = textLength;
                this.conflictState = conflictState;
            }
        }
        public OpenFile previousForm;
        public Result nextForm;
        private Text firstText;
        private Text secondText;
        private ITextComparator textComparator;
        private List<Tuple<int, ConflictEnum, string>> firstListOfText = new List<Tuple<int, ConflictEnum, string>>();
        private List<Tuple<int, ConflictEnum, string>> secondListOfText = new List<Tuple<int, ConflictEnum, string>>();
        private Dictionary<int, ConflictData> firstConflicts, secondConflicts;
        private List<KeyValuePair<int,int>> firstTextBoxConflicts = new List<KeyValuePair<int, int>>();
        private List<KeyValuePair<int, int>> secondTextBoxConflicts = new List<KeyValuePair<int, int>>();
        public Difference(ITextComparator textComparator)
        {
            this.textComparator = textComparator;
            InitializeComponent();
        }

        private void diffPrev_Click(object sender, EventArgs e)
        {
            if (currentConflict == 0) return;
            scrollToDiff(currentConflict - 1);
            currentConflict--;
            updateView();
        }
        public void initialize(Text firstText, Text secondText)
        {
            this.firstText = firstText;
            this.secondText = secondText;
            firstListOfText = new List<Tuple<int, ConflictEnum, string>>();
            secondListOfText = new List<Tuple<int, ConflictEnum, string>>();
            firstTextBoxConflicts = new List<KeyValuePair<int, int>>();
            secondTextBoxConflicts = new List<KeyValuePair<int, int>>();
            firstConflicts = new Dictionary<int, ConflictData>();
            secondConflicts = new Dictionary<int, ConflictData>();
            currentConflict = 0;
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
            fillTextBox(firstTextBox, firstListOfText, firstTextBoxConflicts, firstConflicts);
            fillTextBox(secondTextBox, secondListOfText, secondTextBoxConflicts, secondConflicts);
            scrollToDiff(currentConflict);
            updateView();
            this.Enabled = true;
            this.UseWaitCursor = false;
        }

        private void backToOpenFile_Click(object sender, EventArgs e)
        {
            previousForm.initialize();
            this.Hide();
        }

        private void diffDone_Click(object sender, EventArgs e)
        {
            nextForm.Show();
        }

        private void difference(object sender, EventArgs e)
        {

        }

        private void Difference_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void fillTextBox(RichTextBox richTextBox, List<Tuple<int, ConflictEnum, string>> listOfText, List<KeyValuePair<int, int>> textBoxConflicts, Dictionary<int, ConflictData> conflicts)
        {
            int counter = 0;
            for (int i = 0; i < listOfText.Count; i++)
            {
                int cursor = richTextBox.SelectionStart = richTextBox.TextLength;
                richTextBox.SelectionLength = 0;
                richTextBox.SelectionColor = Color.Black;
                if (listOfText[i].Item2 == ConflictEnum.YES)
                {
                    richTextBox.SelectionBackColor = Color.FromArgb(247, 157, 159);
                    textBoxConflicts.Add(new KeyValuePair<int, int> (counter + 1, listOfText[i].Item1));
                    richTextBox.AppendText(listOfText[i].Item3);
                    conflicts.Add(conflicts.Count, new ConflictData(listOfText[i].Item1, cursor, richTextBox.SelectionStart - cursor, ConflictState.UNDEFINED));
                }
                else
                    richTextBox.AppendText(listOfText[i].Item3);
                counter = richTextBox.Text.Length;
            }
        }

        private void diffBasic_Click(object sender, EventArgs e)
        {
            ConflictState conflictState;
            Color firstBoxColor, secondBoxColor;

            if (sender.Equals(diffFirst))
            {
                conflictState = ConflictState.FIRST;
                firstBoxColor = Color.FromArgb(177, 254, 197);
                secondBoxColor = Color.Red;
            }
            else if (sender.Equals(diffSecond))
            {
                conflictState = ConflictState.SECOND;
                firstBoxColor = Color.Red;
                secondBoxColor = Color.FromArgb(177, 254, 197);
            }
            else
            {
                conflictState = ConflictState.DELETE;
                firstBoxColor = Color.Red;
                secondBoxColor = Color.Red;
            }

            ConflictData temp = firstConflicts[currentConflict];
            temp.conflictState = conflictState;

            firstTextBox.SelectionStart = temp.textPosition;
            firstTextBox.SelectionLength = temp.textLength;
            firstTextBox.SelectionBackColor = firstBoxColor;

            temp = secondConflicts[currentConflict];
            temp.conflictState = conflictState;

            secondTextBox.SelectionStart = temp.textPosition;
            secondTextBox.SelectionLength = temp.textLength;
            secondTextBox.SelectionBackColor = secondBoxColor;
        }
        private void diffRest_Click(object sender, EventArgs e)
        {
            object delegateTo;
            if (sender.Equals(diffFirstRest))
                delegateTo = diffFirst;
            else if (sender.Equals(diffSecondRest))
                delegateTo = diffSecond;
            else
                delegateTo = diffDelete;

            foreach (KeyValuePair<int, ConflictData> cd in firstConflicts)
            {
                if (cd.Value.conflictState == ConflictState.UNDEFINED)
                {
                    currentConflict = cd.Key;
                    diffBasic_Click(delegateTo, null);
                }
            }
        }
        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            int caretPosition = ((RichTextBox)sender).SelectionStart;

            foreach (KeyValuePair<int, ConflictData> cd in firstConflicts)
            {
                if (Enumerable.Range(cd.Value.textPosition, cd.Value.textPosition + cd.Value.textLength).Contains(caretPosition))
                {
                    currentConflict = cd.Key;
                    scrollToDiff(currentConflict);
                }
            }
            updateView();
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
