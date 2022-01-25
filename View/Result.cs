using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileComparator;


namespace TextComparatorGUI
{
    public partial class Result : System.Windows.Forms.Form
    {
        private IFileReader fileReader;
        public Difference previousForm;
        private ITextComparator textComparator;
        public Result(ITextComparator textComparator)
        {
            this.textComparator = textComparator;
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            //Text text = fileReader.ReadFile("C:/Users/aadam/Documents/IO/lab1.txt");
            Text text = textComparator.ResultText;
            resultTextBox.AppendText(text.Content);
        }

        private void fileCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void initialize()
        {

        }
    }
}
