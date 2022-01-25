
namespace TextComparatorGUI
{
    partial class Difference
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstTextBox = new System.Windows.Forms.RichTextBox();
            this.secondTextBox = new System.Windows.Forms.RichTextBox();
            this.diffPrev = new System.Windows.Forms.Button();
            this.diffNext = new System.Windows.Forms.Button();
            this.diffConst = new System.Windows.Forms.Label();
            this.diffCount = new System.Windows.Forms.Label();
            this.diffJump = new System.Windows.Forms.Button();
            this.diffFirst = new System.Windows.Forms.Button();
            this.diffSecond = new System.Windows.Forms.Button();
            this.diffDelete = new System.Windows.Forms.Button();
            this.diffFirstRest = new System.Windows.Forms.Button();
            this.diffSecondRest = new System.Windows.Forms.Button();
            this.diffDeleteRest = new System.Windows.Forms.Button();
            this.diffDone = new System.Windows.Forms.Button();
            this.backToOpenFile = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(12, 34);
            this.firstTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.ReadOnly = true;
            this.firstTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.firstTextBox.Size = new System.Drawing.Size(389, 650);
            this.firstTextBox.TabIndex = 0;
            this.firstTextBox.Text = "";
            this.firstTextBox.UseWaitCursor = true;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(600, 34);
            this.secondTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.ReadOnly = true;
            this.secondTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.secondTextBox.Size = new System.Drawing.Size(420, 650);
            this.secondTextBox.TabIndex = 1;
            this.secondTextBox.Text = "";
            this.secondTextBox.UseWaitCursor = true;
            // 
            // diffPrev
            // 
            this.diffPrev.Location = new System.Drawing.Point(452, 186);
            this.diffPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffPrev.Name = "diffPrev";
            this.diffPrev.Size = new System.Drawing.Size(86, 35);
            this.diffPrev.TabIndex = 2;
            this.diffPrev.Text = "Previous";
            this.diffPrev.UseVisualStyleBackColor = true;
            this.diffPrev.UseWaitCursor = true;
            // 
            // diffNext
            // 
            this.diffNext.Location = new System.Drawing.Point(452, 318);
            this.diffNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffNext.Name = "diffNext";
            this.diffNext.Size = new System.Drawing.Size(86, 35);
            this.diffNext.TabIndex = 3;
            this.diffNext.Text = "Next";
            this.diffNext.UseVisualStyleBackColor = true;
            this.diffNext.UseWaitCursor = true;
            // 
            // diffConst
            // 
            this.diffConst.AutoSize = true;
            this.diffConst.Location = new System.Drawing.Point(439, 257);
            this.diffConst.Name = "diffConst";
            this.diffConst.Size = new System.Drawing.Size(81, 20);
            this.diffConst.TabIndex = 4;
            this.diffConst.Text = "Difference:";
            this.diffConst.UseWaitCursor = true;
            // 
            // diffCount
            // 
            this.diffCount.AutoSize = true;
            this.diffCount.Location = new System.Drawing.Point(522, 257);
            this.diffCount.Name = "diffCount";
            this.diffCount.Size = new System.Drawing.Size(29, 20);
            this.diffCount.TabIndex = 5;
            this.diffCount.Text = "x/y";
            this.diffCount.UseWaitCursor = true;
            // 
            // diffJump
            // 
            this.diffJump.Location = new System.Drawing.Point(489, 393);
            this.diffJump.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffJump.Name = "diffJump";
            this.diffJump.Size = new System.Drawing.Size(86, 35);
            this.diffJump.TabIndex = 6;
            this.diffJump.Text = "Jump to";
            this.diffJump.UseVisualStyleBackColor = true;
            this.diffJump.UseWaitCursor = true;
            this.diffJump.Click += new System.EventHandler(this.diffJump_Click);
            // 
            // diffFirst
            // 
            this.diffFirst.Location = new System.Drawing.Point(412, 466);
            this.diffFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffFirst.Name = "diffFirst";
            this.diffFirst.Size = new System.Drawing.Size(40, 35);
            this.diffFirst.TabIndex = 7;
            this.diffFirst.Text = "<-";
            this.diffFirst.UseVisualStyleBackColor = true;
            this.diffFirst.UseWaitCursor = true;
            // 
            // diffSecond
            // 
            this.diffSecond.Location = new System.Drawing.Point(535, 466);
            this.diffSecond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffSecond.Name = "diffSecond";
            this.diffSecond.Size = new System.Drawing.Size(40, 35);
            this.diffSecond.TabIndex = 8;
            this.diffSecond.Text = "->";
            this.diffSecond.UseVisualStyleBackColor = true;
            this.diffSecond.UseWaitCursor = true;
            // 
            // diffDelete
            // 
            this.diffDelete.Location = new System.Drawing.Point(475, 466);
            this.diffDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffDelete.Name = "diffDelete";
            this.diffDelete.Size = new System.Drawing.Size(40, 35);
            this.diffDelete.TabIndex = 9;
            this.diffDelete.Text = "X";
            this.diffDelete.UseVisualStyleBackColor = true;
            this.diffDelete.UseWaitCursor = true;
            // 
            // diffFirstRest
            // 
            this.diffFirstRest.Location = new System.Drawing.Point(412, 522);
            this.diffFirstRest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffFirstRest.Name = "diffFirstRest";
            this.diffFirstRest.Size = new System.Drawing.Size(40, 35);
            this.diffFirstRest.TabIndex = 10;
            this.diffFirstRest.Text = "<<-";
            this.diffFirstRest.UseVisualStyleBackColor = true;
            this.diffFirstRest.UseWaitCursor = true;
            // 
            // diffSecondRest
            // 
            this.diffSecondRest.Location = new System.Drawing.Point(535, 522);
            this.diffSecondRest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffSecondRest.Name = "diffSecondRest";
            this.diffSecondRest.Size = new System.Drawing.Size(40, 35);
            this.diffSecondRest.TabIndex = 11;
            this.diffSecondRest.Text = "->>";
            this.diffSecondRest.UseVisualStyleBackColor = true;
            this.diffSecondRest.UseWaitCursor = true;
            // 
            // diffDeleteRest
            // 
            this.diffDeleteRest.Location = new System.Drawing.Point(475, 522);
            this.diffDeleteRest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffDeleteRest.Name = "diffDeleteRest";
            this.diffDeleteRest.Size = new System.Drawing.Size(40, 35);
            this.diffDeleteRest.TabIndex = 12;
            this.diffDeleteRest.Text = "(X)";
            this.diffDeleteRest.UseVisualStyleBackColor = true;
            this.diffDeleteRest.UseWaitCursor = true;
            // 
            // diffDone
            // 
            this.diffDone.Location = new System.Drawing.Point(452, 593);
            this.diffDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffDone.Name = "diffDone";
            this.diffDone.Size = new System.Drawing.Size(86, 35);
            this.diffDone.TabIndex = 13;
            this.diffDone.Text = "Done";
            this.diffDone.UseVisualStyleBackColor = true;
            this.diffDone.UseWaitCursor = true;
            this.diffDone.Click += new System.EventHandler(this.diffDone_Click);
            // 
            // backToOpenFile
            // 
            this.backToOpenFile.Location = new System.Drawing.Point(448, 665);
            this.backToOpenFile.Name = "backToOpenFile";
            this.backToOpenFile.Size = new System.Drawing.Size(94, 29);
            this.backToOpenFile.TabIndex = 14;
            this.backToOpenFile.Text = "Back";
            this.backToOpenFile.UseVisualStyleBackColor = true;
            this.backToOpenFile.UseWaitCursor = true;
            this.backToOpenFile.Click += new System.EventHandler(this.backToOpenFile_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(412, 398);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 27);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.UseWaitCursor = true;
            // 
            // Difference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 769);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.backToOpenFile);
            this.Controls.Add(this.diffDone);
            this.Controls.Add(this.diffDeleteRest);
            this.Controls.Add(this.diffSecondRest);
            this.Controls.Add(this.diffFirstRest);
            this.Controls.Add(this.diffDelete);
            this.Controls.Add(this.diffSecond);
            this.Controls.Add(this.diffFirst);
            this.Controls.Add(this.diffJump);
            this.Controls.Add(this.diffCount);
            this.Controls.Add(this.diffConst);
            this.Controls.Add(this.diffNext);
            this.Controls.Add(this.diffPrev);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Difference";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox firstTextBox;
        private System.Windows.Forms.RichTextBox secondTextBox;
        private System.Windows.Forms.Button diffPrev;
        private System.Windows.Forms.Button diffNext;
        private System.Windows.Forms.Label diffConst;
        private System.Windows.Forms.Label diffCount;
        private System.Windows.Forms.Button diffJump;
        private System.Windows.Forms.Button diffFirst;
        private System.Windows.Forms.Button diffSecond;
        private System.Windows.Forms.Button diffDelete;
        private System.Windows.Forms.Button diffFirstRest;
        private System.Windows.Forms.Button diffSecondRest;
        private System.Windows.Forms.Button diffDeleteRest;
        private System.Windows.Forms.Button diffDone;
        private System.Windows.Forms.Button backToOpenFile;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}