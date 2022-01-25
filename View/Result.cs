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
    public partial class Result : System.Windows.Forms.Form
    {
        private Text resultText;

        public PrimaryFileWorker fileWorker;

        public Result(PrimaryFileWorker fileWorker)
        {
            this.fileWorker = fileWorker;
            InitializeComponent();
        }

        public void initialize(Text resultText)
        {
            this.resultText = resultText;
            textBox.Clear();
            this.Show();
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Task task=fileWorker.SaveFile(resultText, saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Couldn't open file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
